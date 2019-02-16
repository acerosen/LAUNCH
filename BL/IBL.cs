using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {

        #region trainee
        void addTrainee(Trainee b);   //הוספת סניף
        void deleteTrainee(int numberBr);   //מחיקת סניף
        void updateTrainee(Trainee b);  //עדכון סניף קיים
        Trainee getTrainee(int numB);
        IEnumerable<Trainee> getAllTrainee(Func<Trainee, bool> predicate = null);
        #endregion
        #region tester
        void addTester(Tester b);   
        void deleteTester(int numberBr);   
        void updateTester(Tester b);  
        Tester getTester(int numB);
        IEnumerable<Tester> getAllTester(Func<Tester, bool> predicate = null);
        #endregion
        #region test
        void addTest(Test b);   
        void deleteTest(int numberBr);   
        void updateTest(Test b);  
        Test getTest(int T);
        IEnumerable<Test> getAllTest(Func<Test, bool> predicate = null);
        #endregion
    }
}
