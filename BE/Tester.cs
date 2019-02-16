using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester
    {
        public int TesterID { get; set; } //Teudat Zehut
        public string FamilyName { get; set; } //Last Name
        public string FirstName { get; set; } //First Name
        public DateTime Birthday { get; set; } //Date of Birth
        public Gender gender { get; set; } //Gender
        public int PhoneNum { get; set; } //Cellphone Number
        public string Address { get; set; } //Address
        public int Experience { get; set; } //Amount of Hours Teaching
        public int MaxTestAmt { get; set; } //Maximum Amount of Hours Able to Teach per Week
        public string Model { get; set; } //Model of Preffered Car
        public int Start { get; set; }
        public int Finish { get; set; } //Hours that tester Works (Max: 0900-1500)
        public int MaxDist { get; set; } //Furthest the Tester is Able to Test from Tester.address
        public override string ToString()
        {
            return "TesterID: " + TesterID + "\nName: " + FamilyName  + FirstName + "\nbirthday: " + Birthday + "\nGender: " + gender + "\nPhone number: " + PhoneNum + "\nAddress: " + Address + "\nYears of experience: " + Experience + "\nMax tests per week: " + MaxTestAmt + "\nCar Model: " + Model + "\nMax Distance of trainee: " + MaxDist + "\nWork time: from " + Start + " to " + Finish;
        }
    }
}


