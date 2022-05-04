using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ФормыЛР8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            Random rnd = new Random();
            int n, H = 0, sum = 0;
            int[,] arr = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    n = rnd.Next(-20, 20);
                    arr[i, j] = n;
                    dataGridView1.Rows[i].Cells[j].Value = n;
                    if (arr[i, 4] > 0)
                        H++;
                }
            }

            if (H < 3)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arr[i, j] > 0)
                            listBox1.Items.Add(arr[i, j]);
                    }
                }
            }
            else if (H >= 3)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == j)
                            sum += arr[i, j];
                    }
                }
            }
            textBox1.Text = sum.ToString();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
