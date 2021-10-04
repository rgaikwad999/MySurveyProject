using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SurveyAppWebApi.Models;
using System.Web.Http.Cors;

namespace SurveyAppWebApi.Controllers
{
    public class SurveyController : ApiController
    {

        // GET: api/SurveyApi
        public string Get()
        {
            return "value";
        }

        [HttpPut]
        //[ResponseType(typeof(void))]
        public IHttpActionResult Put([FromBody]SurveyModel surveyData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (surveyData == null)
            {
                return BadRequest();
            }

            try
            {
              var candidateManagner = CandidateManagner.Create();
                candidateManagner.SurveyFormSubmited(new Candidate {
                    Id = surveyData.CandidateName,
                    IsSurveySubmited = true
                });
            }
            catch (Exception e)
            {

                throw e;

            }

            return StatusCode(HttpStatusCode.OK);
        }
    }
}
