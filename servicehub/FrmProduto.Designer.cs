namespace servicehub
{
    partial class FrmProduto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label7 = new Label();
            numericUpDown3 = new NumericUpDown();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 51);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "CodBarras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 88);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 124);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 51);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Código de Barras";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 87);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Descrição";
            textBox2.Size = new Size(379, 23);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 124);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 6;
            label5.Text = "Unidade Venda";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(344, 123);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Unid. Venda";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 197);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 8;
            label6.Text = "Estoque Minimo";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(126, 123);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(110, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(154, 195);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(106, 23);
            numericUpDown2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(126, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(379, 23);
            comboBox1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(298, 197);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 12;
            label7.Text = "Classe Desconto";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(395, 195);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(110, 23);
            numericUpDown3.TabIndex = 13;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Firebrick;
            button3.Image = Properties.Resources.Cancel;
            button3.Location = new Point(489, 311);
            button3.Name = "button3";
            button3.Size = new Size(163, 61);
            button3.TabIndex = 16;
            button3.Text = "&Cancelar";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Green;
            button1.Image = Properties.Resources.Down;
            button1.Location = new Point(73, 311);
            button1.Name = "button1";
            button1.Size = new Size(163, 61);
            button1.TabIndex = 17;
            button1.Text = "&Salvar";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Goldenrod;
            button2.Image = Properties.Resources.Edit;
            button2.Location = new Point(284, 311);
            button2.Name = "button2";
            button2.Size = new Size(163, 61);
            button2.TabIndex = 18;
            button2.Text = "&Editar";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button4.Image = Properties.Resources.Search;
            button4.Location = new Point(409, 44);
            button4.Name = "button4";
            button4.Size = new Size(96, 34);
            button4.TabIndex = 19;
            button4.Text = "&Buscar";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(522, 226);
            button5.Name = "button5";
            button5.Size = new Size(164, 29);
            button5.TabIndex = 20;
            button5.Text = "Carregar Imagem";
            button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(522, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 172);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(373, 237);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Descontinuado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(numericUpDown3);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox1;
        private Label label7;
        private NumericUpDown numericUpDown3;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
    }
}