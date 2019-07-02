using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CSharpQuiz.Questions.BonusQuestion_2.Models
{
    public partial class BloggingContext : DbContext
    {

        public BloggingContext()
            : base("Server=TMDEVVM\\ALPHA;database=Blogging;uid=sa;pwd=d8;")
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Post> Post { get; set; }
      //  public virtual DbSet<SearchCriteria> SearchCriteria { get; set; }

        // Unable to generate entity type for table 'dbo.search_results'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.search_criteria_archive'. Please see the warning messages.



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
