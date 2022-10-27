using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharptraining
{
    public class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();
            
            MyDelegateReport myDelegateReport = new MyDelegateReport(report.PdfReport);
            myDelegateReport += new MyDelegateReport(report.ExcelReport);
            myDelegateReport += new MyDelegateReport(report.XmlReport);
            string role = "Admin";
            if (role == "Admin")
            {
                myDelegateReport("");
            }
            else
            {
                myDelegateReport -= new MyDelegateReport(report.XmlReport);
                myDelegateReport("");
            }


            //Employee employee = new Employee();
            //employee.GetEmployee();

            //employee.SearchEmplyoee<int>(12);
            //employee.SearchEmplyoee<double>(13.12);
            //employee.SearchEmplyoee<string>("nive");
            //employee.SearchEmplyoee<bool>(true);
            //employee.SearchEmplyoee<object>(45);

            //employee.SearchEmplyoee(2);
            //employee.SearchEmplyoee(12.33);
            //employee.SearchEmplyoee("nive");

            // employee.CreateEmployee();

            //employee.GetEmployee();

            //nokia nokia = new nokia();
            //nokia.year = 2002;
            //nokia.model = "123";

            //samsung samsung = new samsung();
            //samsung.year = 2003;
            //samsung.model = "345";



            /* Employee employee = new Employee();
             employee.Firstname = "niveditha";
             employee.CreateEmployee();
             employee.UpdateEmployee();
             employee.GetEmployee();
             employee.SearchEmplyoee(11);*/



            /* Console.Write("Enter the value1: ");
            int a = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter the value2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.Write(c);
            Console.Write("completed");*/

            /* for(int i = 0; i < 4; i++)
             {

             }*/
            Console.Read();
        }
    }
}
