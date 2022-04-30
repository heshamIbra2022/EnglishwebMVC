using Microsoft.Data.SqlClient;
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
        public void Test_data1_ObjectIsNotNull()
        {
            LevelRepository level = new LevelRepository();
            Level lev = level.GetById(1);
            Assert.IsNotNull(lev);
        }

        [Test]
        public void Test_data2_insertLevelInDataBase()
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
        public void Testlevel_data2_GetNameOfNewInsertedLevel()
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
        [Test]
        public void Testlevel_data_getAllLevels()
        {



            LevelRepository level = new LevelRepository();
            var result = level.GetAll();
            
            Assert.Greater(result.Count, 0);
        }
       
        [Test]
        public void Testlevel_data_updatenonExistingLevel()
        {



            LevelRepository level = new LevelRepository();
            var result = level.Update(5,new Level { Id=5, Name="level5"});

            Assert.AreEqual(result, 0);
        }
        [Test]
        public void Testlevel_data_updateExistingLevel()
        {



            LevelRepository level = new LevelRepository();
            var result = level.Update(2, new Level { Id = 2, Name = "newLevel2" });

            Assert.AreEqual(result, 1);
        }
        [Test]
        public void Testlevel_data_GetupdateDExistingLevel_Name()
        {



            LevelRepository level = new LevelRepository();
            var result = level.GetById(2);

            Assert.AreEqual("newLevel2", result.Name);
        }
        [Test]
        public void Testlevel_data_deleteExistingLevel()
        {



            LevelRepository level = new LevelRepository();
            var result = level.Delete(2);

            Assert.AreEqual(result, 1);
        }
        [Test]
        public void Testlevel_data_deleteNonExistingLevel()
        {



            LevelRepository level = new LevelRepository();
            var result = level.Delete(2);

            Assert.AreEqual(result, 0);
        }
       
    }
}
