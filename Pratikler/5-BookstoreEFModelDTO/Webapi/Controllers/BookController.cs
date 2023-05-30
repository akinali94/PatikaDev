
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Webapi.BookOperations.GetBooks;
using Webapi.BookOperations.GetBookDetail;
using WebApi;
using WebApi.BookOperations.CreateBook;
using WebApi.DBOperations;
using static WebApi.BookOperations.CreateBook.CreateBookCommand;
using WebApi.BookOperations.UpdateBook;
using static WebApi.BookOperations.UpdateBook.UpdateBookCommand;
using WebApi.BookOperations.DeleteBook;

namespace Webapi.AddControllers{

    [ApiController]
    [Route("[Controller]s")]
    public class BookController : ControllerBase {
        private readonly BookStoreDbContext _context;  

        public BookController(BookStoreDbContext context){
            _context = context;
        }


        [HttpGet]
        public IActionResult GetBooks(){
            
            //Önceki işlemlerimizde, doğrudan entity'den çağırıyorduk. Bu doğru bir yöntem değildi.
            GetBooksQuery query = new GetBooksQuery(_context);
            var result = query.Handle();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id){

            BookDetailViewModel result;
            try
            {
                GetBookDetailQuery query = new GetBookDetailQuery(_context);
                query.BookId = id;
                result = query.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }

            return Ok(result);
            
            

        }

        
        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook){ 
           
            CreateBookCommand command = new CreateBookCommand(_context);
            try
            {
                command.Model = newBook;
                command.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
            
            return Ok();

            /*
            var book = _context.Books.SingleOrDefault(x=> x.Title == newBook.Title);
            if(book is not null){ 
                return BadRequest(); 
            }
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return Ok();
            */
        }

        [HttpPut("{id}")] 
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updatedBook){ 
            
            try
            {
                UpdateBookCommand command = new UpdateBookCommand(_context);
                command.BookId = id;
                command.Model = updatedBook;
                command.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
            return Ok();

        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id){
            DeleteBookCommand command = new DeleteBookCommand(_context);
            try
            {
                command.BookId = id;
                command.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
            return Ok();
        }

    }
}