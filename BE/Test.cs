using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        public int TestID { get; set; }
        public Grade TestGrade { get; set; }
        public GearType TestType { get; set; }
        public int TraineeID { get; set; }
        public int TesterID { get; set; }
        public DateTime TestDate { get; set; }
        public override string ToString()
        {
            return "TestID: " + TestID + "\nVehicleType" + TestType + "\nTraineeID" + TraineeID + "\nTesterID" + TesterID + "\nTestDate" + TestDate + "\nTestGrade: " + TestGrade;
        }
    }
}
