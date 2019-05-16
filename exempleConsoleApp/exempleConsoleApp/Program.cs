using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            exempleConsoleApp.ServiceReference1.WebService1SoapClient service = new exempleConsoleApp.ServiceReference1.WebService1SoapClient();

            double c = service.convFtoC(45.6);
            Console.WriteLine("The chelsius temp is: " + c.ToString());
            Console.ReadKey();

        }
    }
}
