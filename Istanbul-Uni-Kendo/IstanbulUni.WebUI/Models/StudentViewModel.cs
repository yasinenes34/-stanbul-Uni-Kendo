using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IstanbulUni.WebUI.Models
{
    public class StudentViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int StudentNo { get; set; }
        public string UniversityName { get; set; }
        public decimal examScore { get; set; }
    }
}