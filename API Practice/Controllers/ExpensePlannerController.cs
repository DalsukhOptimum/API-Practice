using API_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SQLHelper;
using System.Data.SqlClient;
using System.Data;

namespace API_Practice.Controllers
{
    public class ExpensePlannerController : ApiController
    {
       
        //Adding Expense in database 
        //taking Expense object in body
        [Route("api/AddExpense")]
        [HttpPost]
        public object geAddExpense([FromBody] Expense obj)
        {
            SqlCommands sqlCommands = new SqlCommands();
            //calling AddExpense method of sqlCommand class

          int cnt =   sqlCommands.AddExepnse(obj.expense, obj.CategoryId, obj.ExpenseName, obj.ExepenseDate, obj.UseId);
            //if cnt > 0 means we added the expense
            if(cnt > 0)
            {

                return obj;
            }
            return "something went wrong";
        }

        //this is same as belowe get request in this i did with post request
        //[Route("api/ShowExpense")]
        //[HttpPost]
        //public DataTable ShowExpense([FromBody] Expense obj)
        //{
        //    SqlCommands sqlCommands = new SqlCommands();
        //    DataTable dt = sqlCommands.ShowExpense(obj.UseId);

        //    return dt;
        //}


        //showing expense of particular user
        [Route("api/ShowExpense")]
        [HttpGet]
        public DataTable ShowExpense(int id)
        {
            SqlCommands sqlCommands = new SqlCommands();
            //calling showexepnse method of sqlcommand class
            DataTable dt = sqlCommands.ShowExpense(id);

            return dt;
        }

       // if you want soemthing from route and that is dynamic so spacify it like this and then accept that in method and then if you print that it will return that id
       //and if you also pass the parameter so it will print that parameter indrtead of your route's id 
      
        [Route("api/OneExpense/{id}")]
        [HttpGet]

        public object OneExpense(int id,int ok)
        {
            return id;
            
        }


    }
}
