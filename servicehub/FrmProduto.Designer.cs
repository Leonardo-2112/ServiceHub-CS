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
            txtCodBarras = new TextBox();
            txtDescricao = new TextBox();
            label5 = new Label();
            txtUnidadeVenda = new TextBox();
            label6 = new Label();
            nudValorUnit = new NumericUpDown();
            nudEstoqueMinimo = new NumericUpDown();
            cmbCategoria = new ComboBox();
            label7 = new Label();
            nudClasseDesconto = new NumericUpDown();
            button3 = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudValorUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(126, 51);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.PlaceholderText = "Código de Barras";
            txtCodBarras.Size = new Size(212, 23);
            txtCodBarras.TabIndex = 4;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(126, 87);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(379, 23);
            txtDescricao.TabIndex = 5;
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
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(344, 123);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PlaceholderText = "Unid. Venda";
            txtUnidadeVenda.Size = new Size(161, 23);
            txtUnidadeVenda.TabIndex = 7;
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
            // nudValorUnit
            // 
            nudValorUnit.Location = new Point(126, 123);
            nudValorUnit.Name = "nudValorUnit";
            nudValorUnit.Size = new Size(110, 23);
            nudValorUnit.TabIndex = 9;
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.Location = new Point(154, 195);
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(106, 23);
            nudEstoqueMinimo.TabIndex = 10;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(126, 159);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(379, 23);
            cmbCategoria.TabIndex = 11;
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
            // nudClasseDesconto
            // 
            nudClasseDesconto.Location = new Point(395, 195);
            nudClasseDesconto.Name = "nudClasseDesconto";
            nudClasseDesconto.Size = new Size(110, 23);
            nudClasseDesconto.TabIndex = 13;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Firebrick;
            button3.Image = Properties.Resources.Cancel;
            button3.Location = new Point(503, 276);
            button3.Name = "button3";
            button3.Size = new Size(163, 61);
            button3.TabIndex = 16;
            button3.Text = "&Cancelar";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.Green;
            btnSalvar.Image = Properties.Resources.Down;
            btnSalvar.Location = new Point(87, 276);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(163, 61);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "&Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Goldenrod;
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.Location = new Point(298, 276);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(163, 61);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 356);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(632, 150);
            dataGridView1.TabIndex = 23;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(button3);
            Controls.Add(nudClasseDesconto);
            Controls.Add(label7);
            Controls.Add(cmbCategoria);
            Controls.Add(nudEstoqueMinimo);
            Controls.Add(nudValorUnit);
            Controls.Add(label6);
            Controls.Add(txtUnidadeVenda);
            Controls.Add(label5);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodBarras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)nudValorUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodBarras;
        private TextBox txtDescricao;
        private Label label5;
        private TextBox txtUnidadeVenda;
        private Label label6;
        private NumericUpDown nudValorUnit;
        private NumericUpDown nudEstoqueMinimo;
        private ComboBox cmbCategoria;
        private Label label7;
        private NumericUpDown nudClasseDesconto;
        private Button button3;
        private Button btnSalvar;
        private Button btnEditar;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
    }
}