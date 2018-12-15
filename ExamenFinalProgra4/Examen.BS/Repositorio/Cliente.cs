using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.BS.Repositorio
{
    internal class Cliente
    {
        private Model.WorkEntities _contexto = new Model.WorkEntities();
        public Model.Cliente Informacion(int id)
        {
            var cliente = _contexto.Cliente.Find(id);
            string nombre = cliente.Nombre;
            int edad = cliente.Edad;
            int? sexo = cliente.Sexo;


            return cliente;
        }
    }
}