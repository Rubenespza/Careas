using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areas_figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            CFiguras a = new CFiguras();
            decimal resultado = a.Cuadrado(numDato.Value);
            lblFigura.Text = resultado + "";

        }

        private void btnArea2_Click(object sender, EventArgs e)
        {
            CFiguras a = new CFiguras();
            decimal resultado = a.Triangulo(numDato.Value, numDato2.Value);
            lblFigura2.Text = resultado + "";

        }

        private void btnArea3_Click(object sender, EventArgs e)
        {
            CFiguras a = new CFiguras();
            decimal resultado = a.Rectangulo(numDato2.Value, numDato3.Value);
            lblFigura3.Text = resultado + "";
        }

        private void btnArea4_Click(object sender, EventArgs e)
        {
            CFiguras a = new CFiguras();
            decimal resultado = a.Rombo(numDato3.Value, numDato4.Value);
            lblFigura4.Text = resultado + "";
        }

        private void btnArea5_Click(object sender, EventArgs e)
        {
            CFiguras a = new CFiguras();
            decimal resultado = a.Romboide(numDato4.Value, numDato5.Value);
            lblFigura5.Text = resultado + "";
        }

        private void btnArea6_Click(object sender, EventArgs e)
        {
            CFiguras a = new CFiguras();
            decimal resultado = a.Trapecio(numDato4.Value, numDato5.Value, numDato6.Value);
            lblFigura6.Text = resultado + "";
      
        }

        private void btnArea7_Click(object sender, EventArgs e)
        {
            CFiguras a = new CFiguras();
            decimal resultado = a.Circulo(numDato7.Value);
            lblFigura7.Text = resultado + "";
        }

        private void btnArea8_Click(object sender, EventArgs e)
        {
            CFiguras a = new CFiguras();
            decimal resultado = a.Poligono(numDato7.Value, numDato9.Value);
            lblFigura8.Text = resultado + "";
        }
    }
}
