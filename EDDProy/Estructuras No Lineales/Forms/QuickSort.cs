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
    public partial class QuickSort : Form
    {
        public QuickSort()
        {
            InitializeComponent();
        }

        private void QuickSort_Load(object sender, EventArgs e)
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

            // Aplicar el algoritmo de ordenamiento QuickSort
            QuickSortAlgorithm(numbers, 0, numbers.Length - 1);

            // Convertir el array de números ordenados a un string
            string sortedNumbers = string.Join(", ", numbers);

            // Mostrar el resultado en el TextBox txtOrdenados
            txtOrdenados.Text = sortedNumbers;
        }

        private void txtOrdenados_TextChanged(object sender, EventArgs e)
        {

        }

        // Método para el algoritmo de QuickSort
        private void QuickSortAlgorithm(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Encontrar el índice de partición
                int pi = Partition(array, low, high);

                // Ordenar los elementos antes y después de la partición
                QuickSortAlgorithm(array, low, pi - 1);
                QuickSortAlgorithm(array, pi + 1, high);
            }
        }

        // Método para la partición del array
        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1); // Índice del elemento más pequeño

            for (int j = low; j < high; j++)
            {
                // Si el elemento actual es menor o igual que el pivote
                if (array[j] <= pivot)
                {
                    i++;

                    // Intercambiar array[i] y array[j]
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // Intercambiar array[i+1] y array[high] (o el pivote)
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
    }
}
