using System.Data;

namespace C_sharp_Lab6
{
    public partial class Form1 : Form
    {

        int N;

        public Form1()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            this.Text = "Task 10";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            MatrMake mt = new MatrMake(N);
            mt.GridToMatrix(dataGridView1);
            int value;
            if (!int.TryParse(textBox2.Text, out value))
            {
                MessageBox.Show("Введите корректное значение в поле ввода!");
                return;
            }


            if (mt.AddCol(value))
                MessageBox.Show("Все столбцы не содержат заданного значения");
            else

            {
                dataGridView2.Visible = true;
                mt.MatrixToGrid(dataGridView2);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(textBox1.Text, out N))
            {
                MessageBox.Show("Введите корректное значение в поле ввода!");
                return;
            }
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[N];
            for (i = 0; i < N; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }
            for (i = 0; i < N; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            dataGridView1.DataSource = matr;
            for (i = 0; i < N; i++)
                dataGridView1.Columns[i].Width = 50;
            dataGridView1.Visible = true;
        }
    }
}
