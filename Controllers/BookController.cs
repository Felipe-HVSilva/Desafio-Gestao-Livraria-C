using Libary.Communication.Request;
using Libary.View;
using Microsoft.AspNetCore.Mvc;

namespace Libary.Controllers;

public class BookController : LibaryBaseController
{
  
    [HttpGet]
    public IActionResult GetAll()
    {
        var listBook = new List<Book>() { 
            new Book { Id = 1, Author = "Bob", Gender = Book.Genders.Fiction, Price = 50, Title = "Clean Code", Quantity = 4 },
            new Book { Id = 2, Author = "Scoot Young", Gender = Book.Genders.Fiction, Price = 20, Title = "UltraLearning", Quantity = 2 },
        };
        
        return Ok(listBook);
    }


    [HttpPost]
    [ProducesResponseType(typeof(RequestRegisterBookJson),StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var book =  new RequestRegisterBookJson() 
        { 
            Id =  2,
            Author = request.Author, 
            Gender= request.Gender,
            Price = request.Price, 
            Title = request.Title,
            Quantity = request.Quantity
        };
        return Created(string.Empty, book);
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NotFound();
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateBookJson request)
    {
        var book = new RequestUpdateBookJson()
        {
            Author = request.Author,
            Price = request.Price,
            Title = request.Title,
            Quantity = request.Quantity
        };
        return NoContent();
    }
  
}

