using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace DAL
{
    public class Contexto : DbContext { 
      //  public DbSet<> MyProperty { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
