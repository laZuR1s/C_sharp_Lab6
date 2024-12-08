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
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
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
            dataGridView1.Location = new Point(12, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(293, 325);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(131, 55);
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
            dataGridView2.Location = new Point(589, 230);
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
            button1.Location = new Point(354, 370);
            button1.Name = "button1";
            button1.Size = new Size(185, 76);
            button1.TabIndex = 3;
            button1.Text = "Изменить матрицу";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(399, 341);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Введите данные...";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Location = new Point(77, 159);
            button2.Name = "button2";
            button2.Size = new Size(154, 36);
            button2.TabIndex = 5;
            button2.Text = "Создать матрицу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonSavePrevious
            // 
            buttonSavePrevious.BackColor = Color.FromArgb(192, 255, 192);
            buttonSavePrevious.Location = new Point(92, 201);
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
            buttonSaveResult.Location = new Point(673, 201);
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
            buttonLoadFromFile.Location = new Point(354, 12);
            buttonLoadFromFile.Name = "buttonLoadFromFile";
            buttonLoadFromFile.Size = new Size(185, 80);
            buttonLoadFromFile.TabIndex = 8;
            buttonLoadFromFile.Text = "Заполнить из файла";
            buttonLoadFromFile.UseVisualStyleBackColor = false;
            buttonLoadFromFile.Click += buttonLoadFromFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 9;
            label1.Text = "Строки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 10;
            label2.Text = "Столбцы";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(131, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            textBox3.Text = "Введите данные...";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(894, 576);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private TextBox textBox3;
    }
}
