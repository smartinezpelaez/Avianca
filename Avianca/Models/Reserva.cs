﻿using System;
using System.Collections.Generic;

namespace Avianca.Models
{
    public class Reserva
    {
        public int ID { get; set; }
        public int IDReserva { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime? FechayHoraSalida { get; set; }       
        public int Silla { get; set; }
        public string Clase { get; set; }
        public int Precio { get; set; }
        public string NombreCliente { get; set; }
        public string NumeroDocumento { get; set; }
        public string Aerolinea { get; set; }
        public string Status { get; set; }
    }
}
