using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Tvmlesson8CF.Models
{
    public class Tvmbookstore : DbContext
    {
        public Tvmbookstore():base("TvmbookstoreConnectionString")
        {

         }
        public DbSet<TvmCategory> TvmCategory { get; set; }
        public DbSet<Tvmbook> TvmBooks { get; set; }
        public Tvmbookstore() : base("name=TvmbookstoreConnectionString")
        {
        }
    }
}