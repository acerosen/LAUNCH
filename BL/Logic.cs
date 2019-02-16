using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.IO;

namespace ConsoleApplication
{
    class program
    {
        bool CheckAgeTrainee (Trainee T)
        {
             if (T.Birthday.Year > 2000)
                 return false;
            return true;
         }

        bool CheckAgeTester (Tester T)
        {
            if (T.Birthday.Year > 1978)
                return false;
            return true;
        }
    }
}

