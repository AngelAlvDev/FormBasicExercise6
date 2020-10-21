using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBasicExercise6
{
    public partial class FormBasicExercise6 : Form
    {
        public FormBasicExercise6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void colaButton_Click(object sender, EventArgs e)
        {
            String producto = "refresco sabor cola";
            Double precio = 1.50;
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            if(precio <= importe)
            {
                MessageBox.Show("Ha comprado un " + producto);
                importeDevuletoLabel.Text = Convert.ToString(importe - precio);
                importeIntroducidoLabel.Text = Convert.ToString(0);
                importeRestanteLabel.Text = Convert.ToString(0);
                precioLabel.Text = Convert.ToString(0);
            }
            else
            {
                precioLabel.Text = Convert.ToString(precio);
                importeRestanteLabel.Text = Convert.ToString(precio - importe);
            }
        }

        private void euros2Button_Click(object sender, EventArgs e)
        {
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            importe += 2;
            importeIntroducidoLabel.Text = Convert.ToString(importe);
            if (Convert.ToDouble(importeRestanteLabel.Text) != 0)
            {
                importeRestanteLabel.Text = Convert.ToString(Convert.ToDouble(precioLabel.Text) - importe);
                if (Convert.ToDouble(importeRestanteLabel.Text) < 0)
                {
                    importeRestanteLabel.Text = Convert.ToString(0);
                }
            }
        }

        private void euro1Button_Click(object sender, EventArgs e)
        {
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            importe += 1;
            importeIntroducidoLabel.Text = Convert.ToString(importe);
            if (Convert.ToDouble(importeRestanteLabel.Text) != 0)
            {
                importeRestanteLabel.Text = Convert.ToString(Convert.ToDouble(precioLabel.Text) - importe);
                if (Convert.ToDouble(importeRestanteLabel.Text) < 0)
                {
                    importeRestanteLabel.Text = Convert.ToString(0);
                }
            }
        }

        private void cent50Button_Click(object sender, EventArgs e)
        {
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            importe += 0.5;
            importeIntroducidoLabel.Text = Convert.ToString(importe);
            if (Convert.ToDouble(importeRestanteLabel.Text) != 0)
            {
                importeRestanteLabel.Text = Convert.ToString(Convert.ToDouble(precioLabel.Text) - importe);
                if (Convert.ToDouble(importeRestanteLabel.Text) < 0)
                {
                    importeRestanteLabel.Text = Convert.ToString(0);
                }
            }
        }

        private void cent20Button_Click(object sender, EventArgs e)
        {
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            importe += 0.2;
            importeIntroducidoLabel.Text = Convert.ToString(importe);
            if (Convert.ToDouble(importeRestanteLabel.Text) != 0)
            {
                importeRestanteLabel.Text = Convert.ToString(Convert.ToDouble(precioLabel.Text) - importe);
                if (Convert.ToDouble(importeRestanteLabel.Text) < 0)
                {
                    importeRestanteLabel.Text = Convert.ToString(0);
                }
            }
        }

        private void cent10Button_Click(object sender, EventArgs e)
        {
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            importe += 0.1;
            importeIntroducidoLabel.Text = Convert.ToString(importe);
            if (Convert.ToDouble(importeRestanteLabel.Text) != 0)
            {
                importeRestanteLabel.Text = Convert.ToString(Convert.ToDouble(precioLabel.Text) - importe);
                if (Convert.ToDouble(importeRestanteLabel.Text) < 0)
                {
                    importeRestanteLabel.Text = Convert.ToString(0);
                }
            }
        }

        private void cent5Button_Click(object sender, EventArgs e)
        {
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            importe += 0.05;
            importeIntroducidoLabel.Text = Convert.ToString(importe);
            if (Convert.ToDouble(importeRestanteLabel.Text) != 0)
            {
                importeRestanteLabel.Text = Convert.ToString(Convert.ToDouble(precioLabel.Text) - importe);
                if (Convert.ToDouble(importeRestanteLabel.Text) < 0)
                {
                    importeRestanteLabel.Text = Convert.ToString(0);
                }
            }
        }

        private void devolverButton_Click(object sender, EventArgs e)
        {
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            importeIntroducidoLabel.Text = Convert.ToString(0);
            importeDevuletoLabel.Text = Convert.ToString(importe);
            precioLabel.Text = Convert.ToString(0);
        }

        private void ligthButton_Click(object sender, EventArgs e)
        {
            String producto = "refresco sabor cola ligth";
            Double precio = 1.50;
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            if (precio <= importe)
            {
                MessageBox.Show("Ha comprado un " + producto);
                importeDevuletoLabel.Text = Convert.ToString(importe - precio);
                importeIntroducidoLabel.Text = Convert.ToString(0);
                importeRestanteLabel.Text = Convert.ToString(0);
                precioLabel.Text = Convert.ToString(0);
            }
            else
            {
                importeRestanteLabel.Text = Convert.ToString(precio - importe);
                precioLabel.Text = Convert.ToString(precio);
            }
        }

        private void naranjaButton_Click(object sender, EventArgs e)
        {
            String producto = "refresco sabor naranja";
            Double precio = 1.30;
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            if (precio <= importe)
            {
                MessageBox.Show("Ha comprado un " + producto);
                importeDevuletoLabel.Text = Convert.ToString(importe - precio);
                importeIntroducidoLabel.Text = Convert.ToString(0);
                importeRestanteLabel.Text = Convert.ToString(0);
                precioLabel.Text = Convert.ToString(0);
            }
            else
            {
                importeRestanteLabel.Text = Convert.ToString(precio - importe);
                precioLabel.Text = Convert.ToString(precio);
            }
        }

        private void limonButton_Click(object sender, EventArgs e)
        {
            String producto = "refresco sabor limón";
            Double precio = 1.30;
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            if (precio <= importe)
            {
                MessageBox.Show("Ha comprado un " + producto);
                importeDevuletoLabel.Text = Convert.ToString(importe - precio);
                importeIntroducidoLabel.Text = Convert.ToString(0);
                importeRestanteLabel.Text = Convert.ToString(0);
                precioLabel.Text = Convert.ToString(0);
            }
            else
            {
                importeRestanteLabel.Text = Convert.ToString(precio - importe);
                precioLabel.Text = Convert.ToString(precio);
            }
        }

        private void limaButton_Click(object sender, EventArgs e)
        {
            String producto = "refresco sabor lima";
            Double precio = 1.30;
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            if (precio <= importe)
            {
                MessageBox.Show("Ha comprado un " + producto);
                importeDevuletoLabel.Text = Convert.ToString(importe - precio);
                importeIntroducidoLabel.Text = Convert.ToString(0);
                importeRestanteLabel.Text = Convert.ToString(0);
                precioLabel.Text = Convert.ToString(0);
            }
            else
            {
                importeRestanteLabel.Text = Convert.ToString(precio - importe);
                precioLabel.Text = Convert.ToString(precio);
            }
        }

        private void aguaButton_Click(object sender, EventArgs e)
        {
            String producto = "agua";
            Double precio = 1.00;
            Double importe = Convert.ToDouble(importeIntroducidoLabel.Text);
            if (precio <= importe)
            {
                MessageBox.Show("Ha comprado un " + producto);
                importeDevuletoLabel.Text = Convert.ToString(importe - precio);
                importeIntroducidoLabel.Text = Convert.ToString(0);
                importeRestanteLabel.Text = Convert.ToString(0);
                precioLabel.Text = Convert.ToString(0);
            }
            else
            {
                importeRestanteLabel.Text = Convert.ToString(precio - importe);
                precioLabel.Text = Convert.ToString(precio);
            }
        }
    }
}
