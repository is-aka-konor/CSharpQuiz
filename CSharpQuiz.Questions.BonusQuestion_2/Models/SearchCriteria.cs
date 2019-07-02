using System;
using System.Collections.Generic;

namespace CSharpQuiz.Questions.BonusQuestion_2.Models
{
    public partial class SearchCriteria
    {
        public int CriteriaId { get; set; }
        public string Criteria { get; set; }
        public DateTime Datestamp { get; set; }
        public int SearchCount { get; set; }
        public int ResultCount { get; set; }
    }
}
