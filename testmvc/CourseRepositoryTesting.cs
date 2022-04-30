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
    public class CourseRepositoryTesting
    {
        CourseRepository CourseRepo;
        [SetUp]
        public void Set()
        {
            CourseRepo = new CourseRepository();
        }
        [Test]
        public void TestCourseGetById_ObjectIsNull()
        {

            var result = CourseRepo.GetById(1);
            Assert.IsNull(result);
        }
        [Test]
        public void TestCourseGetByID()
        {
            Course crs = new Course();
            crs = CourseRepo.GetById(1);

            Assert.IsNull(crs);
        }
        [Test]
        public void TestCourseUpdate()
        {

            var result = CourseRepo.Update(5, new Course { Id = 5, Name = "Grammer", Date = DateTime.Now,Level_Id=1,Image="1.png",User_Id= "A1"});

            Assert.AreEqual(0, result);
        }
        [Test]
        public void TestCourseUpdate2()
        {

            var result = CourseRepo.Update(5, new Course { Id = 5, Name = "Vocabulary", Date = DateTime.Now, Level_Id = 1, Image = "1.png", User_Id = "A1" });
            Assert.AreEqual(typeof(int), result.GetType());
        }
        [Test]
        public void TestCourseUpdate3()
        {

            var result = CourseRepo.Update(5, new Course { Id = 5, Name = "Phontics", Date = DateTime.Now, Level_Id = 1, Image = "1.png", User_Id = "A1" });

            Assert.That(result, Is.LessThan(1));
        }
        [Test]
        public void TestDeleteCourse()
        {

            Assert.That(() => CourseRepo.Delete(5), Throws.TypeOf<NullReferenceException>());
        }

       // [Test]
        public void Test_data2_insertCourse()
        {
            Course crs = new Course()
            {
                Name = "Grammer",
                Date = DateTime.Now,
                Level_Id = 1,
                Image = "1.png",
                User_Id = "A1"
               
            };

            CourseRepository course = new CourseRepository();
            int inserted = course.Insert(crs);
            Assert.IsNull(inserted);
        }
    }
}
