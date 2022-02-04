using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_Expresso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void casquinhabutton1_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(casquinha_label.Text) + 1;
            casquinha_label.Text = Convert.ToString(quantidade);

            int total_itens = Convert.ToInt32(Total_itenslabel.Text) + 1;
            Total_itenslabel.Text = Convert.ToString(total_itens);

            if (quantidade > 0)
            {                       
                double preco = Convert.ToDouble(Preco_casquinhalabel.Text) + 3.50;
                Preco_casquinhalabel.Text = Convert.ToString(preco);
                Preco_casquinhalabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) + 3.50;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);

            }


        }

        private void casquinha_label2_Click(object sender, EventArgs e)
        {

        }

        private void Cascaolabel_Click(object sender, EventArgs e)
        {

        }

        private void Cascaobutton1_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Cascaolabel.Text) + 1;
            Cascaolabel.Text = Convert.ToString(quantidade);

            int total_itens = Convert.ToInt32(Total_itenslabel.Text) + 1;
            Total_itenslabel.Text = Convert.ToString(total_itens);

            if (quantidade > 0)
            {
                double preco = Convert.ToDouble(Preco_cascaolabel.Text) + 5.00;
                Preco_cascaolabel.Text = Convert.ToString(preco);
                Preco_cascaolabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) + 5.00;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);
            }
        }

        private void Sundaebutton1_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Sundaelabel.Text) + 1;
            Sundaelabel.Text = Convert.ToString(quantidade);

            int total_itens = Convert.ToInt32(Total_itenslabel.Text) + 1;
            Total_itenslabel.Text = Convert.ToString(total_itens);

            if (quantidade > 0)
            {
                double preco = Convert.ToDouble(Preco_sundaelabel.Text) + 7.00;
                Preco_sundaelabel.Text = Convert.ToString(preco);
                Preco_sundaelabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) + 7.00;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);
            }
        }

        private void Flurrybutton1_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Flurrylabel.Text) + 1;
            Flurrylabel.Text = Convert.ToString(quantidade);

            int total_itens = Convert.ToInt32(Total_itenslabel.Text) + 1;
            Total_itenslabel.Text = Convert.ToString(total_itens);

            if (quantidade > 0)
            {
                double preco = Convert.ToDouble(Preco_Furrylabel.Text) + 12.00;
                Preco_Furrylabel.Text = Convert.ToString(preco);
                Preco_Furrylabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) + 12.00;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);
            }

        }

        private void Açaibutton1_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Acailabel.Text) + 1;
            Acailabel.Text = Convert.ToString(quantidade);

            int total_itens = Convert.ToInt32(Total_itenslabel.Text) + 1;
            Total_itenslabel.Text = Convert.ToString(total_itens);

            if (quantidade > 0)
            {
                double preco = Convert.ToDouble(Preco_acailabel.Text) + 12.00;
                Preco_acailabel.Text = Convert.ToString(preco);
                Preco_acailabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) + 12.00;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);
            }

        }

        private void Totalitenslabel2_Click(object sender, EventArgs e)
        {
            

        }

        private void Casquinhabutton2_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(casquinha_label.Text);
            if (quantidade > 0)
            {
                quantidade = quantidade - 1;
                casquinha_label.Text = Convert.ToString(quantidade);

                int total_itens = Convert.ToInt32(Total_itenslabel.Text) - 1;
                Total_itenslabel.Text = Convert.ToString(total_itens);

                double preco = Convert.ToDouble(Preco_casquinhalabel.Text) - 3.50;
                Preco_casquinhalabel.Text = Convert.ToString(preco);
                Preco_casquinhalabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) - 3.50;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);

            }

        }

        private void Cascaobutton2_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Cascaolabel.Text);
            if (quantidade > 0)
            {
                quantidade = quantidade - 1;
                Cascaolabel.Text = Convert.ToString(quantidade);

                int total_itens = Convert.ToInt32(Total_itenslabel.Text) -1;
                Total_itenslabel.Text = Convert.ToString(total_itens);

                double preco = Convert.ToDouble(Preco_cascaolabel.Text) - 5.00;
                Preco_cascaolabel.Text = Convert.ToString(preco);
                Preco_cascaolabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) - 5.00;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);
            }

        }

        private void Sundaebutton2_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Sundaelabel.Text);
            if (quantidade > 0)
            {
                quantidade = quantidade - 1;
                Sundaelabel.Text = Convert.ToString(quantidade);

                int total_itens = Convert.ToInt32(Total_itenslabel.Text) - 1;
                Total_itenslabel.Text = Convert.ToString(total_itens);

                double preco = Convert.ToDouble(Preco_sundaelabel.Text) - 7.00;
                Preco_sundaelabel.Text = Convert.ToString(preco);
                Preco_sundaelabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) - 7.00;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);
            }
        }

        private void Flurrybutton2_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Flurrylabel.Text);
            if (quantidade > 0)
            {
                quantidade = quantidade - 1;
                Flurrylabel.Text = Convert.ToString(quantidade);

                int total_itens = Convert.ToInt32(Total_itenslabel.Text) - 1;
                Total_itenslabel.Text = Convert.ToString(total_itens);

                double preco = Convert.ToDouble(Preco_Furrylabel.Text) - 12.00;
                Preco_Furrylabel.Text = Convert.ToString(preco);
                Preco_Furrylabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) - 12.00;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);
            }

        }

        private void Açaibutton2_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Acailabel.Text);
            if (quantidade > 0)
            {
                quantidade = quantidade - 1;
                Acailabel.Text = Convert.ToString(quantidade);

                int total_itens = Convert.ToInt32(Total_itenslabel.Text) -1;
                Total_itenslabel.Text = Convert.ToString(total_itens);

                double preco = Convert.ToDouble(Preco_acailabel.Text) - 12.00;
                Preco_acailabel.Text = Convert.ToString(preco);
                Preco_acailabel.Text = String.Format("{0:N}", preco);

                double total_pedido = Convert.ToDouble(Total_pedidolabel.Text) - 12.00;
                Total_pedidolabel.Text = Convert.ToString(total_pedido);
                Total_pedidolabel.Text = String.Format("{0:N}", total_pedido);
            }
        }

        private void Totalpedidolabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
