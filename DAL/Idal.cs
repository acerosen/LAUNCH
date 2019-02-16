using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace DAL
{

    public interface Idal
    {

         bool findTrainee(int numbertrainee);
         void addTrainee(Trainee b);   //הוספת סניף
         void deleteTrainee(int numberBr);   //מחיקת סניף
         void updateTrainee(Trainee b);  //עדכון סניף קיים
         Trainee getTrainee(int numB);
         IEnumerable<Trainee> getAllTrainee(Func<Trainee, bool> predicat = null);
        bool findTester(int numbertrainee);
        void addTester(Tester b);
        void deleteTester(int numberBr);
        void updateTester(Tester b);
        Tester getTester(int numB);
        IEnumerable<Tester> getAllTester(Func<Tester, bool> predicat = null);
        void addTest(Test B);
        void deleteTest(int num);
        void updateTest(Test B);
        bool findTest(Test b);
        Test getTest(int numB);
        IEnumerable<Test> getAllTest(Func<Test, bool> predicat = null);
    }

}
