using StudentServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score8_Should_ReturnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score7_Should_ReturnB()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score5_Should_ReturnC()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void Score3Half_Should_ReturnD()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 3.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void addFirst_ShouldSuccess_AndReturnTrue()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 1, Name = "Toan", Age = 20, Score = 9 };

            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddStudentnotnull()
        {
            StudentService sv = new StudentService();
            Student s = new Student() {};

            sv.addStudent(s);
        }

        [TestMethod]
        public void AddStudentnoteuqalidbefore()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 1, Name = "Toan", Age = 20, Score = 9 };
            sv.addStudent(s);
            Student a = new Student() { Id = 1, Name = "Toan", Age = 20, Score = 9 };
            bool status = sv.addStudent(a);
            Assert.IsFalse(status);

        }
    }
}