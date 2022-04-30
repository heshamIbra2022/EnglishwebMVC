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
    internal class VideoRepositoryTesting
    {
        VideoRepository VideoRepo;
        [SetUp]
        public void Set()
        {
            VideoRepo = new VideoRepository();
        }
        [Test]
        public void TestVideoGetById_ObjectIsNull()
        {

            var result = VideoRepo.GetById(2);
            Assert.IsNull(result);
        }

        [Test]
        public void TestVideoGetByID()
        {
            Video video = new Video();
            video = VideoRepo.GetById(1);

            Assert.IsNull(video);
        }
        [Test]
        public void TestVideoUpdate()
        {

            var result = VideoRepo.update(5, new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes ="hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Sohalia" });

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestVidoeUpdate2()
        {

            var result = VideoRepo.update(5, new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Sohalia" });
            Assert.AreEqual(typeof(int), result.GetType());
        }
        [Test]
        public void TestVidoeUpdate3()
        {

            var result = VideoRepo.update(5, new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Sohalia" });
            Assert.That(result, Is.LessThan(1));
        }

        [Test]
        public void TestDeleteVideo()
        {

            Assert.That(() => VideoRepo.delete(5), Throws.TypeOf<NullReferenceException>());
        }
        [Test]
        public void TestName()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Sohalia" };
            var result = viedo.Name.Length;
            Assert.AreEqual(typeof(int), result.GetType());

        }

        [Test]
        public void TestNameLength3()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Sohalia" };
            var result = viedo.Name;
            Assert.AreEqual(typeof(string), result.GetType());
        }

        [Test]
        public void TestNameLength4()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Sohalia" };
            var result = viedo.Name.Length;
            Assert.That(result, Is.GreaterThan(3));

        }
        [Test]
        public void TestDescriptionLength()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Sohalia" };
            var result = viedo.Description.Length;
            Assert.That(result, Is.LessThan(90));

        }

        [Test]
        public void TestDescriptionLength2()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Mona" };
            var result = viedo.Description.Length;
            Assert.AreEqual(typeof(int), result.GetType());

        }

        [Test]
        public void TestDescriptionLength3()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Mona" };
            var result = viedo.Description;
            Assert.AreEqual(typeof(string), result.GetType());

        }

        [Test]
        public void TestDescriptionLength4()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Mona" };
            var result = viedo.Description.Length;
            Assert.That(result, Is.GreaterThan(7));

        }

        [Test]
        public void TestIDType()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Mona" };
            var result = viedo.ID;
            Assert.AreEqual(typeof(int), result.GetType());

        }
        [Test]
        public void TestUrlType()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Mona" };
            var result = viedo.VideoUrl;
            Assert.AreEqual(typeof(string), result.GetType());

        }

        [Test]
        public void TestUserIDType()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Mona" };
            var result = viedo.User_Id;
            Assert.AreEqual(typeof(int), result.GetType());

        }
        [Test]
        public void TestCourseIDType()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Mona" };
            var result = viedo.Course_ID;
            Assert.AreEqual(typeof(int), result.GetType());

        }
        [Test]
        public void TestPathType()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Mona" };
            var result = viedo.pathViedoes;
            Assert.AreEqual(typeof(string), result.GetType());

        }
        [Test]
        public void TestusernameType()
        {
            Video viedo = new Video { ID = 5, Name = "EnglishWorld", Description = "HelloWorld", pathViedoes = "hello.mp4", Course_ID = 1, VideoUrl = "http/mhg", username = "Mona" };
            var result = viedo.username;
            Assert.AreEqual(typeof(string), result.GetType());

        }
    }
}
