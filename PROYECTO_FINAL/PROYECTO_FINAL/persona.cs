﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class persona
    {
        public string CodigoPersona { get; set; }
        public string NombrePersona { get; set; }
        public string ApellidoPersona { get; set; }
        public string TelefonoPersona { get; set; }
        public string CargoPersona { get; set; }

        public persona()
        {

        }
        public persona (string CodigoPersona, string NombrePersona, string ApellidoPersona, string TelefonoPersona, string CargoPersona)
        {
            this.CodigoPersona = CodigoPersona;
            this.NombrePersona = NombrePersona;
            this.ApellidoPersona = ApellidoPersona;
            this.TelefonoPersona = TelefonoPersona;
            this.CargoPersona = CargoPersona;
        }
    }
}
