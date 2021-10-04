using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyAppWebApi.Models
{
    public class SurveyModel
    {
        public string CandidateName { get; set; }

        public SurveyDetail[] SurveyData { get; set; }

        public SubQuestionDetail[] SurveySubQuestionData { get; set; }

        public SubOption[] SurveysubOptionsList { get; set; }
    }

    public class SurveyDetail
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class SubQuestionDetail
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string[] SelectedAnswers { get; set; }
    }

    public class SubOption
    {
        public string Suboption { get; set; }
        public string Value { get; set; }
        public string Category { get; set; }

    }
}
