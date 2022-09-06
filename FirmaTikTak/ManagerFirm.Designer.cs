
namespace FirmaTikTak
{
    partial class ManagerFirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OperationsGrid = new System.Windows.Forms.DataGridView();
            this.MatGrid = new System.Windows.Forms.DataGridView();
            this.InstrumentsGrid = new System.Windows.Forms.DataGridView();
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.idmat = new System.Windows.Forms.TextBox();
            this.countmat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.countnst = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.idinst = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.idorder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstrumentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsGrid
            // 
            this.OperationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OperationsGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.OperationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationsGrid.GridColor = System.Drawing.Color.Ivory;
            this.OperationsGrid.Location = new System.Drawing.Point(453, 31);
            this.OperationsGrid.Name = "OperationsGrid";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationsGrid.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.OperationsGrid.Size = new System.Drawing.Size(494, 230);
            this.OperationsGrid.TabIndex = 16;
            this.OperationsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OperationsGrid_CellValueChanged);
            this.OperationsGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.OperationsGrid_UserDeletingRow);
            // 
            // MatGrid
            // 
            this.MatGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.MatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatGrid.GridColor = System.Drawing.Color.Ivory;
            this.MatGrid.Location = new System.Drawing.Point(481, 573);
            this.MatGrid.Name = "MatGrid";
            this.MatGrid.ReadOnly = true;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatGrid.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.MatGrid.Size = new System.Drawing.Size(430, 243);
            this.MatGrid.TabIndex = 17;
            this.MatGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MatGrid_RowHeaderMouseClick);
            // 
            // InstrumentsGrid
            // 
            this.InstrumentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InstrumentsGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.InstrumentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstrumentsGrid.GridColor = System.Drawing.Color.Ivory;
            this.InstrumentsGrid.Location = new System.Drawing.Point(12, 573);
            this.InstrumentsGrid.Name = "InstrumentsGrid";
            this.InstrumentsGrid.ReadOnly = true;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstrumentsGrid.RowsDefaultCellStyle = dataGridViewCellStyle19;
            this.InstrumentsGrid.Size = new System.Drawing.Size(428, 243);
            this.InstrumentsGrid.TabIndex = 18;
            this.InstrumentsGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.InstrumentsGrid_RowHeaderMouseClick);
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.GridColor = System.Drawing.Color.Ivory;
            this.OrdersGrid.Location = new System.Drawing.Point(453, 299);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersGrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.OrdersGrid.Size = new System.Drawing.Size(494, 230);
            this.OrdersGrid.TabIndex = 19;
            this.OrdersGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersGrid_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Инструменты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Материалы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Заказы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Операции";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(53, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Создание операций";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(163, 136);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Описание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 27;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(244, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 24);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Материалы";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(244, 190);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(130, 24);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Инструменты";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "ID = ";
            // 
            // idmat
            // 
            this.idmat.Location = new System.Drawing.Point(269, 95);
            this.idmat.Name = "idmat";
            this.idmat.ReadOnly = true;
            this.idmat.Size = new System.Drawing.Size(100, 26);
            this.idmat.TabIndex = 31;
            // 
            // countmat
            // 
            this.countmat.Location = new System.Drawing.Point(294, 140);
            this.countmat.Name = "countmat";
            this.countmat.ReadOnly = true;
            this.countmat.Size = new System.Drawing.Size(100, 26);
            this.countmat.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Кол-во = ";
            // 
            // countnst
            // 
            this.countnst.Location = new System.Drawing.Point(299, 272);
            this.countnst.Name = "countnst";
            this.countnst.ReadOnly = true;
            this.countnst.Size = new System.Drawing.Size(100, 26);
            this.countnst.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Кол-во = ";
            // 
            // idinst
            // 
            this.idinst.Location = new System.Drawing.Point(274, 227);
            this.idinst.Name = "idinst";
            this.idinst.ReadOnly = true;
            this.idinst.Size = new System.Drawing.Size(100, 26);
            this.idinst.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "ID = ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "ID заказа = ";
            // 
            // idorder
            // 
            this.idorder.Location = new System.Drawing.Point(106, 235);
            this.idorder.Name = "idorder";
            this.idorder.ReadOnly = true;
            this.idorder.Size = new System.Drawing.Size(100, 26);
            this.idorder.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(27, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 29);
            this.button1.TabIndex = 40;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(106, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 50);
            this.button2.TabIndex = 41;
            this.button2.Text = "Имитация производства";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(102, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(232, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Данные отправляются цехам";
            // 
            // ManagerFirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(994, 828);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idorder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.countnst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.idinst);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.countmat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idmat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.InstrumentsGrid);
            this.Controls.Add(this.MatGrid);
            this.Controls.Add(this.OperationsGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerFirm";
            this.Text = "ManagerFirm";
            ((System.ComponentModel.ISupportInitialize)(this.OperationsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstrumentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OperationsGrid;
        private System.Windows.Forms.DataGridView MatGrid;
        private System.Windows.Forms.DataGridView InstrumentsGrid;
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idmat;
        private System.Windows.Forms.TextBox countmat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox countnst;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idinst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox idorder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
    }
}