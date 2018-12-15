using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Model
{
    public partial class CopiaPelicula
    {
       
        public Boolean Restringida
        {
             get {
                Boolean Restring=false;
                if (Genero.Contains("(R)")||Genero.Contains("Terror")
                    || Genero.Contains("Adultos")|| Genero.Contains("Guerra")
                    ||Genero.Contains("Muerte"))
                {
                    Restring = true;
                }
                return Restring;
            }

            set { } 
        }

        public double? Decadas
        {
            get {
                double? decada = 0;
               int años = System.DateTime.Today.Year - FechaCreacion.Value.Year;
                decada = años*(0.1);
                return decada = 0;
            }
            set { }
        }
    }
}
