using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreNote.ClientCore.Database
{
    internal class SQLLite3Context : DbContext
    {

        private string dbfilePath;
        public SQLLite3Context(string path)
        {
            this.dbfilePath = path;
        }
        public DbSet<TagEntity> TagTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlite($"Data Source={this.dbfilePath}");
        }

    }
}
