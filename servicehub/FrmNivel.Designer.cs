namespace servicehub
{
    partial class FrmNivel
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
            dgvCategorias = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            label4 = new Label();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnSigla });
            dgvCategorias.Location = new Point(101, 286);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(599, 150);
            dgvCategorias.TabIndex = 44;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 394;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(101, 257);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Categoria";
            txtBuscar.Size = new Size(599, 23);
            txtBuscar.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(246, 15);
            label4.Name = "label4";
            label4.Size = new Size(250, 32);
            label4.TabIndex = 42;
            label4.Text = "Cadastro de Categoria";
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
            btnExcluir.Location = new Point(421, 171);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 57);
            btnExcluir.TabIndex = 36;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
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
            btnCancelar.Location = new Point(521, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 57);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
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
            btnPesquisar.Location = new Point(221, 171);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 57);
            btnPesquisar.TabIndex = 34;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
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
            btnEditar.Location = new Point(321, 171);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 57);
            btnEditar.TabIndex = 35;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
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
            btnAdd.Location = new Point(121, 171);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 57);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "&Adicionar";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 82);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 40;
            label3.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 82);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 39;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 82);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 38;
            label1.Text = "ID";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(246, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 23);
            txtNome.TabIndex = 31;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(539, 100);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(69, 23);
            txtSigla.TabIndex = 32;
            // 
            // txtID
            // 
            txtID.Location = new Point(132, 100);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(79, 23);
            txtID.TabIndex = 41;
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtSigla);
            Controls.Add(txtID);
            Name = "FrmNivel";
            Text = "FrmNivel";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategorias;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSigla;
        private TextBox txtBuscar;
        private Label label4;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtSigla;
        private TextBox txtID;
    }
}