
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SQLHelper
{
    public class SqlCommands: SqlConectionClass
    {


        //adding new expense to the database monthlyExpense
        public int AddExepnse(int Expense,int categoryId,string ExpenseName,string date,int userId)
         {
            try
            {
                con.Open();
                SqlCommand AddExpense = new SqlCommand("AddExpense", con);
                AddExpense.CommandType = System.Data.CommandType.StoredProcedure;
                AddExpense.Parameters.AddWithValue("@Expense", Expense);
                AddExpense.Parameters.AddWithValue("@CategoryId", categoryId);
                AddExpense.Parameters.AddWithValue("@ExpenseName", ExpenseName);
                AddExpense.Parameters.AddWithValue("@ExpenseDate", date);
                AddExpense.Parameters.AddWithValue("@UserId", userId);
                AddExpense.Parameters.AddWithValue("@ExpenseId", "");
                AddExpense.Parameters.AddWithValue("@OperationType", "AddExpense");
                int cnt = AddExpense.ExecuteNonQuery();
                con.Close();
                return cnt;
            }
            catch(Exception ex)
            {
                throw;

               
            }
            finally { con.Close(); }
           
        }

        //showing all expense of particular user
        public DataTable ShowExpense(int UserId)
        {
            try
            {
                con.Open();
                SqlCommand showexpense = new SqlCommand("ShowAllExpense", con);
                showexpense.CommandType = System.Data.CommandType.StoredProcedure;
                showexpense.Parameters.AddWithValue("@OperationType", "ShowAllExpenses");
                showexpense.Parameters.AddWithValue("@UserId", UserId);
                showexpense.Parameters.AddWithValue("@StartDate", "");
                showexpense.Parameters.AddWithValue("@EndDate", "");
                showexpense.Parameters.AddWithValue("@Month", "");
                showexpense.Parameters.AddWithValue("@Year", "");

                SqlDataReader readrer = showexpense.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(readrer);

                readrer.Close();
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
          
        }




    }
}
