using NUnit.Framework;
using ProjectItiTeam.Models;
using ProjectItiTeam.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testmvc
{
    [TestFixture]
    public class QuizRepositoryTesting
    {
        QuizRepository QuizRepo;
        [SetUp]
        public void Set()
        {
            QuizRepo = new QuizRepository();
        }
        [Test]
        public void TestQuizGetById_ObjectIsNull()
        {

            var result = QuizRepo.GetById(1);
            Assert.IsNull(result);
        }

        #region TestsNeedsToCheckAgain
        // [Test]
        //public void TestQuizGetById_Insert()
        //{
        //    Quiz quiz = new Quiz()
        //    {
        //        Level_Id = 1,
        //        Date = DateTime.Now,
        //        Degree = 20,
        //        Mcq_Num = 1,
        //        Tf_Num = 1

        //     };
        //    var result = QuizRepo.Insert(quiz);

        //    Assert.AreEqual(typeof(int), result.GetType());

        //}

        // [Test]
        //public void TestQuizGetById_Insert2()
        //{
        //    Quiz quiz = new Quiz()
        //    {
        //        Level_Id = 1,
        //        Date = DateTime.Now,
        //        Degree = 20,
        //        Mcq_Num = 1,
        //        Tf_Num = 1

        //    };
        //    var result = QuizRepo.Insert(quiz);
        //    Assert.AreEqual(1, result);

        //}

        //[Test]
        //public void HTestQuizGetById_Insert3()
        //{
        //    Quiz quiz = new Quiz()
        //    {
        //        Level_Id = 1,
        //        Date = DateTime.Now,
        //        Degree = 20


        //    };
        //    var result = QuizRepo.Insert(quiz);
        //    Assert.AreEqual(0, result);

        //} 
        #endregion

        [Test]
        public void TestQuizGetByID()
        {
            Quiz quiz = new Quiz();
            quiz = QuizRepo.GetById(1);

            Assert.IsNull( quiz);
        }

        [Test]
        public void TestQuizGetAllbyLevelID()
        {

            var result = QuizRepo.GetAllByLevelId(1);

            Assert.AreEqual(0,result.Count);
        }

        [Test]
        public void TestQuizGetAllbyLevelID2()
        {

            var result = QuizRepo.GetAllByLevelId(1);

            Assert.That(result.Count, Is.EqualTo(0));
        }
        [Test]
        public void TestQuizGetAllbyLevelID3()
        {

            var result = QuizRepo.GetAllByLevelId(1);
            Assert.IsEmpty(result);
        }
        [Test]
        public void TestQuizGetAllbyLevelID3IsNotNull()
        {

            var result = QuizRepo.GetAllByLevelId(1);
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestQuizeUpdate()
        {

            var result = QuizRepo.Update(5, new Quiz { Id = 5,Degree = 100 ,Tf_Num=2,Mcq_Num=3,Level_Id=1});

            Assert.AreEqual( 0,result);
        }

        [Test]
        public void TestQuizeUpdate2()
        {

            var result = QuizRepo.Update(5, new Quiz { Id = 5, Degree = 100, Tf_Num = 2, Mcq_Num = 3, Level_Id = 1 });

            Assert.AreEqual(typeof(int), result.GetType());
        }

        [Test]
        public void TestQuizeUpdate3()
        {

            var result = QuizRepo.Update(5, new Quiz { Id = 5, Degree = 100, Tf_Num = 2, Mcq_Num = 3, Level_Id = 1 });

            Assert.That(result, Is.LessThan(1));
        }
        [Test]
        public void TestDeleteQuize ()
        {
          
            Assert.That(() => QuizRepo.Delete(5), Throws.TypeOf<NullReferenceException>());
        }
    }
}
