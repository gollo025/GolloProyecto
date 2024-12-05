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
    public partial class ShellSort : Form
    {
        public ShellSort()
        {
            InitializeComponent();
        }

        private void ShellSort_Load(object sender, EventArgs e)
        {

        }

        private void txtDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados en el TextBox txtDatos
            string input = txtDatos.Text;

            // Dividir el string de entrada en un array de strings
            string[] inputArray = input.Split(',');

            // Convertir el array de strings a un array de enteros
            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            // Aplicar el algoritmo de ordenamiento ShellSort
            ShellSortAlgorithm(numbers);

            // Convertir el array de números ordenados a un string
            string sortedNumbers = string.Join(", ", numbers);

            // Mostrar el resultado en el TextBox txtOrdenados
            txtOrdenados.Text = sortedNumbers;
        }

        private void txtOrdenados_TextChanged(object sender, EventArgs e)
        {

        }

        // Método para el algoritmo de ShellSort
        private void ShellSortAlgorithm(int[] array)
        {
            int n = array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
            }
        }
    }
}
