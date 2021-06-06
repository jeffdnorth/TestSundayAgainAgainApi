using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestSundayAgainAgainApi.Models;

namespace TestSundayAgainAgainApi.Data
{
    public class TestSundayAgainAgainApiContext : DbContext
    {
        public TestSundayAgainAgainApiContext (DbContextOptions<TestSundayAgainAgainApiContext> options)
            : base(options)
        {
        }

        public DbSet<TestSundayAgainAgainApi.Models.Developer> Developer { get; set; }

        public DbSet<TestSundayAgainAgainApi.Models.Assignment> Assignment { get; set; }

        public DbSet<TestSundayAgainAgainApi.Models.Project> Project { get; set; }
    }
}
