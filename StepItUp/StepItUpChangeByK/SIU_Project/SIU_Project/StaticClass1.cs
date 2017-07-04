using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIU_Project
{
    class StaticClass1
    {
        static int studentID=0;
        
        public static int studentIDVal() {
            studentID += 1;
            return studentID;
        }
    }
}
