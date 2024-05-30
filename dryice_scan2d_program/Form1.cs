using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dryice_scan2d_program {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            cb_depanel.Location = pb_1.PointToClient(cb_depanel.Parent.PointToScreen(cb_depanel.Location));
            cb_depanel.Parent = pb_1;
            cb_depanel.BackColor = Color.Transparent;
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

        private int sn_cout = 13;
        private string sn_dummy = "xxxxxxxxxxxxx";

        private void Form1_Load(object sender, EventArgs e) {
            tb_1.Text = "";
            tb_2.Text = "";
            tb_3.Text = "";
            tb_4.Text = "";
            tb_5.Text = "";
            tb_6.Text = "";
            tb_7.Text = "";
            tb_8.Text = "";
            tb_9.Text = "";
            tb_10.Text = "";
            for (int i = 1; i <= 10; i++)
                try { File.Delete("dryice_scan2d_program_sn" + i + ".txt"); } catch { }
            try { cb_depanel.Checked = Convert.ToBoolean(File.ReadAllText("../../config/dryice_scan2d_program_depanel.txt")); } catch { }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timer1.Enabled = false;
            tb_1.Focus();
            flag_select = 1;
        }
        private bool flag_scan_full = false;
        private void show_err(string ff = "") {
            Form2 f = new Form2();
            f.label1.Text = ff;
            f.ShowDialog();
        }
        private void tb_1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_1.Text = sn_dummy;
                tb_2.Focus();
                flag_select = 2;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if(tb_1.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_1.Text = "";
                return;
            }
            if (!cb_depanel.Checked) {
                tb_2.Focus();
                flag_select = 2;
            }
        }
        private void tb_2_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_2.Text = sn_dummy;
                tb_3.Focus();
                flag_select = 3;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if (tb_2.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_2.Text = "";
                return;
            }
            tb_3.Focus();
            flag_select = 3;
        }
        private void tb_3_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_3.Text = sn_dummy;
                tb_4.Focus();
                flag_select = 4;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if (tb_3.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_3.Text = "";
                return;
            }
            tb_4.Focus();
            flag_select = 4;
        }
        private void tb_4_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_4.Text = sn_dummy;
                tb_5.Focus();
                flag_select = 5;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if (tb_4.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_4.Text = "";
                return;
            }
            tb_5.Focus();
            flag_select = 5;
        }
        private void tb_5_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_5.Text = sn_dummy;
                tb_6.Focus();
                flag_select = 6;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if (tb_5.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_5.Text = "";
                return;
            }
            tb_6.Focus();
            flag_select = 6;
        }
        private void tb_6_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_6.Text = sn_dummy;
                tb_7.Focus();
                flag_select = 7;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if (tb_6.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_6.Text = "";
                return;
            }
            tb_7.Focus();
            flag_select = 7;
        }
        private void tb_7_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_7.Text = sn_dummy;
                tb_8.Focus();
                flag_select = 8;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if (tb_1.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_1.Text = "";
                return;
            }
            tb_8.Focus();
            flag_select = 8;
        }
        private void tb_8_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_8.Text = sn_dummy;
                tb_9.Focus();
                flag_select = 9;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if (tb_8.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_8.Text = "";
                return;
            }
            tb_9.Focus();
            flag_select = 9;
        }
        private void tb_9_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_9.Text = sn_dummy;
                tb_10.Focus();
                flag_select = 10;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if (tb_9.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_9.Text = "";
                return;
            }
            tb_10.Focus();
            flag_select = 10;
        }
        private void tb_10_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                tb_10.Text = sn_dummy;
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if (tb_10.Text.Length != sn_cout) {
                show_err("SN ไม่เท่ากับ " + sn_cout + " digit");
                tb_10.Text = "";
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e) {
            if (!flag_scan_full) return;
            flag_scan_full = false;
            List<string> sn = new List<string>();
            tb_1.Text = tb_1.Text.Trim();
            tb_2.Text = tb_2.Text.Trim();
            tb_3.Text = tb_3.Text.Trim();
            tb_4.Text = tb_4.Text.Trim();
            tb_5.Text = tb_5.Text.Trim();
            tb_6.Text = tb_6.Text.Trim();
            tb_7.Text = tb_7.Text.Trim();
            tb_8.Text = tb_8.Text.Trim();
            tb_9.Text = tb_9.Text.Trim();
            tb_10.Text = tb_10.Text.Trim();
            if (tb_1.Text != sn_dummy)sn.Add(tb_1.Text);
            if(tb_2.Text != sn_dummy)sn.Add(tb_2.Text);
            if(tb_3.Text != sn_dummy)sn.Add(tb_3.Text);
            if(tb_4.Text != sn_dummy)sn.Add(tb_4.Text);
            if(tb_5.Text != sn_dummy)sn.Add(tb_5.Text);
            if(tb_6.Text != sn_dummy)sn.Add(tb_6.Text);
            if(tb_7.Text != sn_dummy)sn.Add(tb_7.Text);
            if(tb_8.Text != sn_dummy)sn.Add(tb_8.Text);
            if (tb_9.Text != sn_dummy)sn.Add(tb_9.Text);
            if (tb_10.Text != sn_dummy)sn.Add(tb_10.Text);
            if (sn.Count != sn.Distinct().Count()) {
                show_err("ตรวจพบ SN ซ้ำกัน กรุณาสแกนใหม่");
                tb_1.Text = "";
                tb_2.Text = "";
                tb_3.Text = "";
                tb_4.Text = "";
                tb_5.Text = "";
                tb_6.Text = "";
                tb_7.Text = "";
                tb_8.Text = "";
                tb_9.Text = "";
                tb_10.Text = "";
                tb_1.Focus();
                flag_select = 1;
            } else {
                close_form();
                return;
            }
        }

        private void tb_1_DoubleClick(object sender, EventArgs e) {
            tb_1.Text = "";
            tb_2.Text = "";
            tb_3.Text = "";
            tb_4.Text = "";
            tb_5.Text = "";
            tb_6.Text = "";
            tb_7.Text = "";
            tb_8.Text = "";
            tb_9.Text = "";
            tb_10.Text = "";
            flag_select = 1;
        }
        private void tb_2_DoubleClick(object sender, EventArgs e) {
            if (tb_1.Text == "") tb_1.Text = sn_dummy;
            tb_2.Text = "";
            tb_3.Text = "";
            tb_4.Text = "";
            tb_5.Text = "";
            tb_6.Text = "";
            tb_7.Text = "";
            tb_8.Text = "";
            tb_9.Text = "";
            tb_10.Text = "";
            flag_select = 2;
        }
        private void tb_3_DoubleClick(object sender, EventArgs e) {
            if (tb_1.Text == "") tb_1.Text = sn_dummy;
            if (tb_2.Text == "") tb_2.Text = sn_dummy;
            tb_3.Text = "";
            tb_4.Text = "";
            tb_5.Text = "";
            tb_6.Text = "";
            tb_7.Text = "";
            tb_8.Text = "";
            tb_9.Text = "";
            tb_10.Text = "";
            flag_select = 3;
        }
        private void tb_4_DoubleClick(object sender, EventArgs e) {
            if (tb_1.Text == "") tb_1.Text = sn_dummy;
            if (tb_2.Text == "") tb_2.Text = sn_dummy;
            if (tb_3.Text == "") tb_3.Text = sn_dummy;
            tb_4.Text = "";
            tb_5.Text = "";
            tb_6.Text = "";
            tb_7.Text = "";
            tb_8.Text = "";
            tb_9.Text = "";
            tb_10.Text = "";
            flag_select = 4;
        }
        private void tb_5_DoubleClick(object sender, EventArgs e) {
            if (tb_1.Text == "") tb_1.Text = sn_dummy;
            if (tb_2.Text == "") tb_2.Text = sn_dummy;
            if (tb_3.Text == "") tb_3.Text = sn_dummy;
            if (tb_4.Text == "") tb_4.Text = sn_dummy;
            tb_5.Text = "";
            tb_6.Text = "";
            tb_7.Text = "";
            tb_8.Text = "";
            tb_9.Text = "";
            tb_10.Text = "";
            flag_select = 5;
        }
        private void tb_6_DoubleClick(object sender, EventArgs e) {
            if (tb_1.Text == "") tb_1.Text = sn_dummy;
            if (tb_2.Text == "") tb_2.Text = sn_dummy;
            if (tb_3.Text == "") tb_3.Text = sn_dummy;
            if (tb_4.Text == "") tb_4.Text = sn_dummy;
            if (tb_5.Text == "") tb_5.Text = sn_dummy;
            tb_6.Text = "";
            tb_7.Text = "";
            tb_8.Text = "";
            tb_9.Text = "";
            tb_10.Text = "";
            flag_select = 6;
        }
        private void tb_7_DoubleClick(object sender, EventArgs e) {
            if (tb_1.Text == "") tb_1.Text = sn_dummy;
            if (tb_2.Text == "") tb_2.Text = sn_dummy;
            if (tb_3.Text == "") tb_3.Text = sn_dummy;
            if (tb_4.Text == "") tb_4.Text = sn_dummy;
            if (tb_5.Text == "") tb_5.Text = sn_dummy;
            if (tb_6.Text == "") tb_6.Text = sn_dummy;
            tb_7.Text = "";
            tb_8.Text = "";
            tb_9.Text = "";
            tb_10.Text = "";
            flag_select = 7;
        }
        private void tb_8_DoubleClick(object sender, EventArgs e) {
            if (tb_1.Text == "") tb_1.Text = sn_dummy;
            if (tb_2.Text == "") tb_2.Text = sn_dummy;
            if (tb_3.Text == "") tb_3.Text = sn_dummy;
            if (tb_4.Text == "") tb_4.Text = sn_dummy;
            if (tb_5.Text == "") tb_5.Text = sn_dummy;
            if (tb_6.Text == "") tb_6.Text = sn_dummy;
            if (tb_7.Text == "") tb_7.Text = sn_dummy;
            tb_8.Text = "";
            tb_9.Text = "";
            tb_10.Text = "";
            flag_select = 8;
        }
        private void tb_9_DoubleClick(object sender, EventArgs e) {
            if (tb_1.Text == "") tb_1.Text = sn_dummy;
            if (tb_2.Text == "") tb_2.Text = sn_dummy;
            if (tb_3.Text == "") tb_3.Text = sn_dummy;
            if (tb_4.Text == "") tb_4.Text = sn_dummy;
            if (tb_5.Text == "") tb_5.Text = sn_dummy;
            if (tb_6.Text == "") tb_6.Text = sn_dummy;
            if (tb_7.Text == "") tb_7.Text = sn_dummy;
            if (tb_8.Text == "") tb_8.Text = sn_dummy;
            tb_9.Text = "";
            tb_10.Text = "";
            flag_select = 9;
        }
        private void tb_10_DoubleClick(object sender, EventArgs e) {
            if (tb_1.Text == "") tb_1.Text = sn_dummy;
            if (tb_2.Text == "") tb_2.Text = sn_dummy;
            if (tb_3.Text == "") tb_3.Text = sn_dummy;
            if (tb_4.Text == "") tb_4.Text = sn_dummy;
            if (tb_5.Text == "") tb_5.Text = sn_dummy;
            if (tb_6.Text == "") tb_6.Text = sn_dummy;
            if (tb_7.Text == "") tb_7.Text = sn_dummy;
            if (tb_8.Text == "") tb_8.Text = sn_dummy;
            if (tb_9.Text == "") tb_9.Text = sn_dummy;
            tb_10.Text = "";
            flag_select = 10;
        }
        private void ctms_skip_Click(object sender, EventArgs e) {
            tb_10.Text = sn_dummy;
            flag_scan_full = true;
        }

        private int flag_select = 0;
        private void timer3_Tick(object sender, EventArgs e) {
            switch (flag_select) {
                case 1:
                    tb_1.BackColor = Color.Red; DelaymS(50);
                    tb_1.BackColor = Color.White; DelaymS(50);
                    tb_1.BackColor = Color.Red; DelaymS(50);
                    tb_1.BackColor = Color.White;
                    break;
                case 2:
                    tb_2.BackColor = Color.Red; DelaymS(50);
                    tb_2.BackColor = Color.White; DelaymS(50);
                    tb_2.BackColor = Color.Red; DelaymS(50);
                    tb_2.BackColor = Color.White;
                    break;
                case 3:
                    tb_3.BackColor = Color.Red; DelaymS(50);
                    tb_3.BackColor = Color.White; DelaymS(50);
                    tb_3.BackColor = Color.Red; DelaymS(50);
                    tb_3.BackColor = Color.White;
                    break;
                case 4:
                    tb_4.BackColor = Color.Red; DelaymS(50);
                    tb_4.BackColor = Color.White; DelaymS(50);
                    tb_4.BackColor = Color.Red; DelaymS(50);
                    tb_4.BackColor = Color.White;
                    break;
                case 5:
                    tb_5.BackColor = Color.Red; DelaymS(50);
                    tb_5.BackColor = Color.White; DelaymS(50);
                    tb_5.BackColor = Color.Red; DelaymS(50);
                    tb_5.BackColor = Color.White;
                    break;
                case 6:
                    tb_6.BackColor = Color.Red; DelaymS(50);
                    tb_6.BackColor = Color.White; DelaymS(50);
                    tb_6.BackColor = Color.Red; DelaymS(50);
                    tb_6.BackColor = Color.White;
                    break;
                case 7:
                    tb_7.BackColor = Color.Red; DelaymS(50);
                    tb_7.BackColor = Color.White; DelaymS(50);
                    tb_7.BackColor = Color.Red; DelaymS(50);
                    tb_7.BackColor = Color.White;
                    break;
                case 8:
                    tb_8.BackColor = Color.Red; DelaymS(50);
                    tb_8.BackColor = Color.White; DelaymS(50);
                    tb_8.BackColor = Color.Red; DelaymS(50);
                    tb_8.BackColor = Color.White;
                    break;
                case 9:
                    tb_9.BackColor = Color.Red; DelaymS(50);
                    tb_9.BackColor = Color.White; DelaymS(50);
                    tb_9.BackColor = Color.Red; DelaymS(50);
                    tb_9.BackColor = Color.White;
                    break;
                case 10:
                    tb_10.BackColor = Color.Red; DelaymS(50);
                    tb_10.BackColor = Color.White; DelaymS(50);
                    tb_10.BackColor = Color.Red; DelaymS(50);
                    tb_10.BackColor = Color.White;
                    break;
            }
        }
        public static void DelaymS(int mS) {
            Stopwatch stopwatchDelaymS = new Stopwatch();
            stopwatchDelaymS.Restart();
            while (mS > stopwatchDelaymS.ElapsedMilliseconds) {
                if (!stopwatchDelaymS.IsRunning) stopwatchDelaymS.Start();
                Application.DoEvents();
            }
            stopwatchDelaymS.Stop();
        }

        private void cb_depanel_Click(object sender, EventArgs e) {
            tb_1.Text = "";
            tb_1.Focus();
            File.WriteAllText("../../config/dryice_scan2d_program_depanel.txt", cb_depanel.Checked.ToString());
        }

        private bool flag_close = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (!flag_close) {
                DialogResult dialogResult = MessageBox.Show("_คุณต้องการปิดโปรแกรมใช่หรือไม่", "read sn", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) return;
                e.Cancel = true;
            }
        }
        private void close_form() {
            File.WriteAllText("dryice_scan2d_program_sn1.txt", tb_1.Text);
            File.WriteAllText("dryice_scan2d_program_sn2.txt", tb_2.Text);
            File.WriteAllText("dryice_scan2d_program_sn3.txt", tb_3.Text);
            File.WriteAllText("dryice_scan2d_program_sn4.txt", tb_4.Text);
            File.WriteAllText("dryice_scan2d_program_sn5.txt", tb_5.Text);
            File.WriteAllText("dryice_scan2d_program_sn6.txt", tb_6.Text);
            File.WriteAllText("dryice_scan2d_program_sn7.txt", tb_7.Text);
            File.WriteAllText("dryice_scan2d_program_sn8.txt", tb_8.Text);
            File.WriteAllText("dryice_scan2d_program_sn9.txt", tb_9.Text);
            File.WriteAllText("dryice_scan2d_program_sn10.txt", tb_10.Text);
            Thread.Sleep(250);
            File.WriteAllText("auto_test_trick.txt", "");
            flag_close = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (cb_depanel.Checked) close_form();
            else flag_scan_full = true;
        }
    }
}
