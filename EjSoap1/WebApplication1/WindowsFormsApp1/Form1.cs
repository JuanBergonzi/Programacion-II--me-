using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

            ServiceReference1.TipoDoc tipo = new ServiceReference1.TipoDoc();
            tipo.Codigo = tb_Codigo.Text;
            tipo.Descripcion = tb_Descrip.Text;
        
            client.CrearTipoDocumento(tipo);

            var lista = client.ObtenerListaDoc();
            dataGridView1.DataSource = lista;
            tb_Codigo.Clear();
            tb_Descrip.Clear();
            MessageBox.Show("Tipo creado correctamente");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

            var lista = client.ObtenerListaDoc();
            dataGridView1.DataSource = lista;
        }

        private void Refezcar_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

            var lista = client.ObtenerListaDoc();
            dataGridView1.DataSource = lista;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            string CodTipoDoc = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            if (CodTipoDoc != null)
            {
                client.EliminarTipoDocumento(CodTipoDoc);
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná una fila válida.");
            }



                var lista = client.ObtenerListaDoc();
            dataGridView1.DataSource = lista;
            tb_Codigo.Clear();
            tb_Descrip.Clear();
        }
    }
}
