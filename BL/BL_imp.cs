using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class BL_imp : IBL
    {
        Idal dal = FactoryDalXml.getdal();
        #region trainee
        public void addTrainee(Trainee b)
        {
            dal.addTrainee(b);
        }
        public void deleteTrainee(int numberBr)
        {
            dal.deleteTrainee(numberBr);
        }
        public void updateTrainee(Trainee b)
        {
            dal.updateTrainee(b);
        }

        public Trainee getTrainee(int numB)
        {
            return dal.getTrainee(numB);
        }
        public IEnumerable<Trainee> getAllTrainee(Func<Trainee, bool> predicate = null)
        {
            return dal.getAllTrainee(predicate);
        }
        #endregion
        #region tester
        public void addTester(Tester b)
        {
            if (b.Finish < b.Start || b.Finish>24 || b.Start<0)
                throw new Exception("Wrong times");
            dal.addTester(b);


        }
        public void deleteTester(int numberBr)
        {
            dal.deleteTester(numberBr);
        }
        public void updateTester(Tester b)
        {
            dal.updateTester(b);
        }

        public Tester getTester(int numB)
        {
            return dal.getTester(numB);
        }
        public IEnumerable<Tester> getAllTester(Func<Tester, bool> predicate = null)
        {
            return dal.getAllTester(predicate);
        }
        #endregion
        #region test
        public void addTest(Test b)
        {
            dal.addTest(b);
        }
        public void deleteTest(int numberBr)
        {
            dal.deleteTest(numberBr);
        }
        public void updateTest(Test b)
        {
            dal.updateTest(b);
        }

        public Test getTest(int numB)
        {
            return dal.getTest(numB);
        }
        public IEnumerable<Test> getAllTest(Func<Test, bool> predicate = null)
        {
            return dal.getAllTest(predicate);
        }
        #endregion
    }



}