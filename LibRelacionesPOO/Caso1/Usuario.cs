﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso1
{
    public class Usuario
    {

        public string Nombre { get; set; }
        public string Password { get; set; }


        public Usuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }
    }
}
