using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste1.CLASSES;

namespace teste1
{
    public partial class Form1 : Form
    {
        CRUD comando = new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_SALVAR_Click(object sender, EventArgs e)
        {
            

            TXT_NOME.Text = comando.select("NOME");
            TXT_DESCRICAO.Text = comando.select("DESCRICAO");
        }

        private void BTN_INSERIR_Click(object sender, EventArgs e)
        {
            comando.insert_magia(TXT_NOME.Text, TXT_DESCRICAO.Text, TXT_TIPO_MAG.Text, TXT_CUSTO_MAG.Text, TXT_CALCULO_DANO.Text, TXT_ATRIBUTO.Text, TXT_ELEMENTO.Text, TXT_EFEITO.Text, TXT_CHANCE_EFEITO.Text, TXT_AREA_ALVO.Text);
            MessageBox.Show("Sua Magia foi cadastrada com sucesso");
            TXT_NOME.Text = "";
            TXT_DESCRICAO.Text = ""; 
            TXT_TIPO_MAG.Text = ""; 
            TXT_CUSTO_MAG.Text = "";
            TXT_CALCULO_DANO.Text = ""; 
            TXT_ATRIBUTO.Text = "";
            TXT_ELEMENTO.Text = "";
            TXT_EFEITO.Text = "";
            TXT_CHANCE_EFEITO.Text = "";
            TXT_AREA_ALVO.Text = "";

        }
    }
}
