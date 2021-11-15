using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project1.Models
{
    public class Salary
    {
        [Required(ErrorMessage = "Enter Employee ID")]
        [Display(Name = "Employee ID : ")]
        public int empid { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        [Display(Name = "Name : ")]
        public string empname { get; set; }
        [Required(ErrorMessage = "Enter your BasicPay")]
        [Display(Name = "Basic Pay: ")]
        public double basicpay { get; set; }
        [Display(Name = "DA(Dearness Allowance): ")]
        public double da { get; set; }
        [Display(Name = "HRA(House Rent Allowance): ")]
        public double hra { get; set; }
        [Display(Name = "PF(Provident Fund): ")]
        public double pf { get; set; }
        [Display(Name = "Tax: ")]
        public double tax { get; set; }
        [Display(Name = "Net Salary: ")]
        public double netsalary { get; set; }
    }
    public class SalaryModel
    {
        public List<Salary> SalaryList { get; set; }
    }
}