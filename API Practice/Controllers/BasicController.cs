using API_Practice.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Net;

namespace API_Practice.Controllers
{
    public class BasicController : ApiController
    {

        //making list of books 
      public  static  List<BookModel> books = new List<BookModel>();
     

      [Route("api/GetAllBooks")]
        [HttpGet]
        public object getall()
        {
            // return list of book
            return Request.CreateResponse(HttpStatusCode.OK, books);
        }

        [Route("api/CreateBook")]
        [HttpPost]

      
        public object CreateBook(int Id,string title,string Description)
        {
            BookModel newbook = new BookModel(Id,title,Description);
            //adding new book in list 
            books.Add(newbook);
           // returning new created book and status code success.
            return Request.CreateResponse(HttpStatusCode.OK,newbook);
          
            
          
        }


    }
}
