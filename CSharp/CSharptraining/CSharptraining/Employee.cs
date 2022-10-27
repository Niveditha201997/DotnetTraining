using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharptraining
{
    public class Employee
    {
        public int  Id { get; set; }
        public string Firstname{ get; set; }
        public string Lasttname { get; set; }
        public string Email { get; set; }
        public double Mobile { get; set; }

        public void CreateEmployee()
        {
            int[] empId=new int[4];
            string[] names = new string[4];

            int[] numbers = {3,4,5,6,7};

            for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine("Enter id : ");
                empId[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter name : ");
                names[i]=Console.ReadLine();    
            }  

           /* Console.WriteLine("Enter Id : ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Firstname : ");
            Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname : ");
            Lasttname = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Mobile : ");
            Mobile = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************");
            Console.WriteLine("emplyoee Detsils: "+Id+","+Firstname+","+Lasttname+","+Email+","+Mobile);
            Console.WriteLine("Created.....");*/

        }
        public void UpdateEmployee()
        {
            Console.WriteLine("Updated.....");
        }
        public void GetEmployee()
        {
            Dictionary<int, string> empData = new Dictionary<int, string>();
            empData.Add(11, "nive");
            empData.Add(12, "arti");
            empData.Add(13, "sound");
            var value = empData[1001];
            //var,dynamic
            var a = 10;
            var b = "10";
            dynamic d1 = 10;
            dynamic d2 = "10";    


            foreach (var item in empData)
            {
                Console.WriteLine(item.);
            }


            List<int> values = new List<int>();
            values.Add(1);
            List<string> namesValues = new List<string>();
            namesValues.Add("11");
            List<double> salaryValue = new List<double>();
            salaryValue.Add(12.45);

            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            employee.Id = 234;
            employee.Email = "nive@gmail.com";
            employee.Firstname = "nive";
            employee.Lasttname = "naik";
            employee.Mobile = 763457;
            employees.Add(employee);    

            employee = new Employee();
            employee.Id = 4534;
            employee.Email = "ve@gmail.com";
            employee.Firstname = "nive";
            employee.Lasttname = "naik";
            employee.Mobile = 765673457;
            employees.Add(employee);

            foreach(var item in employees)
            {
                Console.WriteLine(item.Id);
            }

            //ArrayList employeelist = new ArrayList();
            //employeelist.Add(11);
            //employeelist.Add(12.45);
            //employeelist.Add(true); 
            //employeelist.Add("nive");
            ////employeelist.Remove(true);
            ////employeelist.RemoveAt(1);
            //for (int i = 0; i < employeelist.Count; i++)
            //{
            //    Console.WriteLine(employeelist[i]);
            //}

            //Stack stack = new Stack();
            //stack.Push(11);
            //stack.Push("nive");
            //stack.Push(12.87);
            //stack.Push(true);

            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();


            //object a = 10;
            //object b = 10.30;
            //object c = true;
            //object d = "nive";

            //Console.WriteLine("Reading....");
            //try
            //{
            //    Console.WriteLine("Enter name : ");
            //    int acno = Convert.ToInt32(Console.ReadLine());
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine("Invalid Input!!!");
            //}
            //catch (Exception e)
            //{
            //    // Console.WriteLine(e.Message);
            //    Console.WriteLine("Error...!");
            //}                      
        }
        //public void SearchEmplyoee(int id)
        //{
        //    if (id == 11)
        //    {
        //        Console.WriteLine("Reading");
        //        Console.WriteLine("Employee details : "+ Id + "," + Firstname + "," + Lasttname + "," + Email + "," + Mobile);
        //    }
        //}
        //public void SearchEmplyoee(String name)
        //{
        //    if(name == "Raj")
        //    {
        //        Console.WriteLine("Reading");
        //        Console.WriteLine("Employee details : " + Id + "," + Firstname + "," + Lasttname + "," + Email + "," + Mobile);
        //    }
        //}
        //public void SearchEmplyoee(double salary)
        //{
        //    if (salary == 12.33)
        //    {
        //        Console.WriteLine("Reading");
        //        Console.WriteLine("Employee details : " + Id + "," + Firstname + "," + Lasttname + "," + Email + "," + Mobile);
        //    }
        //} 
        public void SearchEmplyoee<T>(T input)
        {
            Console.WriteLine("My input : "+input);
        }

    }

}
