namespace ProjetoApresentação
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.gpxNovoAluno = new System.Windows.Forms.GroupBox();
            this.mktData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.dvgMatriculas = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpxNovoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatriculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSexo
            // 
            this.cmbSexo.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSexo.Items.AddRange(new object[] {
            ""});
            this.cmbSexo.Location = new System.Drawing.Point(15, 90);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(100, 23);
            this.cmbSexo.TabIndex = 3;
            this.cmbSexo.TabStop = false;
            // 
            // gpxNovoAluno
            // 
            this.gpxNovoAluno.Controls.Add(this.mktData);
            this.gpxNovoAluno.Controls.Add(this.cmbSexo);
            this.gpxNovoAluno.Controls.Add(this.label2);
            this.gpxNovoAluno.Controls.Add(this.btnAdicionar);
            this.gpxNovoAluno.Controls.Add(this.txtCpf);
            this.gpxNovoAluno.Controls.Add(this.btnLimpar);
            this.gpxNovoAluno.Controls.Add(this.lblCpf);
            this.gpxNovoAluno.Controls.Add(this.lblSexo);
            this.gpxNovoAluno.Controls.Add(this.txtNome);
            this.gpxNovoAluno.Controls.Add(this.label1);
            this.gpxNovoAluno.Controls.Add(this.txtMatricula);
            this.gpxNovoAluno.Controls.Add(this.lblMatricula);
            this.gpxNovoAluno.Location = new System.Drawing.Point(4, 18);
            this.gpxNovoAluno.Name = "gpxNovoAluno";
            this.gpxNovoAluno.Size = new System.Drawing.Size(713, 129);
            this.gpxNovoAluno.TabIndex = 0;
            this.gpxNovoAluno.TabStop = false;
            this.gpxNovoAluno.Text = "Novo Aluno";
            // 
            // mktData
            // 
            this.mktData.Location = new System.Drawing.Point(143, 89);
            this.mktData.Mask = "00/00/0000";
            this.mktData.Name = "mktData";
            this.mktData.Size = new System.Drawing.Size(100, 23);
            this.mktData.TabIndex = 4;
            this.mktData.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nascimento*";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(603, 90);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(98, 25);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(295, 90);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(168, 23);
            this.txtCpf.TabIndex = 5;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Location = new System.Drawing.Point(489, 89);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 25);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(295, 72);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(84, 15);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF(Opcional)";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(15, 72);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(37, 15);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "Sexo*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 37);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(558, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome*";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(15, 37);
            this.txtMatricula.MaxLength = 9;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMatricula.Size = new System.Drawing.Size(100, 23);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(15, 19);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(62, 15);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula*";
            // 
            // dvgMatriculas
            // 
            this.dvgMatriculas.AllowUserToAddRows = false;
            this.dvgMatriculas.AllowUserToDeleteRows = false;
            this.dvgMatriculas.AutoGenerateColumns = false;
            this.dvgMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.alunoNomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn});
            this.dvgMatriculas.DataSource = this.alunoBindingSource;
            this.dvgMatriculas.Enabled = false;
            this.dvgMatriculas.Location = new System.Drawing.Point(15, 53);
            this.dvgMatriculas.Name = "dvgMatriculas";
            this.dvgMatriculas.ReadOnly = true;
            this.dvgMatriculas.RowHeadersVisible = false;
            this.dvgMatriculas.RowTemplate.Height = 25;
            this.dvgMatriculas.Size = new System.Drawing.Size(686, 150);
            this.dvgMatriculas.TabIndex = 1;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculaDataGridViewTextBoxColumn.Width = 75;
            // 
            // alunoNomeDataGridViewTextBoxColumn
            // 
            this.alunoNomeDataGridViewTextBoxColumn.DataPropertyName = "AlunoNome";
            this.alunoNomeDataGridViewTextBoxColumn.HeaderText = "AlunoNome";
            this.alunoNomeDataGridViewTextBoxColumn.Name = "alunoNomeDataGridViewTextBoxColumn";
            this.alunoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.alunoNomeDataGridViewTextBoxColumn.Width = 378;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 67;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 75;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn.Width = 88;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(ProjetoApresentação.Aluno);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(15, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(587, 23);
            this.txtPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Location = new System.Drawing.Point(607, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 25);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(508, 209);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 25);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Location = new System.Drawing.Point(607, 209);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 25);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.dvgMatriculas);
            this.groupBox1.Location = new System.Drawing.Point(4, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpxNovoAluno);
            this.Name = "Form";
            this.Text = "EscolarManager - Cadastro de Aluno";
            this.Load += new System.EventHandler(this.form_Load);
            this.gpxNovoAluno.ResumeLayout(false);
            this.gpxNovoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatriculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gpxNovoAluno;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtMatricula;
        private Label lblMatricula;
        private MaskedTextBox mktData;
        private Label label2;
        private Button btnAdicionar;
        private TextBox txtCpf;
        private Button btnLimpar;
        private Label lblCpf;
        private Label lblSexo;
        private DataGridView dvgMatriculas;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnExcluir;
        private GroupBox groupBox1;
        private BindingSource alunoBindingSource;
        private ComboBox cmbSexo;
        private DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alunoNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
    }
}