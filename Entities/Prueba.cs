using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Prueba
    {
        [Key]
        public int PruebaID { get; set; }
        public String NobrePrueba { get; set; }

        public Prueba()
        {
            PruebaID = 0;
            NobrePrueba = string.Empty;
        }

        public Prueba(int pruebaID, string nobrePrueba)
        {
            PruebaID = pruebaID;
            NobrePrueba = nobrePrueba;
        }
    }
}
