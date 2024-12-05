using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales.Forms
{
    public partial class BusquedaInterna : Form
    {
        public BusquedaInterna()
        {
            InitializeComponent();
        }

        private void txtInsertar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDatoBuscado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados en el TextBox txtInsertar
            string inputData = txtInsertar.Text;

            // Dividir el string de entrada en un array de strings
            string[] inputArray = inputData.Split(',');

            // Convertir el array de strings a un array de enteros
            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            // Obtener el dato a buscar del TextBox txtDato
            int datoABuscar = int.Parse(txtDato.Text);

            // Buscar el dato en el array
            bool encontrado = false;
            foreach (int num in numbers)
            {
                if (num == datoABuscar)
                {
                    encontrado = true;
                    break;
                }
            }

            // Mostrar el resultado en el TextBox txtDatoBuscado
            if (encontrado)
            {
                txtDatoBuscado.Text = "Dato encontrado: " + datoABuscar;
            }
            else
            {
                txtDatoBuscado.Text = "Dato no encontrado";
            }
        }
    }
}
