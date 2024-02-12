using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_3
{
    internal class StudentWSIiZ : Student
    {
        public new string GetEducationInfo()
        {
            return WypiszPelnaNazweIUczelnie();
        }
    }
}
