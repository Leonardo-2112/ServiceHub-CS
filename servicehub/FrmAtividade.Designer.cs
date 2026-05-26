namespace servicehub
{
    partial class FrmAtividade
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
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnAdd = new Button();
            checkBox1 = new CheckBox();
            txtID = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            label3 = new Label();
            txtDataNasc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtDataCad = new TextBox();
            label4 = new Label();
            dgvCliente = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
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
            btnExcluir.Location = new Point(581, 245);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 57);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
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
            btnPesquisar.Location = new Point(256, 245);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 57);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
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
            btnEditar.Location = new Point(416, 245);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 57);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
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
            btnAdd.Location = new Point(91, 245);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 57);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "&Adicionar";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(554, 100);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(106, 50);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(79, 23);
            txtID.TabIndex = 27;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(292, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(214, 23);
            txtNome.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 53);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 23;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 53);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 24;
            label2.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 145);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 26;
            label5.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(106, 140);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(213, 23);
            txtTelefone.TabIndex = 28;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(106, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 23);
            txtEmail.TabIndex = 16;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(106, 190);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(213, 23);
            txtCpf.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 193);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 30;
            label3.Text = "CPF";
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(473, 137);
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(183, 23);
            txtDataNasc.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 140);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 32;
            label6.Text = "Data de Nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 190);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 34;
            label7.Text = "Data de Cadastro";
            // 
            // txtDataCad
            // 
            txtDataCad.Location = new Point(473, 187);
            txtDataCad.Name = "txtDataCad";
            txtDataCad.Size = new Size(183, 23);
            txtDataCad.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 101);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 35;
            label4.Text = "Email";
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnTelefone, clnCpf, clnDataNasc, clnDataCad, clnAtivo });
            dgvCliente.Location = new Point(12, 345);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.Size = new Size(776, 150);
            dgvCliente.TabIndex = 36;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 110;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 110;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnDataNasc
            // 
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data de Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            // 
            // clnDataCad
            // 
            clnDataCad.Frozen = true;
            clnDataCad.HeaderText = "Data de Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // FrmAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(dgvCliente);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtDataCad);
            Controls.Add(label6);
            Controls.Add(txtDataNasc);
            Controls.Add(label3);
            Controls.Add(txtCpf);
            Controls.Add(txtTelefone);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdd);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Name = "FrmAtividade";
            Text = "FrmAtividade";
            Load += FrmAtividade_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnAdd;
        private CheckBox checkBox1;
        private TextBox txtID;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private Label label3;
        private TextBox txtDataNasc;
        private Label label6;
        private Label label7;
        private TextBox txtDataCad;
        private Label label4;
        private DataGridView dgvCliente;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewTextBoxColumn clnAtivo;
    }
}