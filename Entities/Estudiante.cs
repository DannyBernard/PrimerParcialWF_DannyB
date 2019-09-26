using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Estudiante
    {
        [Key]
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Valor { get; set; }
        public Decimal Logrado { get; set; }
        public Decimal Total { get; set; }
        public DateTime Fecha { get; set; }

        public List<EstudianteDetalle> Detalle { get; set; }


        public Estudiante(int estudianteID, string nombre, string categoria, int valor, decimal logrado, decimal total, DateTime fecha)
        {
            EstudianteID = estudianteID;
            Nombre = nombre;
            Categoria = categoria;
            Valor = valor;
            Logrado = logrado;
            Total = total;
            Fecha = fecha;
        }


        public Estudiante()
        {
            EstudianteID = 0;
            Nombre = string.Empty;
            Categoria = string.Empty; ;
            Valor = 0;
            Logrado = 0;
            Total = 0;
            Fecha = DateTime.Now;
        }

        public void AgregarDetalle(int iD, int estudianteID)
        {
            this.Detalle.Add(new EstudianteDetalle(iD, estudianteID));
        }

    }
}
