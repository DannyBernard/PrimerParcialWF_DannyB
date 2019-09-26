using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
   public class EstudianteDetalle
    {
        public int ID { get; set; }
        public int EstudianteID { get; set; }

        public EstudianteDetalle(int iD, int estudianteID)
        {
            ID = iD;
            EstudianteID = estudianteID;
        }

        public EstudianteDetalle()
        {
            ID = 0;
            EstudianteID = 0;
        }

    }
}
