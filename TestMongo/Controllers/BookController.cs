using TestMongo.Models;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestMongo.Repositories;
using System.Threading.Tasks;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        // private readonly BookService _bookService;
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public async Task<ActionResult<Book>> Get(string id)
        {
            var book = await _bookRepository.Get(id);
            if (book == null) return NotFound();

            return book;
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Create(Book book)
        {
            await _bookRepository.Create(book);

            return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        }

        [HttpGet(Name = "GetAllBook")]
        public async Task<ActionResult<IEnumerable<Book>>> GetAll()
        {
            var books = await _bookRepository.GetAll();
            return Ok(books);
        }

        [HttpGet("test")]
        public async Task<ActionResult<Book>> CreateGet()
        {
            var book = new Book { Author = "Aaa", BookName = "TestNom", Price = 4 };
            await _bookRepository.Create(book);

            return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<ActionResult> Update(string id, Book bookIn)
        {
            var book = await _bookRepository.Get(id);
            if (book == null) return NotFound();
            await _bookRepository.Update(id, bookIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<ActionResult> Delete(string id)
        {
            var book = await _bookRepository.Get(id);
            if (book == null) return NotFound();
            await _bookRepository.Delete(book.Id);

            return NoContent();
        }
    }
}