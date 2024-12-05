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
    public partial class Burbuja : Form
    {
        public Burbuja()
        {
            InitializeComponent();
        }

        private void txtDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string input = txtDatos.Text;  // Obtener la entrada del TextBox
            string[] inputArray = input.Split(',');  // Dividir el string en un array de strings

            // Convertir el array de strings a un array de enteros
            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            // Llamar al algoritmo de ordenamiento burbuja
            BubbleSort(numbers);

            // Convertir el array de números ordenados a un string
            string sortedNumbers = string.Join(", ", numbers);

            // Mostrar el resultado en el TextBox de resultados
            txtOrdenados.Text = sortedNumbers;
        }

        private void txtOrdenados_TextChanged(object sender, EventArgs e)
        {

        }
        public void BubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Comparar elementos adyacentes
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Intercambiar si están en el orden incorrecto
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
    }
}
