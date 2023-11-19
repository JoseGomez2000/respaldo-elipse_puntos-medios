using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace elipse_puntos_medios
{
    public partial class Form1 : Form
    {
        private Elipse miElipse;
        public Form1()
        {
            InitializeComponent();
             miElipse = new Elipse(0, 0, 80, 60);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_graficar_Click(object sender, EventArgs e)
        {
            int xc = int.Parse(txt_cX.Text);
            int yc = int.Parse(txt_cY.Text);
            int rx = int.Parse(txt_RX.Text);
            int ry = int.Parse(txt_RY.Text);

            // Crea una instancia de Elipse y pásale los valores
            Elipse obj_elipse = new Elipse(xc, yc, rx, ry);

            // Dibuja la elipse
            obj_elipse.graficarElipse(pb_grafico, txt_P1K, txt_p2k, txt_XK1, txt_YK1, txt_XK2, txt_YK2, txt_x2, txt_y2, txt_x3, txt_y3, txt_x4, txt_y4);
        }

        private void pb_grafica_Click(object sender, EventArgs e)
        {

        }

        private void txt_y4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void txt_x4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void txt_y3_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_x3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void txt_y2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_x2_TextChanged(object sender, EventArgs e)
        {
        }

        private void pb_grafico_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_RX.Clear();
            txt_RY.Clear();
            txt_cX.Clear();
            txt_cY.Clear();
            txt_P1K.Clear();
            txt_XK1.Clear();
            txt_YK1.Clear();
            txt_p2k.Clear();
            txt_XK2.Clear();
            txt_YK2.Clear();
            txt_x2.Clear();
            txt_x3.Clear();
            txt_x4.Clear();
            txt_y2.Clear();
            txt_y3.Clear();
            txt_y4.Clear();

        }

        private void btn_tras_Click(object sender, EventArgs e)
        {
            miElipse.trasladarElipse(100, 150);
            miElipse.graficarElipse(pb_grafico, txt_P1K, txt_p2k, txt_XK1, txt_YK1, txt_XK2, txt_YK2, txt_x2, txt_y2, txt_x3, txt_y3, txt_x4, txt_y4);


        }

        private void btn_relle_Click(object sender, EventArgs e)
        {


        }
    }
}