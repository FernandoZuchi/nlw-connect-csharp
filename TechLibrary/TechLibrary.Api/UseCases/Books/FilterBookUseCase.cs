using TechLibrary.Api.Infraestructure.DataAccess;
using TechLibrary.Communication.Requests;
using TechLibrary.Communication.Responses;

namespace TechLibrary.Api.UseCases.Books;

public class FilterBookUseCase
{
    public ResponseBooksJson Execute(RequestFilterBooksJson request)
    {
        var dbContext = new TechLibraryDbContext();

        var books = dbContext.Books.ToList();

        return new ResponseBooksJson
        {
            Books = books.Select(book => new ResponseBookJson
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author
            }).ToList(),
        };
    }
}
