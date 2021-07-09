using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Person
    {
        public int _id { get; set; }
        public string first_names { get; set; }
        public string last_names { get; set; }
        public string date_of_birth { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string tutor { get; set; }
    }
}
