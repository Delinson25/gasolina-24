using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            



        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i;
            double precio = 293.6;
            double promedio = Convert.ToDouble(pmciudad.Text);
            double galon = 3.78541;        
           double costoxkm;
          double kmxgalon;


            for(i =1; i < 22; i++)
            {
                int n = gasolina.Rows.Add();
                gasolina.Rows[n].Cells[0].Value = i;
                promedio = promedio - 0.1;
                gasolina.Rows[n].Cells[1].Value = promedio;

                
                    kmxgalon = promedio / galon;
                    costoxkm = precio / kmxgalon;
                    gasolina.Rows[n].Cells[2].Value = kmxgalon;
                    gasolina.Rows[n].Cells[3].Value = costoxkm;
                
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pmciudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
