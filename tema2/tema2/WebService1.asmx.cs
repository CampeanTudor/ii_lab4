using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace tema2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsNumbers;
        

        public WebService1()
        {
            System.Diagnostics.Debug.WriteLine("Entered the constructor AAAAAAAAAAA");
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename =|DataDirectory|\\Database1.mdf;Integrated Security = True";
            
        }

      

        [WebMethod]
        public List<int> getAll()
        {
            myCon.Open();
            dsNumbers = new DataSet();
            SqlDataAdapter daNumbers = new SqlDataAdapter("SELECT * FROM Numbers", myCon);
            daNumbers.Fill(dsNumbers, "Numbers");

            List<int> allNrs = new List<int>();
            foreach (DataRow dr in dsNumbers.Tables["Numbers"].Rows)
            {
                allNrs.Add(int.Parse(dr.ItemArray.GetValue(1).ToString()));
                
            }
            myCon.Close();

            return allNrs;
        }

        [WebMethod]
        public void insertNr(int nrToInsert)
        { 
            myCon.Open();

            dsNumbers = new DataSet();
            SqlDataAdapter daNumbers = new SqlDataAdapter("SELECT * FROM Numbers", myCon);
            daNumbers.Fill(dsNumbers, "Numbers");

            List<int> allNrs = new List<int>();
            foreach (DataRow dr in dsNumbers.Tables["Numbers"].Rows)
            {
                allNrs.Add(int.Parse(dr.ItemArray.GetValue(0).ToString()));

            }

            int idToInsert = allNrs.Last();
            idToInsert++;

            SqlCommand cmdInsert = new SqlCommand("INSERT INTO Numbers (id,value) " +
                "VALUES (@value1,@value1)", myCon);
            cmdInsert.Parameters.AddWithValue("@value1", idToInsert);
            cmdInsert.Parameters.AddWithValue("@value2", nrToInsert);

            cmdInsert.ExecuteNonQuery();

            myCon.Close();
        }

        [WebMethod]
        public void updateNr(int newValue, int idToUpdate)
        {
            myCon.Open();
            SqlCommand cmdInsert = new SqlCommand("UPDATE Numbers SET value=@value1 WHERE id=" +
                "@value2", myCon);
            cmdInsert.Parameters.AddWithValue("@value1", newValue);
            cmdInsert.Parameters.AddWithValue("@value2", idToUpdate);
            cmdInsert.ExecuteNonQuery();


            myCon.Close();
        }
    }
}
