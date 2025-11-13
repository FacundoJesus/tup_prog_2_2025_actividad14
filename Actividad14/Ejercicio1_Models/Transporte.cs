using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Models
{
    [Serializable]
    public abstract class Transporte
    {
        public Transporte(string destino, double precio)
        {
            this.Destino = destino;
            this.Precio = precio;
        }

        public double PrecioBase { get; set; }

        public string Destino { get; set; }
        public double Precio { get; }

        public virtual double CalcularPrecioFinal()
        {
            return PrecioBase;
        }
    }
}
