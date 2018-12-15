using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Model
{
   public partial class Cliente
    {
        public int Edad
        {
            get{
                int fechaNacimiento=0;

                fechaNacimiento = Convert.ToInt16(DateTime.Now.Year) - Convert.ToInt16(FechaNacimiento.Value.Year);
                return fechaNacimiento;
            }

            set { }

        }

        public int Afiliaciones
        {
            get{
                int tiempoAfiliacion;

                tiempoAfiliacion = Convert.ToInt16(DateTime.Now.Year) - Convert.ToInt16(FechaAfiliacion.Value.Year);
                return tiempoAfiliacion;
            }

            set { }
        }

        public int AnioAfiliacion
        {
            get
            {
                int tiempoAfiliacion;

                tiempoAfiliacion = Convert.ToInt16(FechaAfiliacion.Value.Year) - Convert.ToInt16(FechaNacimiento.Value.Year);
                return tiempoAfiliacion;
            }

            set { }
        }

        public bool MayorEdad
        {
            get
            {
                bool mayor;

                int edad = 0;

                edad = Convert.ToInt16(DateTime.Now.Year) - Convert.ToInt16(FechaNacimiento.Value.Year);

                if(edad > 18)
                {
                    mayor = true;
                    return mayor;
                }
                else
                {
                    mayor = false;
                    return mayor; 
                }

            }

            set { }
        }

        public string Sexos
        {
            get
            {
                string criterio;

                if( Sexo == 1)
                {
                    criterio = "Hombre";
                    return criterio; 
                }else if(Sexo == 2)
                {
                    criterio = "Mujer";
                    return criterio;
                }
                else
                {
                    criterio = "No indica o desconocido";
                    return criterio; 

                }               
               
                

            }

            set { }
        }


    }


    }

