namespace elipse_puntos_medios
{
    partial class Form1
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
            txt_RX = new TextBox();
            txt_RY = new TextBox();
            lblRX = new Label();
            label1 = new Label();
            lbl_nombre = new Label();
            txt_P1K = new TextBox();
            txt_XK1 = new TextBox();
            txt_YK1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_YK2 = new TextBox();
            txt_XK2 = new TextBox();
            txt_p2k = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txt_y2 = new TextBox();
            txt_x2 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            txt_y3 = new TextBox();
            txt_x3 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            txt_y4 = new TextBox();
            txt_x4 = new TextBox();
            btn_limpiar = new Button();
            btn_graficar = new Button();
            lbl_cY = new Label();
            lbl_cX = new Label();
            txt_cY = new TextBox();
            txt_cX = new TextBox();
            pb_grafico = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btn_tras = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_grafico).BeginInit();
            SuspendLayout();
            // 
            // txt_RX
            // 
            txt_RX.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_RX.ForeColor = Color.Red;
            txt_RX.Location = new Point(145, 68);
            txt_RX.Name = "txt_RX";
            txt_RX.Size = new Size(125, 34);
            txt_RX.TabIndex = 0;
            // 
            // txt_RY
            // 
            txt_RY.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_RY.ForeColor = Color.Red;
            txt_RY.Location = new Point(417, 63);
            txt_RY.Name = "txt_RY";
            txt_RY.Size = new Size(125, 39);
            txt_RY.TabIndex = 6;
            // 
            // lblRX
            // 
            lblRX.AutoSize = true;
            lblRX.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblRX.Location = new Point(13, 75);
            lblRX.Name = "lblRX";
            lblRX.Size = new Size(120, 33);
            lblRX.TabIndex = 7;
            lblRX.Text = "Radio X";
            lblRX.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(291, 66);
            label1.Name = "label1";
            label1.Size = new Size(120, 33);
            label1.TabIndex = 8;
            label1.Text = "Radio Y";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(546, 9);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(315, 33);
            lbl_nombre.TabIndex = 10;
            lbl_nombre.Text = "Grafica de la elipse";
            lbl_nombre.Click += lbl_nombre_Click;
            // 
            // txt_P1K
            // 
            txt_P1K.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_P1K.ForeColor = Color.Red;
            txt_P1K.Location = new Point(9, 298);
            txt_P1K.Multiline = true;
            txt_P1K.Name = "txt_P1K";
            txt_P1K.Size = new Size(83, 246);
            txt_P1K.TabIndex = 12;
            txt_P1K.TextChanged += textBox2_TextChanged;
            // 
            // txt_XK1
            // 
            txt_XK1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_XK1.ForeColor = Color.Red;
            txt_XK1.Location = new Point(117, 298);
            txt_XK1.Multiline = true;
            txt_XK1.Name = "txt_XK1";
            txt_XK1.Size = new Size(74, 246);
            txt_XK1.TabIndex = 13;
            // 
            // txt_YK1
            // 
            txt_YK1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_YK1.ForeColor = Color.Red;
            txt_YK1.Location = new Point(214, 298);
            txt_YK1.Multiline = true;
            txt_YK1.Name = "txt_YK1";
            txt_YK1.Size = new Size(89, 246);
            txt_YK1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 235);
            label2.Name = "label2";
            label2.Size = new Size(60, 33);
            label2.TabIndex = 16;
            label2.Text = "P1K";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 235);
            label3.Name = "label3";
            label3.Size = new Size(75, 33);
            label3.TabIndex = 17;
            label3.Text = "XK+1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(214, 235);
            label4.Name = "label4";
            label4.Size = new Size(75, 33);
            label4.TabIndex = 18;
            label4.Text = "YK-1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(4, 192);
            label5.Name = "label5";
            label5.Size = new Size(345, 33);
            label5.TabIndex = 19;
            label5.Text = "Calculo de la region 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(433, 192);
            label6.Name = "label6";
            label6.Size = new Size(345, 33);
            label6.TabIndex = 20;
            label6.Text = "Calculo de la region 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(651, 253);
            label7.Name = "label7";
            label7.Size = new Size(75, 33);
            label7.TabIndex = 28;
            label7.Text = "YK-1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(547, 253);
            label8.Name = "label8";
            label8.Size = new Size(75, 33);
            label8.TabIndex = 27;
            label8.Text = "XK+1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(459, 253);
            label9.Name = "label9";
            label9.Size = new Size(60, 33);
            label9.TabIndex = 26;
            label9.Text = "P2K";
            // 
            // txt_YK2
            // 
            txt_YK2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_YK2.ForeColor = Color.Red;
            txt_YK2.Location = new Point(651, 316);
            txt_YK2.Multiline = true;
            txt_YK2.Name = "txt_YK2";
            txt_YK2.Size = new Size(75, 149);
            txt_YK2.TabIndex = 24;
            // 
            // txt_XK2
            // 
            txt_XK2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_XK2.ForeColor = Color.Red;
            txt_XK2.Location = new Point(560, 316);
            txt_XK2.Multiline = true;
            txt_XK2.Name = "txt_XK2";
            txt_XK2.Size = new Size(69, 149);
            txt_XK2.TabIndex = 23;
            // 
            // txt_p2k
            // 
            txt_p2k.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_p2k.ForeColor = Color.Red;
            txt_p2k.Location = new Point(459, 316);
            txt_p2k.Multiline = true;
            txt_p2k.Name = "txt_p2k";
            txt_p2k.Size = new Size(72, 149);
            txt_p2k.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(150, 639);
            label14.Name = "label14";
            label14.Size = new Size(45, 33);
            label14.TabIndex = 40;
            label14.Text = "-Y";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(64, 639);
            label15.Name = "label15";
            label15.Size = new Size(30, 33);
            label15.TabIndex = 39;
            label15.Text = "X";
            label15.Click += label15_Click;
            // 
            // txt_y2
            // 
            txt_y2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_y2.ForeColor = Color.Red;
            txt_y2.Location = new Point(146, 702);
            txt_y2.Multiline = true;
            txt_y2.Name = "txt_y2";
            txt_y2.Size = new Size(84, 290);
            txt_y2.TabIndex = 38;
            txt_y2.TextChanged += txt_y2_TextChanged;
            // 
            // txt_x2
            // 
            txt_x2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_x2.ForeColor = Color.Red;
            txt_x2.Location = new Point(44, 702);
            txt_x2.Multiline = true;
            txt_x2.Name = "txt_x2";
            txt_x2.Size = new Size(78, 290);
            txt_x2.TabIndex = 37;
            txt_x2.TextChanged += txt_x2_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(400, 639);
            label16.Name = "label16";
            label16.Size = new Size(45, 33);
            label16.TabIndex = 44;
            label16.Text = "-Y";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(303, 639);
            label17.Name = "label17";
            label17.Size = new Size(45, 33);
            label17.TabIndex = 43;
            label17.Text = "-X";
            label17.Click += label17_Click;
            // 
            // txt_y3
            // 
            txt_y3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_y3.ForeColor = Color.Red;
            txt_y3.Location = new Point(381, 702);
            txt_y3.Multiline = true;
            txt_y3.Name = "txt_y3";
            txt_y3.Size = new Size(81, 290);
            txt_y3.TabIndex = 42;
            txt_y3.TextChanged += txt_y3_TextChanged;
            // 
            // txt_x3
            // 
            txt_x3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_x3.ForeColor = Color.Red;
            txt_x3.Location = new Point(282, 702);
            txt_x3.Multiline = true;
            txt_x3.Name = "txt_x3";
            txt_x3.Size = new Size(76, 290);
            txt_x3.TabIndex = 41;
            txt_x3.TextChanged += txt_x3_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(671, 639);
            label18.Name = "label18";
            label18.Size = new Size(30, 33);
            label18.TabIndex = 48;
            label18.Text = "Y";
            label18.Click += label18_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(565, 639);
            label19.Name = "label19";
            label19.Size = new Size(45, 33);
            label19.TabIndex = 47;
            label19.Text = "-X";
            label19.Click += label19_Click;
            // 
            // txt_y4
            // 
            txt_y4.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_y4.ForeColor = Color.Red;
            txt_y4.Location = new Point(660, 702);
            txt_y4.Multiline = true;
            txt_y4.Name = "txt_y4";
            txt_y4.Size = new Size(90, 290);
            txt_y4.TabIndex = 46;
            txt_y4.TextChanged += txt_y4_TextChanged;
            // 
            // txt_x4
            // 
            txt_x4.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_x4.ForeColor = Color.Red;
            txt_x4.Location = new Point(546, 702);
            txt_x4.Multiline = true;
            txt_x4.Name = "txt_x4";
            txt_x4.Size = new Size(69, 290);
            txt_x4.TabIndex = 45;
            txt_x4.TextChanged += txt_x4_TextChanged;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_limpiar.Location = new Point(572, 61);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(129, 42);
            btn_limpiar.TabIndex = 49;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_graficar
            // 
            btn_graficar.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_graficar.Location = new Point(572, 133);
            btn_graficar.Name = "btn_graficar";
            btn_graficar.Size = new Size(143, 42);
            btn_graficar.TabIndex = 50;
            btn_graficar.Text = "Graficar";
            btn_graficar.UseVisualStyleBackColor = true;
            btn_graficar.Click += btn_graficar_Click;
            // 
            // lbl_cY
            // 
            lbl_cY.AutoSize = true;
            lbl_cY.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cY.Location = new Point(276, 134);
            lbl_cY.Name = "lbl_cY";
            lbl_cY.Size = new Size(135, 33);
            lbl_cY.TabIndex = 54;
            lbl_cY.Text = "Centro Y";
            // 
            // lbl_cX
            // 
            lbl_cX.AutoSize = true;
            lbl_cX.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cX.Location = new Point(4, 141);
            lbl_cX.Name = "lbl_cX";
            lbl_cX.Size = new Size(135, 33);
            lbl_cX.TabIndex = 53;
            lbl_cX.Text = "Centro X";
            // 
            // txt_cY
            // 
            txt_cY.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cY.ForeColor = Color.Red;
            txt_cY.Location = new Point(417, 134);
            txt_cY.Name = "txt_cY";
            txt_cY.Size = new Size(125, 39);
            txt_cY.TabIndex = 52;
            // 
            // txt_cX
            // 
            txt_cX.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cX.ForeColor = Color.Red;
            txt_cX.Location = new Point(145, 138);
            txt_cX.Name = "txt_cX";
            txt_cX.Size = new Size(125, 34);
            txt_cX.TabIndex = 51;
            // 
            // pb_grafico
            // 
            pb_grafico.BackColor = SystemColors.ActiveBorder;
            pb_grafico.Location = new Point(924, 86);
            pb_grafico.Name = "pb_grafico";
            pb_grafico.Size = new Size(941, 816);
            pb_grafico.TabIndex = 55;
            pb_grafico.TabStop = false;
            pb_grafico.Click += pb_grafico_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(44, 581);
            label11.Name = "label11";
            label11.Size = new Size(180, 33);
            label11.TabIndex = 56;
            label11.Text = "Cuadrante 2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(301, 581);
            label12.Name = "label12";
            label12.Size = new Size(180, 33);
            label12.TabIndex = 57;
            label12.Text = "Cuadrante 3";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(546, 581);
            label13.Name = "label13";
            label13.Size = new Size(180, 33);
            label13.TabIndex = 58;
            label13.Text = "Cuadrante 4";
            // 
            // btn_tras
            // 
            btn_tras.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_tras.Location = new Point(732, 61);
            btn_tras.Name = "btn_tras";
            btn_tras.Size = new Size(152, 42);
            btn_tras.TabIndex = 59;
            btn_tras.Text = "trasladar";
            btn_tras.UseVisualStyleBackColor = true;
            btn_tras.Click += btn_tras_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1893, 1021);
            Controls.Add(btn_tras);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pb_grafico);
            Controls.Add(lbl_cY);
            Controls.Add(lbl_cX);
            Controls.Add(txt_cY);
            Controls.Add(txt_cX);
            Controls.Add(btn_graficar);
            Controls.Add(btn_limpiar);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(txt_y4);
            Controls.Add(txt_x4);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(txt_y3);
            Controls.Add(txt_x3);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txt_y2);
            Controls.Add(txt_x2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txt_YK2);
            Controls.Add(txt_XK2);
            Controls.Add(txt_p2k);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_YK1);
            Controls.Add(txt_XK1);
            Controls.Add(txt_P1K);
            Controls.Add(lbl_nombre);
            Controls.Add(label1);
            Controls.Add(lblRX);
            Controls.Add(txt_RY);
            Controls.Add(txt_RX);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb_grafico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_RX;
        private TextBox txt_RY;
        private Label lblRX;
        private Label label1;
        private Label lbl_nombre;
        private TextBox txt_P1K;
        private TextBox txt_XK1;
        private TextBox txt_YK1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_YK2;
        private TextBox txt_XK2;
        private TextBox txt_p2k;
        private Label label14;
        private Label label15;
        private TextBox txt_y2;
        private TextBox txt_x2;
        private Label label16;
        private Label label17;
        private TextBox txt_y3;
        private TextBox txt_x3;
        private Label label18;
        private Label label19;
        private TextBox txt_y4;
        private TextBox txt_x4;
        private Button btn_limpiar;
        private Button btn_graficar;
        private Label lbl_cY;
        private Label lbl_cX;
        private TextBox txt_cY;
        private TextBox txt_cX;
        private PictureBox pb_grafico;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btn_tras;
    }
}