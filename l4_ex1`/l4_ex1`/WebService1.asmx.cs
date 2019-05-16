using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace l4_ex1_
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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double convFtoC(double f)
        {
            return (f - 32) * (9 / 5);
        }

        [WebMethod]
        public string getCurrentDateAndTime()
        {
            return DateTime.Now.ToString();
        }

        [WebMethod]
        public List<int> getList()
        {
            return new List<int> { 1, 2, 3, 4, 5 };
        }

        [WebMethod]
        public double convertRonToE(double ron)
        {
            return 4.76 * ron;
        }
    }
}
