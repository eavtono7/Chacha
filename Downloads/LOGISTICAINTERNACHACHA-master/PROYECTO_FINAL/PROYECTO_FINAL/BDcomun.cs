﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROYECTO_FINAL
{
    class BDcomun
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=proyectochachas; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}
