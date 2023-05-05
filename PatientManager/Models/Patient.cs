using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManager.Models
{
    internal class Patient
    {
        public int CI { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BloodType { get; set; }
    }
}
