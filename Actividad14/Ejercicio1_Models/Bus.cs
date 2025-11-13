using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Models
{
    [Serializable]
    public class Bus:Transporte
    {
        public string Patente {  get; set; }
        public string Clase { get; set; }

        public Bus(string destino, double precio, string patente, string clase) : base(destino, precio)
        {
            this.Patente = patente;
            this.Clase = clase;
        }

        public override double CalcularPrecioFinal()
        {
            double impuesto = base.CalcularPrecioFinal();
            double precio = base.CalcularPrecioFinal() + impuesto;
            double iva = precio * 21.0 / 100;

            return precio + iva;
        }
    }
}
