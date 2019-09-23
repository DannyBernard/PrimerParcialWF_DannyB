using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : Context
    {
        //public DbSet<> MyProperty { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
