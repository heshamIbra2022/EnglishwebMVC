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
    public class MCQRepositoryTesting
    {
        MCQRepository MCQRepo;
        [SetUp]
        public void Set()
        {
            MCQRepo = new MCQRepository();
        }
        [Test]
        public void TestMCQGetById_ObjectIsNull()
        {

            var result = MCQRepo.GetById(1);
            Assert.IsNull(result);
        }
        [Test]
        public void TestMCQGetByID()
        {
            MCQ mcq = new MCQ();
            mcq = MCQRepo.GetById(1);

            Assert.IsNull(mcq);
        }
        [Test]
        public void TestMCQGetAllbyLevelID()
        {

            var result = MCQRepo.GetAllBylevelId(1);

            Assert.AreEqual(0, result.Count);
        }
        [Test]
        public void TestMCQGetAllbyLevelID2()
        {

            var result = MCQRepo.GetAllBylevelId(1);

            Assert.That(result.Count, Is.EqualTo(0));
        }
        [Test]
        public void TestMCQGetAllbyLevelID3()
        {

            var result = MCQRepo.GetAllBylevelId(1);
            Assert.IsEmpty(result);
        }
        [Test]
        public void TestMCQGetAllbyLevelID3IsNotNull()
        {

            var result = MCQRepo.GetAllBylevelId(1);
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestMCQUpdate()
        {

            var result = MCQRepo.Update(5, new MCQ { Id = 5, Text = "n1,n2", CorrectAnswer = "n1"});

            Assert.AreEqual(0, result);
        }
        [Test]
        public void TestMCQUpdate2()
        {

            var result = MCQRepo.Update(5, new MCQ { Id = 5, Text = "n1,n2", CorrectAnswer = "n1" });
            Assert.AreEqual(typeof(int), result.GetType());
        }
        [Test]
        public void TestMCQUpdate3()
        {

            var result = MCQRepo.Update(5, new MCQ { Id = 5, Text = "n1,n2", CorrectAnswer = "n1" });

            Assert.That(result, Is.LessThan(1));
        }
        [Test]
        public void TestDeleteQuize()
        {

            Assert.That(() => MCQRepo.Delete(5), Throws.TypeOf<NullReferenceException>());
        }
    }
}
