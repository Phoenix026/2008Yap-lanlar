using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //TEXTBOXLAR

            TextBox tb_Selam = new TextBox();
            
            tb_Selam.Size = new Size(130, 60);
            tb_Selam.Location = new Point(460, 35);
            this.Controls.Add(tb_Selam);

            TextBox tb_Selamın = new TextBox();
            tb_Selamın.Size = new Size(130, 55);
            tb_Selamın.Location = new Point(460, 65);
            this.Controls.Add(tb_Selamın);

            TextBox tb_Sa = new TextBox();
            tb_Sa.Size = new Size(130, 60);
            tb_Sa.Location = new Point(460, 95);
            this.Controls.Add(tb_Sa);

            //LABELLER

            this.label1.ForeColor = System.Drawing.Color.DarkGreen;

            Label lbl_Selam = new Label();
            lbl_Selam.Size = new Size(100, 20);
            lbl_Selam.Location = new Point(430, 35);
            lbl_Selam.Text = "Ad:";
            this.Controls.Add(lbl_Selam);

            Label lbl_Aleyküm = new Label();
            lbl_Aleyküm.Size = new Size(100, 20);
            lbl_Aleyküm.Location = new Point(400, 65);
            lbl_Aleyküm.Text = "Soyad:";
            this.Controls.Add(lbl_Aleyküm);
            
            Label lbl_As = new Label();
            lbl_As.Size = new Size(100, 20);
            lbl_As.Location = new Point(365, 95);
            lbl_As.Text = "TC Kimlik No:";
            this.Controls.Add(lbl_As);

            Label lbl_Selams = new Label();
            lbl_Selams.Size = new Size(100, 20);
            lbl_Selams.Location = new Point(430, 120);
            lbl_Selams.Text = "Yaş:";
            this.Controls.Add(lbl_Selams);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
