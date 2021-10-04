using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyAppWebApi.Models
{
    public class CandidateManagner
    {
        private List<Candidate> Candidates { get; set; }
        private static CandidateManagner candidateManagner = new CandidateManagner();

        private CandidateManagner()
        {
            Candidates = new List<Candidate>();
        }

        public static CandidateManagner Create()
        {
            return candidateManagner;
        }

        public void SurveyFormSubmited(Candidate candidate)
        {
            if (Candidates.Any(r => r.Id.Equals(candidate.Id)) || candidate.Id == String.Empty)
            {
                //submited form already
                throw new Exception("Already submitted");
            }

            Candidates.Add(candidate);
        }
    }

    public class Candidate
    {
        public string Id { get; set; }
        public bool IsSurveySubmited { get; set; }
    }
}