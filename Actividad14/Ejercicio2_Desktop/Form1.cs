using Ejercicio1_Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio2_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sistema sistema = new Sistema();
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {

                string destino = cmbDestino.SelectedItem as string;
                string tipo = cmbTransporte.SelectedItem as string;

                string cuit = tbCUIT.Text;
                string nombre = tbNombre.Text;
                string telefono = tbTelefono.Text;
                string nTarjeta = tbNTarjeta.Text;

                //Falta... destino y tipo
                sistema.CrearTicket(cuit, nombre, telefono, nTarjeta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnResumen_Click(object sender, EventArgs e)
        {
            FormVerDatos formVer = new FormVerDatos();
            formVer.listBox1.Items.AddRange(sistema.VerTicket());

            formVer.ShowDialog();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.Open, FileAccess.Read);
#pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                sistema = bf.Deserialize(fs) as Sistema;
#pragma warning restore SYSLIB0011
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Deserializar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.OpenOrCreate, FileAccess.Write);
#pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, sistema);
#pragma warning restore SYSLIB0011
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Serializar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "IMPORTACION";
            openFileDialog1.Filter = "(csv)|*.csv|(txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                    sistema.ImportarTransporte(fs);

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error en la importación",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
        }
    }
}
