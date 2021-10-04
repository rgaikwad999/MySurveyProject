using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurveyAppWebApi.Controllers;
using SurveyAppWebApi.Models;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace SurveyWebApi
{
    [TestClass]
    public class SurveyUnitTest
    {
        [TestMethod]
        public void Candidate_Manager_shouildbe_singalton()
        {
            //act
            var candidateManager1 = CandidateManagner.Create();
            var candidateManager2 = CandidateManagner.Create();

            //assert
            Assert.IsTrue(candidateManager1.Equals(candidateManager2));
        }

        [TestMethod]
        public void Candidate_should_Submit_Survey_OnlyOnce()
        {
            var candidateManager = CandidateManagner.Create();
            candidateManager.SurveyFormSubmited(new Candidate { Id = "abc" });

            Assert.ThrowsException<Exception>(() => candidateManager.SurveyFormSubmited(new Candidate { Id = "abc" }));
        }
    }
}
