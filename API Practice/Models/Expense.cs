using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Practice.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int expense { get; set; }

        public int CategoryId { get; set; }

        public string ExpenseName { get; set; }

        public int UseId { get; set;}

        public string ExepenseDate { get; set; }


    }
}