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
    public class RateRepositoryTesting
    {
        RateRepository RateRepo;
        [SetUp]
        public void Set()
        {
            RateRepo = new RateRepository();
        }
        [Test]
        public void TestRateGetById_ObjectIsNull()
        {

            var result = RateRepo.GetById(1);
            Assert.IsNull(result);
        }

        [Test]
        public void TestRateGetByID()
        {
            Rate rate = new Rate();
            rate = RateRepo.GetById(1);

            Assert.IsNull(rate);
        }

        [Test]
        public void TestCRateUpdate()
        {

            var result = RateRepo.update(5, new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65,UserName="Sohalia" });

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestRateUpdate2()
        {

            var result = RateRepo.update(5, new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "Petit shaza" });
            Assert.AreEqual(typeof(int), result.GetType());
        }
        [Test]
        public void TestRateUpdate3()
        {

            var result = RateRepo.update(5, new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" });

            Assert.That(result, Is.LessThan(1));
        }
        [Test]
        public void TestDeleteRate()
        {

            Assert.That(() => RateRepo.delete(5), Throws.TypeOf<NullReferenceException>());
        }
        [Test]
        public void TestStar()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Stars;
            Assert.AreEqual(typeof(int), result.GetType());

        }
        [Test]
        public void TestStar2()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Stars;
            Assert.That(result, Is.LessThan(5));
        }
        [Test]
        public void TestStar3()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Stars;
            Assert.That(result, Is.GreaterThan(1));
        }
        [Test]
        public void TestStar4()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Stars;
            Assert.That(result, Is.Not.GreaterThan(7));
        }

        [Test]
        public void TestStar5()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Stars;
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void TestStar6()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Stars;
            Assert.That(result, Is.Not.EqualTo(0));
        }
        [Test]
        public void Testdislike()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.dislike;
            Assert.That(result, Is.Not.EqualTo(0));
        }
        [Test]
        public void Testdislike2()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.dislike;
            Assert.That(result, Is.LessThan(15));
        }

        [Test]
        public void TestdisDate()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Date.Year;
            Assert.AreEqual(DateTime.Now.Year, result);
        }
        [Test]
        public void TestdisDate3()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Date.Year;
            Assert.AreEqual(2022, result);
        }
        [Test]
        public void TestdisDate2()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Date;
            Assert.AreEqual(typeof(DateTime), result.GetType()); ;
        }
        [Test]
        public void TestdisDate4()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Date.Year;
            Assert.AreEqual(typeof(int), result.GetType()); ;
        }
        [Test]
        public void TestdisDate5()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Date.Year;
            Assert.That(2052, Is.Not.EqualTo(result));
        }

        [Test]
        public void TestdisDate6()
        {
            Rate rate = new Rate { ID = 5, dislike = 10, Date = DateTime.Now, Stars = 2, Course_ID = 1, User_ID = 65, UserName = "DoDo" };
            var result = rate.Date.Year;
            Assert.That(2020, Is.Not.GreaterThan(result));
        }
    }
}
