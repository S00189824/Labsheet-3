using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class TheSchool : IComparable<>
    {
        public string SchoolName { get; set; }
        public int numberOfSchools { get; set; }
        public int NumberOfEnrollment { get; set; }

        public void theschool(string schoolname,int numberOfEnrollment)
        {
            schoolname = SchoolName;
            numberOfEnrollment = NumberOfEnrollment;
        }
    }
}
