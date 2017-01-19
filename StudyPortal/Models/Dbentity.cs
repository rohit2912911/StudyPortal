using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudyPortal.Models
{
    public class Dbentity :DbContext

    {
        public DbSet<Mvc> Mvc { get; set; }
        public DbSet<C> DbC { get; set; }
        public DbSet<CCategory> DbCCategory { get; set; }

    }
}