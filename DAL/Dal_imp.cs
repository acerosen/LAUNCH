using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{

    public class Dal_imp : Idal
    {
        #region trainee
        /// <summary>
        /// check if the trainee already exists
        /// </summary>
        /// <param name="b"></param>
        public bool findTrainee(int numbertrainee)
        {
            if (DataSource.trainees.Count == 0)
                return false;
            foreach (Trainee item in DataSource.trainees)
                if (numbertrainee == item.branchNumber)
                    return true;
            return false;
        }
        public void addTrainee(Trainee b)
        {
            if (!findTrainee(b.branchNumber))
                DataSource.trainees.Add(b);
            else
                throw new Exception("this trainee is already exist");
        }
        public void deleteTrainee(int numberBr) //recieve trainee number
        {
            if (!findTrainee(numberBr))
                throw new Exception("this trainee is not exist");
            DataSource.trainees.RemoveAll(br => br.branchNumber == numberBr);
        }
        public void updateTrainee(Trainee b)
        {
            bool flag = false;
            for (int i = 0; i < DataSource.trainees.Count; i++)
                if (DataSource.trainees[i].branchNumber == b.branchNumber)
                {
                    DataSource.trainees[i] = b;
                    flag = true;
                }
            if (!flag)
                throw new Exception("this trainee is not exist");
        }
        public Trainee getTrainee(int numB)
        {
            return DataSource.trainees.FirstOrDefault(b => b.branchNumber == numB);
        }
        public IEnumerable<Trainee> getAllTrainee(Func<Trainee, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.trainees.AsEnumerable();
            return DataSource.trainees.Where(predicat);
        }


        #endregion
        #region tester
        /// <summary>
        /// check if the trainee already exists
        /// </summary>
        /// <param name="b"></param>
        public bool findTester(int numbertester)
        {
            if (DataSource.testers.Count == 0)
                return false;
            foreach (Tester item in DataSource.testers)
                if (numbertester == item.TesterID)
                    return true;
            return false;
        }
        public void addTester(Tester b)
        {
            if (!findTester(b.TesterID))
                DataSource.testers.Add(b);
            else
                throw new Exception("this tester is already exist");
        }
        public void deleteTester(int numberBr) //recieve trainee number
        {
            if (!findTester(numberBr))
                throw new Exception("this tester does not exist");
            DataSource.testers.RemoveAll(br => br.TesterID == numberBr);
        }
        public void updateTester(Tester b)
        {
            bool flag = false;
            for (int i = 0; i < DataSource.testers.Count; i++)
                if (DataSource.testers[i].TesterID == b.TesterID)
                {
                    DataSource.testers[i] = b;
                    flag = true;
                }
            if (!flag)
                throw new Exception("this tester does not exist");
        }
        public Tester getTester(int numB)
        {
            return DataSource.testers.FirstOrDefault(b => b.TesterID == numB);
        }
        public IEnumerable<Tester> getAllTester(Func<Tester, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.testers.AsEnumerable();
            return DataSource.testers.Where(predicat);
        }
        #endregion
        #region test
        public bool findTest(Test dd)
        {
            if (DataSource.tests.Count == 0)
                return false;
            foreach (Test item in DataSource.tests)
                if (dd.TestID == item.TestID)
                    return true;
            return false;
        }
        public void addTest(Test o)
        {
            foreach (Test item in DataSource.tests)
            {
                Console.WriteLine(item.ToString());
            }
            if (!findTest(o))
                DataSource.tests.Add(o);
            else
                throw new Exception("this test already exsits");
        }
        public void deleteTest(int num)
        {
            if (DataSource.tests.Find(s => s.TestID == num) == null)
                throw new Exception("this Test does not exist");
            DataSource.tests.RemoveAll(d => d.TestID == num);
        }
        public void updateTest(Test o)
        {
            for (int i = 0; i < DataSource.tests.Count; i++)
                if (DataSource.tests[i].TestID == o.TestID)
                    DataSource.tests[i] = o;
            throw new Exception("this test does not exist");
        }
        public Test getTest(int numB)
        {
            return DataSource.tests.FirstOrDefault(b => b.TestID == numB);
        }
        public IEnumerable<Test> getAllTest(Func<Test, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.tests.AsEnumerable();
            return DataSource.tests.Where(predicat);
        }
        #endregion

        public List<Trainee> getListTraineees()
        {
            return DataSource.trainees;
        }
        public List<Tester> getListTesters()
        {
            return DataSource.testers;
        }
        public List<Test> getListTest()
        {
            return DataSource.tests;
        }


    }
}
