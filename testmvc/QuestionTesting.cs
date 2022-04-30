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
    public class QuestionTesting
    {
      QuestionRepoistory questionrepo;
        [SetUp]
        public void Set()
        {
            questionrepo = new QuestionRepoistory();
        }
        [Test]
        public void Test_data1_ObjectIsNull()
        {
            
           var result = questionrepo.GetById(1);
            Assert.IsNull(result);
        }
        [Test]
        public void Test_data1_InsertObject()
        {
            Question quest = new Question()
            {
                Level_Id = 1,
            };
            var result = questionrepo.Insert(quest);
            Assert.AreEqual(result, 1);
        }
        [Test]
        public void Test_data()
        {
           
            Question quest = questionrepo.GetById(1);

            Assert.AreEqual(quest.Id,1 );
        }
       
    }
}
