using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTeacher
{
    class Teacher:Person
    {
        private string subject { get; set; }

        public string Explain()
        {
            return "Explanation begins";
        }
    }
}
