using Montecarlo.Algoritmos;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Montecarlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            List<int> lista_xi = new List<int>();

            AlgoritmoGenerador algoritmo = new AlgoritmoGenerador();

            List<int> l1 = algoritmo.GenerarLista(n);
            List<int> l2 = algoritmo.GenerarLista(n);
            List<int> l3 = algoritmo.GenerarLista(n);
            List<int> l4 = algoritmo.GenerarLista(n);
            List<int> l5 = algoritmo.GenerarLista(n);

            llenarGrid1(l1, l2, l3, l4, l5);
            fallan_cuatro(n, lista_xi);
        }
        public void llenarGrid1(List<int> l1, List<int> l2, List<int> l3, List<int> l4, List<int> l5)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("1", "Exper. Nro.");
            dataGridView1.Columns.Add("2", "Panel 1");
            dataGridView1.Columns.Add("3", "Panel 2");
            dataGridView1.Columns.Add("4", "Panel 3");
            dataGridView1.Columns.Add("5", "Panel 4");
            dataGridView1.Columns.Add("6", "Panel 5");
            dataGridView1.Columns.Add("7", "Satélite x(i)");

            for (int i = 0; i < l1.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse("1") - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse("2") - 1].Value = l1[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse("3") - 1].Value = l2[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse("4") - 1].Value = l3[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse("5") - 1].Value = l4[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse("6") - 1].Value = l5[i].ToString();
            }
        }
        public void fallan_cuatro(int n, List<int> lista_xi)
        {
            int n_col = 5;

            for (int i = 0; i < n; i++)
            {
                int[] val_fil = new int[n_col];
                for (int j = 0; j < n_col; j++)
                {
                    val_fil[j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1].Value);
                }
                Array.Sort(val_fil);

                int tiempo_fallan4 = val_fil[n_col - 2];
                dataGridView1.Rows[i].Cells[Int32.Parse("7") - 1].Value = tiempo_fallan4.ToString();
                lista_xi.Add(tiempo_fallan4);
            }

            double promedio = lista_xi.Average();
            double suma = lista_xi.Sum(x => Math.Pow(x - promedio, 2));
            double var = suma / (lista_xi.Count() - 1);

            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("1", "Valor estimado Vida Útil");
            dataGridView2.Columns.Add("2", "Desviación estándar");

            dataGridView2.Rows[0].Cells[Int32.Parse("1") - 1].Value = promedio.ToString("N2");
            dataGridView2.Rows[0].Cells[Int32.Parse("2") - 1].Value = Math.Sqrt(var).ToString("N2");
        }
    }
}
