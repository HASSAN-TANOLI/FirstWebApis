using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Models
{
    public class Employes
    {
        public int Employesid { get; set; }
        public String empname { get; set; }
        public String empemail { get; set; }
        public String empaddress { get; set; }
        public String empdesignation { get; set; }
        public int empsalary { get; set; }
    }
}
