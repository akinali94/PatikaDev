using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi;
using WebApi.Common;
using WebApi.DBOperations;

namespace Webapi.BookOperations.GetBookDetail{

    public class GetBookDetailQuery{

        private readonly BookStoreDbContext _dbContext;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDbContext dbContext){
            _dbContext = dbContext;
        }

        public BookDetailViewModel Handle(){
            var book = _dbContext.Books.Where(book => book.Id == BookId).SingleOrDefault();

            if(book is null)
                throw new InvalidOperationException("Kitap Bulunamadi!");

            BookDetailViewModel vm = new BookDetailViewModel();
            vm.Title = book.Title;
            vm.Genre = ((GenreEnum)book.GenreId).ToString();
            vm.PageCount = book.PageCount;
            vm.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy");
            return vm;
        }

    }

    public class BookDetailViewModel{
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
    }

}