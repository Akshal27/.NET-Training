using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Web.Services;

namespace Calculation_Services2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.


    public class Service1 : IService1
    {

        [WebMethod]
        public int Addition(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        
        }

        [WebMethod]
        public string DisplayName(string studentName, int studentAge, string StudentCourse)
        {
            //throw new NotImplementedException();
            Console.WriteLine("The student name {0}, age {1}, course {2}",studentName,studentAge,StudentCourse);
            return studentName+","+studentAge + "," + StudentCourse;
        
        }

        [WebMethod]
        public int Division(int a, int b)
        {
            //throw new NotImplementedException();

            if (a>b)
            {
                return a / b;
            }
            else
            {
                return b / a;
            }
        }

        [WebMethod]
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        [WebMethod]
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
       
        [WebMethod]
        public string Information(int id, string name, int age)
        {
            //throw new NotImplementedException();
            return id + ", " + name + ", " + age;


        }

        [WebMethod]
        public void insertData(int id, string EmpName, string Department, long Salary)
        {
            //throw new NotImplementedException();
            SqlConnection data1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\91842\\Documents\\.net projects\\Calculation_Services2\\Calculation_Services2\\App_Data\\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            data1.Open();
            SqlCommand cmd = new SqlCommand("insert into Employee(Id, EmpName, Department, Salary) values('"+id+"','"+EmpName+"','"+Department+"','"+Salary+"'",data1);
            cmd.ExecuteNonQuery();
            data1.Close();

        }

        [WebMethod]
        public int Mutiplication(int a, int b)
        {
            //throw new NotImplementedException();
            return a * b;
        
        }

        [WebMethod]
        public int Subtraction(int a, int b)
        {
            //throw new NotImplementedException();
            return a - b;
        }
    }
}
