using System.Data;
using System.Drawing;
using System.Security.Policy;

namespace C_sharp_Lab6
{
    public partial class Form1 : Form
    {

        int str;
        int col;
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
            MatrMake mt = new MatrMake(str, col);
            mt.GridToMatrix(dataGridView1);
            int value;
            if (!int.TryParse(textBox2.Text, out value))
            {
                MessageBox.Show("������� ���������� �������� � ���� �����!");
                return;
            }


            if (mt.AddCol(value))
                MessageBox.Show("��� ������� �� �������� ��������� ��������");
            else

            {
                dataGridView2.Visible = true;
                mt.MatrixToGrid(dataGridView2);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(textBox1.Text, out str))
            {
                MessageBox.Show("������� ���������� �������� � ���� �����!");
                return;
            }
            if (!int.TryParse(textBox3.Text, out col))
            {
                MessageBox.Show("������� ���������� �������� � ���� �����!");
                return;
            }
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[col];
            for (i = 0; i < col; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }
            for (i = 0; i < str; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            dataGridView1.DataSource = matr;
            for (i = 0; i < col; i++)
                dataGridView1.Columns[i].Width = 50;
            dataGridView1.Visible = true;
        }



        private void buttonSavePrevious_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
                saveFileDialog.Title = "��������� �������� �������";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        int colCount = dataGridView1.ColumnCount;
                        int rowCount = dataGridView1.RowCount;

                        writer.WriteLine(rowCount + " " + colCount);
                        for (int i = 0; i < rowCount; i++)
                        {
                            for (int j = 0; j < colCount; j++)
                            {
                                writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                if (j < colCount - 1)
                                    writer.Write(' ');
                            }
                            writer.WriteLine();
                        }
                    }
                    MessageBox.Show("�������� ������� ���������.");
                }
            }
            else
            {
                MessageBox.Show("���������� ��������� �������");
            }
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
            openFileDialog.Title = "������� ����";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                string[] dimensions = lines[0].Split(' ');
                str = Convert.ToInt32(dimensions[0]);
                col = Convert.ToInt32(dimensions[1]);

                DataTable matr = new DataTable("matr");
                DataColumn[] cols = new DataColumn[col];
                for (int i = 0; i < col; i++)
                {
                    cols[i] = new DataColumn(i.ToString());
                    matr.Columns.Add(cols[i]);
                }
                for (int i = 1; i <= str; i++)
                {
                    string[] values = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    DataRow newRow;
                    newRow = matr.NewRow();
                    for (int j = 0; j < col; j++)
                    {
                        newRow[j] = int.Parse(values[j]);
                    }
                    matr.Rows.Add(newRow);
                }
                dataGridView1.DataSource = matr;
                dataGridView1.Visible = true;

                for (int i = 0; i < col; i++)
                    dataGridView1.Columns[i].Width = 50;

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
                        int rowCount = dataGridView2.RowCount;
                        writer.WriteLine((rowCount).ToString() + " " + colCount.ToString());
                        for (int i = 0; i < rowCount; i++)
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
                    MessageBox.Show("���������� ������� ���������.");
                }
            }
            else
            {
                MessageBox.Show("���������� ��������� �������");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox1.Text == "������� ������...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "������� ������...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2 != null && textBox2.Text == "������� ������...")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "������� ������...";
                textBox2.ForeColor = Color.Gray;
            }

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3 != null && textBox3.Text == "������� ������...")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "������� ������...";
                textBox3.ForeColor = Color.Gray;
            }
        }
    }
}
