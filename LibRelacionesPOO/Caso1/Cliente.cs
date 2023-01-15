using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso1
{
    public class Cliente : Usuario
    {
        public string Apellido { get; set; }
    

        public Cliente(string nombre, string password, string apellido) : base(nombre, password)
        { 
            Apellido= apellido;
        
        }


    }
}
