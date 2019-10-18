using System;
using System.Windows.Forms;

namespace ProjAtendimento
{
    public partial class Form1 : Form
    {
        private Guiches filaGuiches;
        private Senhas filaSenhas;
        
        public Form1()
        {
            InitializeComponent();
            filaGuiches = new Guiches();
            filaSenhas = new Senhas();
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            filaSenhas.gerar();
            MessageBox.Show("Senha gerada com sucesso");
            
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            filaGuiches.adicionar(new Guiche(filaGuiches.ListaGuiches.Count+1));
            labelQtd.Text = filaGuiches.ListaGuiches.Count.ToString();
        }

        private void buttonChamar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxChamar.Text) <= filaGuiches.ListaGuiches.Count)
                    filaGuiches.ListaGuiches[int.Parse(textBoxChamar.Text) - 1].chamar(filaSenhas.FilaSenhas);
                else
                    MessageBox.Show("Erro");
            }
            catch(Exception erro)
            {
               MessageBox.Show("Erro");
            }
            
        }

        private void buttonListarAtendimentos_Click(object sender, EventArgs e)
        {
            listBoxChamar.Items.Clear();
            if (int.Parse(textBoxChamar.Text) <= filaGuiches.ListaGuiches.Count)
                foreach(Senha s in filaGuiches.ListaGuiches[int.Parse(textBoxChamar.Text) - 1].Atendimentos)
                    listBoxChamar.Items.Add(s.dadosCompletos());
        }

        private void buttonListarSenhas_Click(object sender, EventArgs e)
        {
            listBoxSenha.Items.Clear();
            foreach (Senha s in filaSenhas.FilaSenhas)
            {
                listBoxSenha.Items.Add(s.dadosParciais());
            }
        }

    }
}
