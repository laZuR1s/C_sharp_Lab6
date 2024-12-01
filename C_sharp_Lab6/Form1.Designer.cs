namespace C_sharp_Lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            buttonSavePrevious = new Button();
            buttonSaveResult = new Button();
            buttonLoadFromFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(293, 325);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Введите данные...";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(495, 113);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Size = new Size(293, 325);
            dataGridView2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(348, 230);
            button1.Name = "button1";
            button1.Size = new Size(97, 76);
            button1.TabIndex = 3;
            button1.Text = "Изменить матрицу";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(348, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Введите данные...";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.UseWaitCursor = true;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Location = new Point(143, 12);
            button2.Name = "button2";
            button2.Size = new Size(138, 23);
            button2.TabIndex = 5;
            button2.Text = "Создать матрицу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonSavePrevious
            // 
            buttonSavePrevious.BackColor = Color.FromArgb(192, 255, 192);
            buttonSavePrevious.Location = new Point(86, 84);
            buttonSavePrevious.Name = "buttonSavePrevious";
            buttonSavePrevious.Size = new Size(125, 23);
            buttonSavePrevious.TabIndex = 6;
            buttonSavePrevious.Text = "Сохранить";
            buttonSavePrevious.UseVisualStyleBackColor = false;
            buttonSavePrevious.Click += buttonSavePrevious_Click;
            // 
            // buttonSaveResult
            // 
            buttonSaveResult.BackColor = Color.FromArgb(192, 255, 192);
            buttonSaveResult.Location = new Point(574, 84);
            buttonSaveResult.Name = "buttonSaveResult";
            buttonSaveResult.Size = new Size(125, 23);
            buttonSaveResult.TabIndex = 7;
            buttonSaveResult.Text = "Сохранить";
            buttonSaveResult.UseVisualStyleBackColor = false;
            buttonSaveResult.Click += buttonSaveResult_Click;
            // 
            // buttonLoadFromFile
            // 
            buttonLoadFromFile.BackColor = Color.FromArgb(255, 192, 192);
            buttonLoadFromFile.Location = new Point(306, 12);
            buttonLoadFromFile.Name = "buttonLoadFromFile";
            buttonLoadFromFile.Size = new Size(182, 23);
            buttonLoadFromFile.TabIndex = 8;
            buttonLoadFromFile.Text = "Заполнить из файла";
            buttonLoadFromFile.UseVisualStyleBackColor = false;
            buttonLoadFromFile.Click += buttonLoadFromFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoadFromFile);
            Controls.Add(buttonSaveResult);
            Controls.Add(buttonSavePrevious);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private Button buttonSavePrevious;
        private Button buttonSaveResult;
        private Button buttonLoadFromFile;
    }
}
