namespace servicehub
{
    partial class FrmServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServico));
            txtID = new TextBox();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            btnAdd = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(136, 34);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(79, 23);
            txtID.TabIndex = 13;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(136, 158);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(287, 23);
            txtDescricao.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(136, 96);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(143, 23);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 37);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 98);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 159);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 220);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 12;
            label4.Text = "Preço";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(317, 221);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Descontinuado";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial Narrow", 11.25F);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.Location = new Point(84, 277);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 57);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "&Adicionar";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Arial Narrow", 11.25F);
            btnEditar.ForeColor = Color.Goldenrod;
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.Location = new Point(266, 277);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 57);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial Narrow", 11.25F);
            btnPesquisar.ForeColor = Color.FromArgb(0, 192, 192);
            btnPesquisar.Image = Properties.Resources.Search;
            btnPesquisar.Location = new Point(175, 277);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 57);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial Narrow", 11.25F);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(448, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 57);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial Narrow", 11.25F);
            btnExcluir.ForeColor = Color.Firebrick;
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.Location = new Point(357, 277);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 57);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(153, 217);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(126, 23);
            txtPreco.TabIndex = 14;
            // 
            // FrmServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(txtPreco);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdd);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtDescricao);
            Controls.Add(txtID);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmServico";
            Text = "ServiceHub - Serviços";
            Load += FrmServico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private Button btnAdd;
        private Button btnEditar;
        private Button btnPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private TextBox txtPreco;
    }
}