using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int[] numeros = new int[10];
        private int contadorNumeros = 0;
        public Form1()
        {
            InitializeComponent();
            // Cambiar el color de fondo de la ventana
            this.BackColor = Color.LightGray;

            // Cambiar el tipo de letra y tamaño de la fuente
            this.Font = new Font("Arial", 12);
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // Cambiar el color de fondo de la ventana
            this.BackColor = Color.LightGray;

            // Cambiar el tipo de letra y tamaño de la fuente
            this.Font = new Font("Arial", 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // para que solo se ingresen números
            int num;
            if (int.TryParse(txtNumero.Text, out num))

            {
                // Agregar el número al arreglo
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == 0)
                    {
                        numeros[i] = num;

                        contadorNumeros++;
                        // se llena la progressbar
                        progressBar.Value = contadorNumeros;
                        break;
                    }
                }

                // ordena los números en el arreglo
                Array.Sort(numeros);

                if (contadorNumeros <= 10)
                {
                    progressBar.Value = contadorNumeros;
                }

                // agrega los numeros a l listbox
                lstNumeros.Items.Clear();
                foreach (int numero in numeros)
                {
                    if (numero != 0)
                        lstNumeros.Items.Add(numero);

                }

               
                txtNumero.Clear();
                if (contadorNumeros >= 10)
                {
                    btnA.Enabled = false;
                    this.BackColor = Color.Black;

                    // Cambiar fuente
                    this.Font = new Font("Comic Sans", 10);
                }

             
            }

            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ActualizarListBox()
        {
            lstNumeros.Items.Clear();
            foreach (int numero in numeros)
            {
                if (numero != 0)
                    lstNumeros.Items.Add(numero);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

    }
}
