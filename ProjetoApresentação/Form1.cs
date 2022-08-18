using System.ComponentModel;

namespace ProjetoApresentação
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            leituraSource.DataSource = alunos;
            dvgMatriculas.DataSource = leituraSource;
        }

        private IList<Aluno> alunos = new BindingList<Aluno>();
        private BindingSource leituraSource = new BindingSource();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidacaoAluno())
            {
                return;
            }
            EnumeradorSexo Sexo = (EnumeradorSexo)cmbSexo.SelectedValue;
            CadastarAluno(Convert.ToInt32(txtMatricula.Text), txtNome.Text, Sexo, Convert.ToDateTime(mktData.Text));          
        }
        private void CadastarAluno(int numMatricula, string alunoNome, EnumeradorSexo Sexo, DateTime dataNascimento)
        {
            Aluno aluno = new(numMatricula, alunoNome, Sexo, dataNascimento);
            if (txtCpf.Text == string.Empty)
            {
                aluno.CPF = txtCpf.Text;
            }
            else
            {
                aluno.CPF = Utilitarios.FormatCPF((CPF)txtCpf.Text);
            }
            
            var cpfIgual = alunos.Where(c => c.CPF.Equals(aluno.CPF)).Any();
            var matriculaIgual = alunos.Where(c => c.Matricula.Equals(numMatricula)).Any();

            if (matriculaIgual)
            {
                MessageBox.Show("Matricula ja cadastrada ", "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return;
            }
            if (cpfIgual && aluno.CPF != "")
            {
                MessageBox.Show("CPF ja cadastrado", "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }
            else
            {
                LimparDadosAluno();
                this.alunos.Add(aluno);
            }
        }
        //Configurando botão Limpar
        private void LimparDadosAluno()
        {
            txtMatricula.Clear();
            txtNome.Clear();
            cmbSexo.SelectedIndex = -1;
            txtCpf.Clear();
            mktData.Clear();
            txtMatricula.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDadosAluno();
        }
        //Validação do Aluno
        private bool ValidacaoAluno()
        {
            if (txtMatricula.Text == string.Empty)
            {
                MessageBox.Show("E necessario informar Matricula", "Alerta",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return false;
            }
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("E necessario informar Nome", "Alerta",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            try
            {
                DateTime dataAtual = DateTime.Now;
                DateTime nascimento = Convert.ToDateTime(mktData.Text);
                if (nascimento.Year < 1850  )
                {
                    MessageBox.Show("E necessario informar Uma Data Maior que 1850", "Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                    mktData.Focus();
                    return false;
                }
                if(nascimento > dataAtual)
                {
                    MessageBox.Show("Não e possivel informa uma data maior que a data atual", "Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                    mktData.Focus();
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("E necessario informar Uma Data", "Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                mktData.Focus();
                return false;
            }
            if (txtCpf.Text != string.Empty)
            {
                string cpf = txtCpf.Text;
                CPF cPF = (CPF)cpf;
                if (cPF == "Invalido")
                {
                    MessageBox.Show("E necessario informar um CPF valido ", "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return false;
                }
               
                
            }
            return true;
           
        }
        //Preenchendo Enum Sexo
        private void PreencherCombobox()
        {
            cmbSexo.DisplayMember = "Description";
            cmbSexo.ValueMember = "Value";
            cmbSexo.DataSource = Enum.GetValues(typeof(EnumeradorSexo)).Cast<EnumeradorSexo>();
         }
        private void form_Load(object sender, EventArgs e)
        {
            PreencherCombobox();
            cmbSexo.SelectedIndex = -1;
            
        }
        //Controle de Caracteres
        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //private void dvgMatriculas_SelectionChanged(object sender, EventArgs e)
        //{

        //    txtMatricula.Text = dvgMatriculas.CurrentRow.Cells[0].
        //    Value.ToString();
        //    txtNome.Text = dvgMatriculas.CurrentRow.Cells[1].
        //    Value.ToString();
        //    cmbSexo.Text = dvgMatriculas.CurrentRow.Cells[2].
        //    Value.ToString();
        //}

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtMatricula.Enabled = false;
            txtMatricula.Text = dvgMatriculas.CurrentRow.Cells[0].
            Value.ToString();
            txtNome.Text = dvgMatriculas.CurrentRow.Cells[1].
            Value.ToString();
            cmbSexo.Text = dvgMatriculas.CurrentRow.Cells[2].
            Value.ToString();
            mktData.Text = dvgMatriculas.CurrentRow.Cells[3].Value.ToString();
            if (txtCpf.Text != string.Empty) {
                txtCpf.Text = dvgMatriculas.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            btnAdicionar_Click(sender, e);
        }
    }
}