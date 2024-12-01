using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Lab6
{
    internal class MatrMake
    {
        int n_str, n_col; //количество столбцов
        int[,] matrix; // обрабатываемая матрица
        public MatrMake(int n)
        {
            n_str = n; // на входе матрица квадратная
            n_col = n;
            matrix = new int[n, n];
        }

        //заполнение матрицы из DataGridView
        public void GridToMatrix(DataGridView dgv)
        {
            DataGridViewCell txtCell;
            for (int i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    string s = txtCell.Value.ToString();
                    if (s == "")
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = Int32.Parse(s);
                }
            }
        }

        //вывод матрицы в DataGridView
        public void MatrixToGrid(DataGridView dgv)
        {
            //установка размеров
            int i;
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[n_col];
            for (i = 0; i < n_col; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }
            for (i = 0; i < n_str; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            dgv.DataSource = matr;
            for (i = 0; i < n_col; i++)
                dgv.Columns[i].Width = 50;
            // занесение значений
            DataGridViewCell txtCell;
            for (i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    txtCell.Value = matrix[i, j].ToString();
                }
            }
        }

        // добавление столбцов, содержащих value
        public bool AddCol(int value)//true, если результат пустая матрица
        {
            // Создаем новую матрицу с увеличенным количеством столбцов
            int[,] newMatrix = new int[n_str, n_col * 2];
            int newColCount = 0;

            for (int j = 0; j < n_col; j++)
            {
                // Копируем текущий столбец
                for (int i = 0; i < n_str; i++)
                {
                    newMatrix[i, newColCount] = matrix[i, j];
                }
                newColCount++;

                // Проверяем, содержит ли столбец значение
                bool containsValue = false;
                for (int i = 0; i < n_str; i++)
                {
                    if (matrix[i, j] == value)
                    {
                        containsValue = true;
                        break;
                    }
                }

                // Если столбец содержит значение, добавляем его копию
                if (containsValue)
                {
                    for (int i = 0; i < n_str; i++)
                    {
                        newMatrix[i, newColCount] = matrix[i, j];
                    }
                    newColCount++;
                }
            }
            bool flag=false;
            if(n_col==newColCount)
                flag= true;
            // Обновляем матрицу и количество столбцов
            n_col = newColCount;
            matrix = new int[n_str, n_col];
            for (int i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    matrix[i, j] = newMatrix[i, j];
                }
            }
            return flag;
        }
    }
}
