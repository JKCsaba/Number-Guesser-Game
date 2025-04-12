using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._04._12randomguesser
{
    using Microsoft.EntityFrameworkCore;

    public class HighScoreContext : DbContext
    {
        public DbSet<HighScore> HighScores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HighScoreDB;Integrated Security=True;");
        }
    }

}
