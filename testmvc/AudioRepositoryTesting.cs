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
    public class AudioRepositoryTesting
    {
        AudioRepository AudioRepo;
        [SetUp]
        public void Set()
        {
            AudioRepo = new AudioRepository();
        }
        [Test]
        public void TestAudioGetById_ObjectIsNull()
        {

            var result = AudioRepo.GetById(1);
            Assert.IsNull(result);
        }

        [Test]
        public void TestAudioGetByID()
        {
            Audio ad = new Audio();
            ad = AudioRepo.GetById(1);

            Assert.IsNull(ad);
        }

        [Test]
        public void TestCAudioUpdate()
        {

            var result = AudioRepo.update(5, new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 });

            Assert.AreEqual(0, result);
        }
        [Test]
        public void TestAudioUpdate2()
        {

            var result = AudioRepo.update(5, new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 });
            Assert.AreEqual(typeof(int), result.GetType());
        }
        [Test]
        public void TestAudioUpdate3()
        {

            var result = AudioRepo.update(5, new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 });

            Assert.That(result, Is.LessThan(1));
        }

        [Test]
        public void TestDeleteAudio()
        {

            Assert.That(() => AudioRepo.delete(5), Throws.TypeOf<NullReferenceException>());
        }
        [Test]
        public void TestDeleteAudioException()
        {

            Assert.That(() => AudioRepo.GetByLevelId(5), Throws.TypeOf<NotImplementedException>());
        }
        [Test]
        public void TestNameLength()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.Name.Length;
            Assert.That(result, Is.LessThan(30));
        }
        [Test]
        public void TestNameLength2()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.Name.Length;
            Assert.AreEqual(typeof(int), result.GetType());
        }
        [Test]
        public void TestNameLength3()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.Name;
            Assert.AreEqual(typeof(string), result.GetType());
        }

        [Test]
        public void TestNameLength4()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.Name.Length;
            Assert.That(result, Is.GreaterThan(3));

        }
        [Test]
        public void TestDescriptionLength()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.Description.Length;
            Assert.That(result, Is.LessThan(90));

        }

        [Test]
        public void TestDescriptionLength2()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.Description.Length;
            Assert.AreEqual(typeof(int), result.GetType());

        }

        [Test]
        public void TestDescriptionLength3()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.Description;
            Assert.AreEqual(typeof(string), result.GetType());

        }

        [Test]
        public void TestDescriptionLength4()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.Description.Length;
            Assert.That(result, Is.GreaterThan(7));

        }

        [Test]
        public void TestIDType()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.ID;
            Assert.AreEqual(typeof(int), result.GetType());

        }
        [Test]
        public void TestUrlType()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.AudioUrl;
            Assert.AreEqual(typeof(string), result.GetType());

        }
        [Test]
        public void TestUserIDType()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.User_Id;
            Assert.AreEqual(typeof(int), result.GetType());

        }
        [Test]
        public void TestlevelIDType()
        {
            Audio audio = new Audio { ID = 5, Name = "Grammer", Description = "english audio", AudioUrl = "http/", Level_ID = 1, User_Id = 65 };
            var result = audio.Level_ID;
            Assert.AreEqual(typeof(int), result.GetType());

        }
    }
}
