using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BE
{
    public class Trainee
    {
        public int branchNumber { get;  set; } // number of trainee
        public string FirstName { get; set; }  // First Name
        public string FamilyName { get; set; }  // Last Name
        public Gender Gender { get; set; }  // Gender
        public int PhoneNum { get; set; }  // Cellphone Number
        public string Address { get; set; } //Address
        public DateTime Birthday { get; set; }  // Date of Birth
        public string Model { get; set; } //Car Model
        public GearType GearType { get; set; } //Type of Transmission (Manual or Automatic)
        public string School { get; set; } //Name of Driving School
        public string TeacherName { get; set; } //Name of Teacher
        public int LessonAMT { get; set; } //Amount of Lessons
        public override string ToString()
        {
            return "TraineeID: " + branchNumber + "\nfamilyName: " + FamilyName + "\nprivateName" + FirstName + "\nbirthday: " + Birthday + "\ngender: " + Gender + "\nphoneNum: " + PhoneNum + "\naddress : " + Address + "\nGearType: " + GearType + "\nschool : " + School + "\nModel : " + Model + "\ntheacherName : " + TeacherName + "\nLessonAmt : " + LessonAMT;
        }
    }
}
