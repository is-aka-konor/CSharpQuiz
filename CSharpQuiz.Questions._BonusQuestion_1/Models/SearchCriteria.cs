using System;
using System.Collections.Generic;

namespace CSharpQuiz.Questions._BonusQuestion_1.Models
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
