using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CodeFirtstApproach.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public string EmpAddress { get; set; }

        public string EmpEmail { get; set; }

        public string EmpDepartment { get; set; }


        public int EmpSalary { get; set; }


    }
}