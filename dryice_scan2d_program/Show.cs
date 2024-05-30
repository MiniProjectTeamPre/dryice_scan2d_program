using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dryice_scan2d_program {
    public partial class Show : Form {
        public Show() {
            InitializeComponent();
            string[] fff = File.ReadAllLines("dryice_scan2d_progarm_show.txt");
            File.Delete("dryice_scan2d_progarm_show.txt");
            PictureBox p = new PictureBox();
            Label lll = new Label();
            for (int i = 0; i < 10; i++) {
                switch (i) {
                    case 0: p = pb_1; lll = lb_1; break;
                    case 1: p = pb_2; lll = lb_2;break;
                    case 2: p = pb_3; lll = lb_3;break;
                    case 3: p = pb_4; lll = lb_4;break;
                    case 4: p = pb_5; lll = lb_5;break;
                    case 5: p = pb_6; lll = lb_6;break;
                    case 6: p = pb_7; lll = lb_7;break;
                    case 7: p = pb_8; lll = lb_8;break;
                    case 8: p = pb_9; lll = lb_9; break;
                    case 9: p = pb_10; lll = lb_10; break;
                }
                if ((i % 2) == 1) {
                    if (fff[i] == "PASS") p.Image = Properties.Resources.dryice_depanel2;
                    else {
                        p.Image = Properties.Resources.dryice_depanel2_fail;
                        lll.ForeColor = Color.White;
                    }
                } else {
                    if (fff[i] == "PASS") p.Image = Properties.Resources.dryice_depanel;
                    else {
                        p.Image = Properties.Resources.dryice_depanel_fail;
                        lll.ForeColor = Color.White;
                    }
                }
            }
            lb_1.Text = "1";
            lb_1.Location = pb_1.PointToClient(lb_1.Parent.PointToScreen(lb_1.Location));
            lb_1.Parent = pb_1;
            lb_1.BackColor = Color.Transparent;
            lb_2.Text = "2";
            lb_2.Location = pb_2.PointToClient(lb_2.Parent.PointToScreen(lb_2.Location));
            lb_2.Parent = pb_2;
            lb_2.BackColor = Color.Transparent;
            lb_3.Text = "3";
            lb_3.Location = pb_3.PointToClient(lb_3.Parent.PointToScreen(lb_3.Location));
            lb_3.Parent = pb_3;
            lb_3.BackColor = Color.Transparent;
            lb_4.Text = "4";
            lb_4.Location = pb_4.PointToClient(lb_4.Parent.PointToScreen(lb_4.Location));
            lb_4.Parent = pb_4;
            lb_4.BackColor = Color.Transparent;
            lb_5.Text = "5";
            lb_5.Location = pb_5.PointToClient(lb_5.Parent.PointToScreen(lb_5.Location));
            lb_5.Parent = pb_5;
            lb_5.BackColor = Color.Transparent;
            lb_6.Text = "6";
            lb_6.Location = pb_6.PointToClient(lb_6.Parent.PointToScreen(lb_6.Location));
            lb_6.Parent = pb_6;
            lb_6.BackColor = Color.Transparent;
            lb_7.Text = "7";
            lb_7.Location = pb_7.PointToClient(lb_7.Parent.PointToScreen(lb_7.Location));
            lb_7.Parent = pb_7;
            lb_7.BackColor = Color.Transparent;
            lb_8.Text = "8";
            lb_8.Location = pb_8.PointToClient(lb_8.Parent.PointToScreen(lb_8.Location));
            lb_8.Parent = pb_8;
            lb_8.BackColor = Color.Transparent;
            lb_9.Text = "9";
            lb_9.Location = pb_9.PointToClient(lb_9.Parent.PointToScreen(lb_9.Location));
            lb_9.Parent = pb_9;
            lb_9.BackColor = Color.Transparent;
            lb_10.Text = "10";
            lb_10.Location = pb_10.PointToClient(lb_10.Parent.PointToScreen(lb_10.Location));
            lb_10.Parent = pb_10;
            lb_10.BackColor = Color.Transparent;
        }

        private void Show_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
