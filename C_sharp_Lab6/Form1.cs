using System.Data;
using System.Drawing;
using System.Security.Policy;

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
            this.Select();
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



        private void buttonSavePrevious_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить исходную матрицу";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        int colCount = dataGridView1.ColumnCount;

                        writer.WriteLine($"{colCount}");
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                if (j < N - 1)
                                    writer.Write(' ');
                            }
                            writer.WriteLine();
                        }
                    }
                    MessageBox.Show("Исходная матрица сохранена.");
                }
            }
            else
            {
                MessageBox.Show("Невозможно сохранить матрицу");
            }
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
            openFileDialog.Title = "Открыть файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                N = Convert.ToInt32(lines[0]);

                DataTable matr = new DataTable("matr");
                DataColumn[] cols = new DataColumn[N];
                for (int i = 0; i < N; i++)
                {
                    cols[i] = new DataColumn(i.ToString());
                    matr.Columns.Add(cols[i]);
                }
                for (int i = 1; i <= N; i++)
                {
                    string[] values = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    DataRow newRow;
                    newRow = matr.NewRow();
                    for (int j = 0; j < N; j++)
                    {
                        newRow[j] = int.Parse(values[j]);
                    }
                    matr.Rows.Add(newRow);
                }
                dataGridView1.DataSource = matr;
                dataGridView1.Visible = true;

                for (int i = 0; i < N; i++)
                    dataGridView1.Columns[i].Width = 50;
                ;
            }
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|C# Files (*.cs)|*.cs|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        int colCount = dataGridView2.ColumnCount;
                        int rowCount =dataGridView2.RowCount;
                        writer.WriteLine((rowCount).ToString()+" "+colCount.ToString());
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < colCount; j++)
                            {
                                writer.Write(dataGridView2.Rows[i].Cells[j].Value.ToString());
                                if (j < colCount - 1)
                                    writer.Write(' ');
                            }
                            writer.WriteLine();
                        }
                    }
                    MessageBox.Show("Полученная матрица сохранена.");
                }
            }
            else
            {
                MessageBox.Show("Невозможно сохранить матрицу");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox1.Text == "Введите данные...") 
            {
                textBox1.Text = "";  
                textBox1.ForeColor = Color.Black;  
            }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if ( string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Введите данные...";  
                textBox1.ForeColor = Color.Gray; 
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2 != null && textBox2.Text == "Введите данные...") 
            {
                textBox2.Text = ""; 
                textBox2.ForeColor = Color.Black; 
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Введите данные...";  
                textBox2.ForeColor = Color.Gray;  
            }
           
        }
    }
}
