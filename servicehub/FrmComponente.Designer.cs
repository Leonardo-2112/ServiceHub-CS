namespace servicehub
{
    partial class FrmComponente
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
            dgvServicos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnPreco = new DataGridViewTextBoxColumn();
            clnDescontinuado = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            dgvUsuarios = new DataGridView();
            clnIdUsuarios = new DataGridViewTextBoxColumn();
            clnNomeUsuario = new DataGridViewTextBoxColumn();
            clnEmailUsuario = new DataGridViewTextBoxColumn();
            dgvSolicitacoes = new DataGridView();
            clnIdSolicitacoes = new DataGridViewTextBoxColumn();
            clnDescricaoSolicitacoes = new DataGridViewTextBoxColumn();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).BeginInit();
            SuspendLayout();
            // 
            // dgvServicos
            // 
            dgvServicos.AllowUserToAddRows = false;
            dgvServicos.AllowUserToDeleteRows = false;
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnDescricao, clnPreco, clnDescontinuado });
            dgvServicos.Location = new Point(70, 200);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.ReadOnly = true;
            dgvServicos.RowHeadersVisible = false;
            dgvServicos.Size = new Size(670, 117);
            dgvServicos.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 200;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 206;
            // 
            // clnPreco
            // 
            clnPreco.HeaderText = "Preço";
            clnPreco.Name = "clnPreco";
            clnPreco.ReadOnly = true;
            // 
            // clnDescontinuado
            // 
            clnDescontinuado.HeaderText = "Descontinuado";
            clnDescontinuado.Name = "clnDescontinuado";
            clnDescontinuado.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(24, 156);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(145, 156);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Operação";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 99);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 5;
            label2.Text = "Digite os números";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(309, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 154);
            listBox1.TabIndex = 8;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnIdUsuarios, clnNomeUsuario, clnEmailUsuario });
            dgvUsuarios.Location = new Point(70, 331);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(670, 127);
            dgvUsuarios.TabIndex = 9;
            // 
            // clnIdUsuarios
            // 
            clnIdUsuarios.Frozen = true;
            clnIdUsuarios.HeaderText = "ID";
            clnIdUsuarios.Name = "clnIdUsuarios";
            clnIdUsuarios.ReadOnly = true;
            clnIdUsuarios.Width = 40;
            // 
            // clnNomeUsuario
            // 
            clnNomeUsuario.Frozen = true;
            clnNomeUsuario.HeaderText = "Nome";
            clnNomeUsuario.Name = "clnNomeUsuario";
            clnNomeUsuario.ReadOnly = true;
            clnNomeUsuario.Width = 200;
            // 
            // clnEmailUsuario
            // 
            clnEmailUsuario.Frozen = true;
            clnEmailUsuario.HeaderText = "Email";
            clnEmailUsuario.Name = "clnEmailUsuario";
            clnEmailUsuario.ReadOnly = true;
            clnEmailUsuario.Width = 206;
            // 
            // dgvSolicitacoes
            // 
            dgvSolicitacoes.AllowUserToAddRows = false;
            dgvSolicitacoes.AllowUserToDeleteRows = false;
            dgvSolicitacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitacoes.Columns.AddRange(new DataGridViewColumn[] { clnIdSolicitacoes, clnDescricaoSolicitacoes });
            dgvSolicitacoes.Location = new Point(70, 472);
            dgvSolicitacoes.Name = "dgvSolicitacoes";
            dgvSolicitacoes.ReadOnly = true;
            dgvSolicitacoes.RowHeadersVisible = false;
            dgvSolicitacoes.Size = new Size(670, 102);
            dgvSolicitacoes.TabIndex = 10;
            // 
            // clnIdSolicitacoes
            // 
            clnIdSolicitacoes.Frozen = true;
            clnIdSolicitacoes.HeaderText = "ID";
            clnIdSolicitacoes.Name = "clnIdSolicitacoes";
            clnIdSolicitacoes.ReadOnly = true;
            // 
            // clnDescricaoSolicitacoes
            // 
            clnDescricaoSolicitacoes.Frozen = true;
            clnDescricaoSolicitacoes.HeaderText = "Descrição";
            clnDescricaoSolicitacoes.Name = "clnDescricaoSolicitacoes";
            clnDescricaoSolicitacoes.ReadOnly = true;
            clnDescricaoSolicitacoes.Width = 400;
            // 
            // button3
            // 
            button3.Location = new Point(70, 580);
            button3.Name = "button3";
            button3.Size = new Size(131, 23);
            button3.TabIndex = 11;
            button3.Text = "Ver Solicitações";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 664);
            Controls.Add(button3);
            Controls.Add(dgvSolicitacoes);
            Controls.Add(dgvUsuarios);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvServicos);
            Name = "FrmComponente";
            Text = "FrmComponente";
            Load += FrmComponente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServicos;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnPreco;
        private DataGridViewCheckBoxColumn clnDescontinuado;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnIdUsuarios;
        private DataGridViewTextBoxColumn clnNomeUsuario;
        private DataGridViewTextBoxColumn clnEmailUsuario;
        private DataGridView dgvSolicitacoes;
        private Button button3;
        private DataGridViewTextBoxColumn clnIdSolicitacoes;
        private DataGridViewTextBoxColumn clnDescricaoSolicitacoes;
    }
}