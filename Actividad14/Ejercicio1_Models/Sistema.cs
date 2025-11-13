using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Models
{
    [Serializable]
    public class Sistema
    {
        private List<Ticket> listaTickets = new List<Ticket>();

        private List<Transporte> listaTransportes = new List<Transporte>();

        public void AgregarTransporte(Transporte transporte)
        {
            listaTransportes.Add(transporte);
        }

        public void CrearTicket(string cuit, string nombre, string telefono, string narjeta)
        {
            
            listaTickets.Add(new Ticket(cuit,nombre,telefono,narjeta));
        }

        public void ImportarTransporte(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] splitResult = linea.Split(';');

                string destino = splitResult[0].Trim();
                double precio = Convert.ToDouble(splitResult[1].Trim());

                Transporte transporte = null;

                if (splitResult.Length == 3)
                {
                    string identificador = splitResult[2].Trim();
                    transporte = new Avion(destino, precio, identificador);
                }
                else
                if(splitResult.Length == 4)
                {
                    string patente = splitResult[3].Trim();
                    string clase = splitResult[4].Trim();

                    transporte = new Bus(destino,precio,patente,clase);

                }
                else
                {
                    throw new Exception("Error");
                }

                AgregarTransporte(transporte);
                 
            }
        }

        public string[] VerTicket()
        {
            string[] lista = new string [listaTickets.Count];

            listaTickets.Sort();
            int i = 0;
            foreach (Ticket t in listaTickets)
            {
                lista[i++] = t.ToString();
            }
            return lista;
        }
    }
}
