﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Renta
    {
        [Key]
        public int RentaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int MiembroId { get; set; }
        public DateTime FechaDevuelta { get; set; }
        public decimal Devuelta { get; set; }    //Esta devuelta se refiere a devuelta de dinero
        public decimal Pago { get; set; }//pago se refiere a lo que pago el cliente
        public decimal Importe { get; set; }

        /*[ForeignKey("MiembroId")]*/
        public virtual List<RentaDetalle> Detalles { get; set; }
        public Renta()
        {
            this.RentaId = 0;
            this.FechaRegistro = DateTime.Now;
            this.MiembroId = 0;
            this.FechaDevuelta = DateTime.Now;
            this.Devuelta = 0;
            this.Pago = 0;
            this.Importe = 0;
            this.Detalles = new List<RentaDetalle>();
        }

        public void AgregarDetalle(int detalleId, int rentaId, int videoJuegoId, string titulo)
        {
            Detalles.Add(new RentaDetalle(detalleId, rentaId, videoJuegoId, titulo));
        }
    }
}