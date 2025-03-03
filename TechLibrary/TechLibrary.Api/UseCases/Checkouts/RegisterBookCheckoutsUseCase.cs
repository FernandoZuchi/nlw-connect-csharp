﻿using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using TechLibrary.Api.Infraestructure.DataAccess;
using TechLibrary.Api.Services;
using TechLibrary.Exception;

namespace TechLibrary.Api.UseCases.Checkouts;

public class RegisterBookCheckoutsUseCase
{
    private const int MAX_LOAN_DAYS = 7;
    private readonly LoggedUserService _loggedUser;

    public RegisterBookCheckoutsUseCase(LoggedUserService loggedUser)
    {
        _loggedUser = loggedUser;
    }
    public void Execute(Guid bookId)
    {
        var dbContext = new TechLibraryDbContext();

        Validate(dbContext, bookId);

        var user = _loggedUser.User();

        var entity = new Domain.Entities.Checkout
        {
            BookId = bookId,
            ExpectedReturnDate = DateTime.UtcNow.AddDays(MAX_LOAN_DAYS)
        };

        dbContext.Checkouts.Add(entity);

        dbContext.SaveChanges();
    }

    private void Validate(TechLibraryDbContext dbContext, Guid bookId)
    {
        var book = dbContext.Books.FirstOrDefault(book => book.Id == bookId);

        if (book is null)
            throw new NotFoundException("Livro não ecnontrado.");

        var amountBooksNotReturned = dbContext
                                    .Checkouts
                                    .Count(checkout => checkout.BookId == bookId && checkout.ReturnedDate == null);

        if (amountBooksNotReturned == book.Amount)
            throw new ConflictException("Livro não está disponível para empréstimo.");
    }
}
