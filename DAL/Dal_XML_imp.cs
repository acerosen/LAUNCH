using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;
using DS;
using System.IO;
using System.ComponentModel;

namespace DAL
{
    public class Dal_XML_imp : Idal
    {
        XElement traineeRoot;
        string traineePath = @"traineeXml.xml";
        XElement testerRoot;
        string testerPath = @"testerXml.xml";
        XElement testRoot;
        string testPath = @"testXml.xml";
        XElement TestIDRoot;
        string TestIDPath = @"TestIDXml.xml";

        public Dal_XML_imp()
        {
            try
            {
                if (!File.Exists(traineePath))//trainee
                {
                    traineeRoot = new XElement("traineees");
                    traineeRoot.Save(traineePath);

                }
                else traineeRoot = XElement.Load(traineePath);
                if (!File.Exists(testerPath))//tester
                {
                    testerRoot = new XElement("testers");
                    testerRoot.Save(testerPath);
                }
                else testerRoot = XElement.Load(testerPath);
                if (!File.Exists(testPath))//test
                {
                    testRoot = new XElement("tests");
                    testRoot.Save(testPath);
                }
                else testRoot = XElement.Load(testPath);
                if (!File.Exists(TestIDPath))//trainee
                {
                    TestIDRoot = new XElement("testIDs");
                    TestIDRoot.Save(TestIDPath);

                }
                else traineeRoot = XElement.Load(traineePath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
            //orderRoot.RemoveAll();
            //traineeRoot.Save(orderPath);
        }
    
        

        

        #region trainee
        public bool findTrainee(int numbertrainee)
        {
            XElement brancElement;
            brancElement = (from p in traineeRoot.Elements()
                            where Convert.ToInt32(p.Element("branchNumber").Value) == numbertrainee
                            select p).FirstOrDefault();
            if (brancElement == null)
                return false;
            return true;
        }

        public void addTrainee(Trainee b)
        {
            if (findTrainee(b.branchNumber))
                throw new Exception("The trainee is already exsist in the system");
            XElement branchNumber = new XElement("branchNumber", b.branchNumber);
            XElement FirstName = new XElement("FirstName", b.FirstName);
            XElement FamilyName = new XElement("FamilyName", b.FamilyName);
            XElement Gender = new XElement("Gender", b.Gender);
            XElement PhoneNum = new XElement("PhoneNum", b.PhoneNum);
            XElement Address = new XElement("Address", b.Address);
            XElement Birthday = new XElement("Birthday", b.Birthday);
            XElement Model = new XElement("Model", b.Model);
            XElement GearType = new XElement("GearType", b.GearType);
            XElement School = new XElement("School", b.School);
            XElement TeacherName = new XElement("TeacherName", b.TeacherName);
            XElement LessonAMT = new XElement("LessonAMT", b.LessonAMT);
            traineeRoot.Add(new XElement("trainee", branchNumber, FirstName, FamilyName, Gender, PhoneNum, Address, Birthday, Model, GearType, School, TeacherName, LessonAMT));
            traineeRoot.Save(traineePath);
        }

        public void deleteTrainee(int numberBr)
        {
            XElement traineeElement;
            traineeElement = (from p in traineeRoot.Elements()
                             where Convert.ToInt32(p.Element("branchNumber").Value) == numberBr
                             select p).FirstOrDefault();
            if (traineeElement == null)
                throw new Exception("The trainee doesn't exsist in the system");
            traineeElement.Remove();
            traineeRoot.Save(traineePath);
        }

        public void updateTrainee(Trainee b)
        {

            XElement traineeElement = (from p in traineeRoot.Elements()
                                      where Convert.ToInt32(p.Element("branchNumber").Value) == b.branchNumber
                                      select p).FirstOrDefault();
            traineeElement.Element("FirstName").Value = b.FirstName;
            traineeElement.Element("FamilyName").Value = b.FamilyName;
            traineeElement.Element("Gender").Value = b.Gender.ToString();
            traineeElement.Element("PhoneNum").Value = (b.PhoneNum).ToString();
            traineeElement.Element("Address").Value = b.Address.ToString();
            traineeElement.Element("Birthday").Value = b.Birthday.ToString();
            traineeElement.Element("Model").Value = b.Model;
            traineeElement.Element("GearType").Value = b.GearType.ToString();
            traineeElement.Element("School").Value = b.School;
            traineeElement.Element("TeacherName").Value = b.TeacherName;
            traineeElement.Element("LessonAMT").Value = (b.LessonAMT).ToString();
            traineeRoot.Save(traineePath);
        }

        public Trainee getTrainee(int numB)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trainee> getAllTrainee(Func<Trainee, bool> predicat = null)
        {
            IEnumerable<Trainee> trainees;
            try
            {
                trainees = from item in traineeRoot.Elements()
                           // where predicat
                           select new Trainee()
                           {
                               branchNumber = Convert.ToInt32(item.Element("branchNumber").Value),
                               FirstName = Convert.ToString(item.Element("FirstName").Value),
                               FamilyName = Convert.ToString(item.Element("FamilyName").Value),
                               Address = Convert.ToString(item.Element("Address").Value),
                              LessonAMT = Convert.ToInt32(item.Element("LessonAMT").Value),
                              PhoneNum = Convert.ToInt32(item.Element("PhoneNum").Value),
                               Gender = (Gender)Enum.Parse(typeof(Gender), item.Element("Gender").Value),
                               Birthday = Convert.ToDateTime(item.Element("Birthday").Value),
                              GearType = (GearType)Enum.Parse(typeof(GearType), item.Element("GearType").Value),
                              School = Convert.ToString(item.Element("School").Value),
                               TeacherName = Convert.ToString(item.Element("TeacherName").Value),
                               Model = Convert.ToString(item.Element("Model").Value),

                           };
                if (predicat != null)
                {
                    trainees = trainees.Where(predicat);

                }
            }
            catch
            {
                trainees = null;
            }
            return trainees;
        }
        #endregion
        #region tester
        public bool findTester(int numbertester)
        {
            XElement brancElement;
            brancElement = (from p in testerRoot.Elements()
                            where Convert.ToInt32(p.Element("TesterID").Value) == numbertester
                            select p).FirstOrDefault();
            if (brancElement == null)
                return false;
            return true;
        }

        public void addTester(Tester T)
        {
            if (findTester(T.TesterID))
                throw new Exception("The tester is already exsist in the system");
            XElement TesterID = new XElement("TesterID", T.TesterID);
            XElement FamilyName = new XElement("FamilyName", T.FamilyName);
            XElement FirstName = new XElement("FirstName", T.FirstName);
            XElement Birthday = new XElement("Birthday", T.Birthday);
            XElement Gender = new XElement("gender", T.gender);
            XElement PhoneNum = new XElement("PhoneNum", T.PhoneNum);
            XElement Address = new XElement("Address", T.Address);
            XElement Experience = new XElement("Experience", T.Experience);
            XElement MaxTestAmt = new XElement("MaxTestAmt", T.MaxTestAmt);
            XElement Model = new XElement("Model", T.Model);
            XElement MaxDist = new XElement("MaxDist", T.MaxDist);
            XElement Start = new XElement("Start", T.Start);
            XElement Finish = new XElement("Finish", T.Finish);
            testerRoot.Add(new XElement("Tester", TesterID, FamilyName, FirstName, Birthday, Gender, PhoneNum, Address, Experience, MaxTestAmt, Model, MaxDist, Start, Finish));
            testerRoot.Save(testerPath);
        }

        public void deleteTester(int numberBr)
        {
            XElement testerElement;
            testerElement = (from p in testerRoot.Elements()
                             where Convert.ToInt32(p.Element("TesterID").Value) == numberBr
                             select p).FirstOrDefault();
            if (testerElement == null)
                throw new Exception("The tester doesn't exsist in the system");
            testerElement.Remove();
            testerRoot.Save(testerPath);
        }

        public void updateTester(Tester b)
        {

            XElement testerElement = (from p in testerRoot.Elements()
                                      where Convert.ToInt32(p.Element("TesterID").Value) == b.TesterID
                                      select p).FirstOrDefault();
            testerElement.Element("FirstName").Value = b.FirstName;
            testerElement.Element("FamilyName").Value = b.FamilyName;
            testerElement.Element("gender").Value = b.gender.ToString();
            testerElement.Element("PhoneNum").Value = (b.PhoneNum).ToString();
            testerElement.Element("Address").Value = b.Address.ToString();
            testerElement.Element("Birthday").Value = b.Birthday.ToString();
            testerElement.Element("Model").Value = b.Model;
            testerElement.Element("Experience").Value = (b.Experience).ToString();
            testerElement.Element("MaxTestAmt").Value = (b.MaxTestAmt).ToString();
            testerElement.Element("MaxDist").Value = (b.MaxDist).ToString();
            testerElement.Element("Start").Value = (b.Start).ToString();
            testerElement.Element("Finish").Value = (b.Finish).ToString();
        }

        public Tester getTester(int numB)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tester> getAllTester(Func<Tester, bool> predicat = null)
        {
            IEnumerable<Tester> testers;
            try
            {
                testers = from p in testerRoot.Elements()
                          select new Tester()
                    {
                        TesterID = Convert.ToInt32(p.Element("TesterID").Value),
                        FamilyName = p.Element("FamilyName").Value.ToString(),
                        FirstName = p.Element("FirstName").Value.ToString(),
                        Birthday = DateTime.Parse(p.Element("Birthday").Value),
                        //gender = (Gender)Enum.Parse(typeof(Gender), p.Element("Gender").Value),
                        PhoneNum = Convert.ToInt32(p.Element("PhoneNum").Value),
                        Address = p.Element("Address").Value.ToString(),
                        Experience = Convert.ToInt32(p.Element("Experience").Value),
                        MaxTestAmt = Convert.ToInt32(p.Element("MaxTestAmt").Value),
                        Model = p.Element("Model").Value.ToString(),
                        MaxDist = Convert.ToInt32(p.Element("MaxDist").Value),
                        //Start = Convert.ToInt32(p.Element("Start").Value),
                        //Finish = Convert.ToInt32(p.Element("Finish").Value),
                          };
//                }
                if (predicat != null)
                {
                    testers = testers.Where(predicat);

                }
            }
            catch
            {
                testers = null;
            }
            return testers;
        }

        #endregion
        #region test
        public bool findTest(Test dd)
        {
            XElement testElement;
            testElement = (from p in testRoot.Elements()
                            where Convert.ToInt32(p.Element("TestID").Value) == dd.TestID
                            select p).FirstOrDefault();
            if (testElement == null)
                return false;
            return true;
        }
        public void addTest(Test b)
        {
            while (findTest(b))
                b.TestID++;
            XElement TestID = new XElement("TestID", b.TestID);
            XElement TesterID = new XElement("TesterID", b.TesterID);
            XElement TestDate = new XElement("TestDate", b.TestDate);
            XElement TraineeID = new XElement("TraineeID", b.TraineeID);
            XElement TestType = new XElement("TestType", b.TestType);
            XElement TestGrade = new XElement("TestGrade", b.TestGrade);

            testRoot.Add(new XElement("Test", TestID, TesterID, TraineeID, TestDate, TestType, TestGrade));
            testRoot.Save(testPath);
            testRoot.Save(testPath);

        }
        public void deleteTest(int num)
        {
            XElement TestElement;
            TestElement = (from p in testRoot.Elements()
                           where Convert.ToInt32(p.Element("TestID").Value) == num
                           select p).FirstOrDefault();
            if (TestElement == null)
                throw new Exception("this test does not exist");
            TestElement.Remove();
            testRoot.Save(testPath);

        }
        public void updateTest(Test b)
        {

            testRoot = XElement.Load(testPath);
            XElement item = (from p in testRoot.Elements()
                             where Convert.ToInt32(p.Element("TestID").Value) == b.TestID
                             select p).FirstOrDefault();
            if (item == null)
                throw new Exception("Test with the same number not found...");
            item.Element("TestGrade").Value = b.TestGrade.ToString();
            testRoot.Save(testPath);
        }

        public IEnumerable<Test> getAllTest(Func<Test, bool> predicat = null)
        {
            IEnumerable<Test> test;
            try
            {

                test = (from item in testRoot.Elements()
                         select new Test()
                         {
                             TestID = Convert.ToInt32(item.Element("TestID").Value),
                             TestDate = Convert.ToDateTime(item.Element("TestDate").Value),
                             TesterID = Convert.ToInt32(item.Element("TesterID").Value),
                             TraineeID = Convert.ToInt32(item.Element("TraineeID").Value),
                             TestType = (GearType)Enum.Parse(typeof(GearType), item.Element("TestType").Value),
                             TestGrade = (Grade)Enum.Parse(typeof(Grade), item.Element("TestGrade").Value),
                         }).ToList();
                if (predicat != null)
                {
                    test = test.Where(predicat);

                }
            }

            catch
            {
                test = null;
            }
            return test;
        }
        public Test getTest(int numB)
        {
            throw new NotImplementedException();
        }
        #endregion

        public List<Tester> getListTesters()
        {
            throw new NotImplementedException();
        }

        public List<Trainee> getListTraineees()
        {
            throw new NotImplementedException();
        }
        public List<Test> getListTests()
        {
            throw new NotImplementedException();
        }


    }
}
