using NUnit.Framework;
using ProjectItiTeam.Models;
using ProjectItiTeam.Repository;
using System;

namespace testmvc
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test ()
        {
            LevelRepository level = new LevelRepository();
           Level lev= level.GetById(1);
            Assert.AreEqual(lev.Id, 1);
        }
         [Test]
        public void Test_data ()
        {
            LevelRepository level = new LevelRepository();
           Level lev= level.GetById(1);
            Assert.AreEqual(lev.Name,"level1");
        }

        [Test]
        public void Test_data1()
        {
            LevelRepository level = new LevelRepository();
            Level lev = level.GetById(1);
            Assert.IsNotNull(lev);
        }

        [Test]
        public void Test_data2()
        {
            Level level1 = new Level()
            {
                Name = "level2",
            };


            LevelRepository level = new LevelRepository();
            int inserted = level.Insert(level1);
            Assert.IsNotNull(inserted);
        }
        [Test]
        public void Testlevel_data2()
        {
            


            LevelRepository level = new LevelRepository();
          var result = level.GetById(2);
            Assert.AreEqual("level2", result.Name);
        }
        [Test]
        public void Testlevel_data3()
        {



            LevelRepository level = new LevelRepository();
            var result = level.GetById(2);
            Assert.AreNotEqual("level1", result.Name);
        }

    }
}
