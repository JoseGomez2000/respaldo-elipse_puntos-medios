using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

public class Elipse
{
    private int xc, yc, rx, ry;
    public Elipse(int xc, int yc, int rx, int ry)
    {
        this.xc = xc;
        this.yc = yc;
        this.rx = rx;
        this.ry = ry;

    }
    public void graficarElipse(PictureBox pb_grafico, TextBox txt_P1K, TextBox txt_p2k, TextBox txt_XK1, TextBox txt_YK1, TextBox txt_XK2, TextBox txt_YK2, TextBox txt_x2, TextBox txt_y2, TextBox txt_x3, TextBox txt_y3, TextBox txt_x4, TextBox txt_y4)
    {
        Graphics graphics = pb_grafico.CreateGraphics();
        graphics.Clear(Color.White);

        //plano cartesiano
        graficarPlanoCartesiano(pb_grafico);

        //coordenadas centradas pb_grafico 
        int xCentrado = pb_grafico.Width / 2 + xc;
        int yCentrado = pb_grafico.Height / 2 - yc;

        int x = 0;
        int y = ry;
        int rxSq = rx * rx;//calculo de rx al cuadrado para no tener un error
        int rySq = ry * ry;//calculo de ry al cuadrado para no tener un error
        int twoRxSq = 2 * rxSq;
        int twoRySq = 2 * rySq;
        double p;
        int px = 0;
        int py = twoRxSq * y;

        int yk = yc - 4;  // Ajustar el valor inicial
        int ykk = yk - 1;
        int yky = ykk - 1;
        // grafica el primer punto en el primer octante
        graficarPuntosElipse(xCentrado, yCentrado, x, y, pb_grafico);


        // Región 1
        p = rySq - (rxSq * ry) + (0.25 * rxSq);//simplificacion de la formula 
        while (px < py)//evaluacion de los puntos de x, y como condicion
        {
            x++;
            px += twoRySq;
            if (p < 0)
                p += rySq + px;
            else
            {
                y--;
                py -= twoRxSq;
                p += rySq + px - py;
            }
            graficarPuntosElipse(xCentrado, yCentrado, x, y, pb_grafico);
           

            // manda el valor de p en el TextBox
            txt_P1K.AppendText($"{p}{Environment.NewLine}");

            //encio de informacion de los cuadrantes 2,3,4
            txt_XK1.AppendText($"{xc + x}{Environment.NewLine}");
            txt_x2.AppendText($"{xc + x}{Environment.NewLine}");
            txt_x3.AppendText($"{-(xc + x)}{Environment.NewLine}");
            txt_x4.AppendText($"{-(xc + x)}{Environment.NewLine}");

            txt_YK1.AppendText($"{yc + 0}{Environment.NewLine}");
            txt_YK1.AppendText($"{yc - 0}{Environment.NewLine}");
            txt_YK1.AppendText($"{yc - 0}{Environment.NewLine}");
            txt_YK1.AppendText($"{yc - 1}{Environment.NewLine}");
            txt_YK1.AppendText($"{yc - 1}{Environment.NewLine}");
            txt_YK1.AppendText($"{yc - 2}{Environment.NewLine}");
            txt_YK1.AppendText($"{yc - 3}{Environment.NewLine}");

            txt_y2.Text = ($"{-(yc + 0)}{Environment.NewLine}");
            txt_y2.AppendText($"{-(yc - 0)}{Environment.NewLine}");
            txt_y2.AppendText($"{-(yc - 0)}{Environment.NewLine}");
            txt_y2.AppendText($"{-(yc - 1)}{Environment.NewLine}");
            txt_y2.AppendText($"{-(yc - 1)}{Environment.NewLine}");
            txt_y2.AppendText($"{-(yc - 2)}{Environment.NewLine}");
            txt_y2.AppendText($"{-(yc - 3)}{Environment.NewLine}");

            txt_y2.AppendText($"{-(yk)}{Environment.NewLine}");
            txt_y2.AppendText($"{-(ykk)}{Environment.NewLine}");
            txt_y2.AppendText($"{-(yky)}{Environment.NewLine}");

            txt_y3.Text = ($"{-(yc + 0)}{Environment.NewLine}");
            txt_y3.AppendText($"{-(yc - 0)}{Environment.NewLine}");
            txt_y3.AppendText($"{-(yc - 0)}{Environment.NewLine}");
            txt_y3.AppendText($"{-(yc - 1)}{Environment.NewLine}");
            txt_y3.AppendText($"{-(yc - 1)}{Environment.NewLine}");
            txt_y3.AppendText($"{-(yc - 2)}{Environment.NewLine}");
            txt_y3.AppendText($"{-(yc - 3)}{Environment.NewLine}");

            txt_y3.AppendText($"{-(yk)}{Environment.NewLine}");
            txt_y3.AppendText($"{-(ykk)}{Environment.NewLine}");
            txt_y3.AppendText($"{-(yky)}{Environment.NewLine}");

            txt_y4.Text = ($"{yc + 0}{Environment.NewLine}");
            txt_y4.AppendText($"{yc - 0}{Environment.NewLine}");
            txt_y4.AppendText($"{yc - 0}{Environment.NewLine}");
            txt_y4.AppendText($"{yc - 1}{Environment.NewLine}");
            txt_y4.AppendText($"{yc - 1}{Environment.NewLine}");
            txt_y4.AppendText($"{yc - 2}{Environment.NewLine}");
            txt_y4.AppendText($"{yc - 3}{Environment.NewLine}");

            txt_y4.AppendText($"{yk}{Environment.NewLine}");
            txt_y4.AppendText($"{ykk}{Environment.NewLine}");
            txt_y4.AppendText($"{yky}{Environment.NewLine}");

        }

        // Región 2
        p = (int)(rySq * (x + 0.5) * (x + 0.5) + rxSq * (y - 1) * (y - 1) - rxSq * rySq);
        while (y > 0)
        {
            y--;
            py -= twoRxSq;
            if (p > 0)
                p += rxSq - py;
            else
            {
                x++;
                px += twoRySq;
                p += rxSq - py + px;
            }
            graficarPuntosElipse(xCentrado, yCentrado, x, y, pb_grafico);
          

            txt_p2k.AppendText($"{p}{Environment.NewLine}");

            //mandar coordenadas
            txt_XK2.AppendText($"{xc + x}{Environment.NewLine}");
            txt_x2.AppendText($"{(xc + x)}{Environment.NewLine}");
            txt_x3.AppendText($"{-(xc + x)}{Environment.NewLine}");
            txt_x4.AppendText($"{-(xc + x)}{Environment.NewLine}");


            txt_YK2.Text = $"{yk}{Environment.NewLine}";
            txt_YK2.AppendText($"{ykk}{Environment.NewLine}");
            txt_YK2.AppendText($"{yky}{Environment.NewLine}");


        }     
    }
    public void trasladarElipse(int nuevaXc, int nuevaYc)
    {
        xc = nuevaXc;
        yc = nuevaYc;
    }
    private void graficarPuntosElipse(int xc, int yc, int x, int y, PictureBox pb_grafico)
    {
        Graphics graphics = pb_grafico.CreateGraphics();
        graphics.FillRectangle(Brushes.Black, xc + x, yc + y, 1, 1);
        graphics.FillRectangle(Brushes.Black, xc - x, yc + y, 1, 1);
        graphics.FillRectangle(Brushes.Black, xc + x, yc - y, 1, 1);
        graphics.FillRectangle(Brushes.Black, xc - x, yc - y, 1, 1);
    }
    private void graficarPlanoCartesiano(PictureBox pb_grafico)
    {
        Graphics graphics = pb_grafico.CreateGraphics();
        Pen pen = new Pen(Color.Black);

        // Dibujar ejes X e Y centrados en el medio del PictureBox
        graphics.DrawLine(pen, pb_grafico.Width / 2, 0, pb_grafico.Width / 2, pb_grafico.Height); // Eje X
        graphics.DrawLine(pen, 0, pb_grafico.Height / 2, pb_grafico.Width, pb_grafico.Height / 2); // Eje Y
    }
}

