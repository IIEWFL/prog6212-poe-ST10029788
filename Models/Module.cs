using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModuleCalculatorWeb.Models
{
    [
        Table("Modules")
    ]
    public class Module
    {

        [Key]
        public int moduleID { get; set; }
        public string moduleCode { get; set; }
        public string moduleName { get; set; }
        public int credits { get; set; }
        public int hrs { get; set; }
        public int selfStudy { get; set; }
        public int Weeks { get; set; }
        public int studyHrs { get; set; }
        public System.DateTime studyDate { get; set; }
        public int remain { get; set; }


    }

}


