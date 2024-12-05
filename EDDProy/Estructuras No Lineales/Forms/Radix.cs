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
    public partial class RadixSort : Form
    {
        public RadixSort()
        {
            InitializeComponent();
        }

        private void RadixSort_Load(object sender, EventArgs e)
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

            // Aplicar el algoritmo de ordenamiento Radix Sort
            RadixSortAlgorithm(numbers);

            // Convertir el array de números ordenados a un string
            string sortedNumbers = string.Join(", ", numbers);

            // Mostrar el resultado en el TextBox txtOrdenados
            txtOrdenados.Text = sortedNumbers;
        }

        private void txtOrdenados_TextChanged(object sender, EventArgs e)
        {

        }

        // Método para el algoritmo de Radix Sort
        private void RadixSortAlgorithm(int[] array)
        {
            int max = GetMax(array);
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(array, exp);
            }
        }

        // Método para obtener el valor máximo en el array
        private int GetMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        // Método para el algoritmo de Counting Sort utilizado en Radix Sort
        private void CountingSort(int[] array, int exp)
        {
            int n = array.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            // Inicializar count[] como 0
            for (int i = 0; i < 10; i++)
                count[i] = 0;

            // Guardar el conteo de ocurrencias en count[]
            for (int i = 0; i < n; i++)
                count[(array[i] / exp) % 10]++;

            // Cambiar count[i] para que contenga la posición real de este dígito en output[]
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Construir el array output[]
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            // Copiar los elementos ordenados de output[] a array[]
            for (int i = 0; i < n; i++)
                array[i] = output[i];
        }
    }
}
