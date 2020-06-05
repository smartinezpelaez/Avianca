﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avianca.Models
{
    public class ControlDespegue
    {
        public int Id { get; set; }
        public int IdDespegue { get; set; }
        public string Pista { get; set; }
        public string Estado { get; set; }
        public string Clima { get; set; }
        public string Aeropuerto { get; set; }
        public DateTime? FechayHora { get; set; }

    }
}
