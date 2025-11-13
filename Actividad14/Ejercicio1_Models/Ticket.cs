using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Models
{
    [Serializable]
    public class Ticket:IComparable<Ticket>
    {

        public DateTime Fecha { get; set; }
        public double PrecioFinal { get; set; }
        public string Destino { get; set; }

        public string Transporte { get; set; }

        private string cuit;
        private string nombre;
        private string telefono;
        private string nTarjeta;

        public Ticket(string cuit, string nombre, string telefono, string nTarjeta)
        {

            if(ValidarCUIT(cuit) == false)
            {
                throw new Exception("CUIT NO VALIDO");
            }
            if (ValidarTarjeta(nTarjeta) == false)
            {
                throw new Exception("N° TARJETA NO VALIDA");
            }

            this.cuit = cuit;
            this.nombre = nombre;
            this.telefono = telefono;
            this.nTarjeta = nTarjeta;
        }

        protected bool ValidarCUIT(string cuit)
        {
            return cuit.Length == 11;
        }

        protected bool ValidarTarjeta(string tarjeta)
        {
            return cuit.Length == 16;
        }

        public int CompareTo(Ticket other)
        {
            if(other != null)
            {
                return this.Destino.CompareTo(other.Destino);
            }
            return -1;
        }

        public override string ToString()
        {
            return $"{this.nombre} ({this.cuit}) {this.Destino} - ${this.PrecioFinal:f2}";
        }
    }
}
