using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skeletal_Structure_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            try
            {
                Calculator cal = new Calculator
                {
                    ND = int.Parse(NDinput.Text),
                    NF = int.Parse(NFinput.Text),
                    NP = int.Parse(NPinput.Text),
                    NE = int.Parse(NEinput.Text),
                    NM = int.Parse(NMinput.Text),
                    NR = int.Parse(NRinput.Text),
                    NAE = Array.ConvertAll(NAEinput.Text.Split(','), int.Parse),
                    EE = Array.ConvertAll(EEinput.Text.Split(','), double.Parse),
                    AA = Array.ConvertAll(AAinput.Text.Split(','), double.Parse),
                    X = Array.ConvertAll(Xinput.Text.Split(','), double.Parse),
                    Y = Array.ConvertAll(Yinput.Text.Split(','), double.Parse),
                    Z = Array.ConvertAll(Zinput.Text.Split(','), double.Parse),
                    ME = new int[][] { Array.ConvertAll(ME0input.Text.Split(','), int.Parse), Array.ConvertAll(ME1input.Text.Split(','), int.Parse) },
                    NRR = Array.ConvertAll(NRRinput.Text.Split(','), int.Parse),
                    P = Array.ConvertAll(Pinput.Text.Split(','), double.Parse)
                };
                cal.SolveProblem();
                for (int i = 0; i < cal.NE; ++i)
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = i + 1;
                    dataGridView1.Rows[index].Cells[1].Value = cal.SG[i].ToString("#.#####E+00");
                    dataGridView1.Rows[index].Cells[2].Value = cal.Dee[i, 0].ToString("#.#####E+00");
                    dataGridView1.Rows[index].Cells[3].Value = cal.Dee[i, 1].ToString("#.#####E+00");
                    dataGridView1.Rows[index].Cells[4].Value = cal.Fee[i, 0].ToString("#.#####E+00");
                    dataGridView1.Rows[index].Cells[5].Value = cal.Fee[i, 1].ToString("#.#####E+00");
                }
                for (int i = 0; i < cal.NP; ++i)
                {
                    int index = dataGridView2.Rows.Add();
                    dataGridView2.Rows[index].Cells[0].Value = i + 1;
                    dataGridView2.Rows[index].Cells[1].Value = cal.P[i * 3].ToString("#.#####E+00");
                    dataGridView2.Rows[index].Cells[2].Value = cal.P[i * 3 + 1].ToString("#.#####E+00");
                    dataGridView2.Rows[index].Cells[3].Value = cal.P[i * 3 + 2].ToString("#.#####E+00");
                    dataGridView2.Rows[index].Cells[4].Value = cal.P1[i * 3].ToString("#.#####E+00");
                    dataGridView2.Rows[index].Cells[5].Value = cal.P1[i * 3 + 1].ToString("#.#####E+00");
                    dataGridView2.Rows[index].Cells[6].Value = cal.P1[i * 3 + 2].ToString("#.#####E+00");
                }
                NPinput.ReadOnly = true;
                NEinput.ReadOnly = true;
                NMinput.ReadOnly = true;
                NRinput.ReadOnly = true;
                NAEinput.ReadOnly = true;
                EEinput.ReadOnly = true;
                AAinput.ReadOnly = true;
                Xinput.ReadOnly = true;
                Yinput.ReadOnly = true;
                Zinput.ReadOnly = true;
                ME0input.ReadOnly = true;
                ME1input.ReadOnly = true;
                NRRinput.ReadOnly = true;
                Pinput.ReadOnly = true;

                Graphics g = pictureBox1.CreateGraphics();
                Font font = new Font("Arial", 12);
                SolidBrush brush = new SolidBrush(Color.Black);

                double scale1 = double.Parse(textBox1.Text);
                double scale2 = double.Parse(textBox2.Text);

                //axis1
                g.DrawLine(new Pen(Color.Black, 1), 225, 225, 48.225f, 326.8f);
                g.DrawLine(new Pen(Color.Black, 1), 225, 225, 401.775f, 369.525f);
                g.DrawLine(new Pen(Color.Black, 1), 225, 225, 225, 20.625f);
                g.DrawString("x", font, brush, 402, 370);
                g.DrawString("y", font, brush, 220, 5);
                g.DrawString("z", font, brush, 40, 326);
                //axis2
                g.DrawLine(new Pen(Color.Black, 1), 675, 225, 498.225f, 326.8f);
                g.DrawLine(new Pen(Color.Black, 1), 675, 225, 851.775f, 369.525f);
                g.DrawLine(new Pen(Color.Black, 1), 675, 225, 675, 20.625f);
                g.DrawString("x", font, brush, 852, 370);
                g.DrawString("y", font, brush, 670, 5);
                g.DrawString("z", font, brush, 490, 326);

                for (int i = 0; i < cal.NE; ++i)
                {
                    //note the axis direction
                    //fig1
                    double x1 = cal.Z[cal.ME[0][i] - 1];
                    double x2 = cal.Z[cal.ME[1][i] - 1];
                    double y1 = cal.X[cal.ME[0][i] - 1];
                    double y2 = cal.X[cal.ME[1][i] - 1];
                    double z1 = cal.Y[cal.ME[0][i] - 1];
                    double z2 = cal.Y[cal.ME[1][i] - 1];
                    double X1 = 225 - (0.7071 * x1 - 0.7071 * y1) * scale1;
                    double X2 = 225 - (0.7071 * x2 - 0.7071 * y2) * scale1;
                    double Z1 = 225 - (-0.4072 * x1 - 0.5781 * y1 + 0.8175 * z1) * scale1;
                    double Z2 = 225 - (-0.4072 * x2 - 0.5781 * y2 + 0.8175 * z2) * scale1;
                    g.DrawLine(new Pen(Color.Black, 3), Convert.ToSingle(X1), Convert.ToSingle(Z1), Convert.ToSingle(X2), Convert.ToSingle(Z2));
                    //fig2
                    X1 = 675 - (0.7071 * x1 - 0.7071 * y1) * scale1;
                    X2 = 675 - (0.7071 * x2 - 0.7071 * y2) * scale1;
                    Z1 = 225 - (-0.4072 * x1 - 0.5781 * y1 + 0.8175 * z1) * scale1;
                    Z2 = 225 - (-0.4072 * x2 - 0.5781 * y2 + 0.8175 * z2) * scale1;
                    g.DrawLine(new Pen(Color.Black, 2), Convert.ToSingle(X1), Convert.ToSingle(Z1), Convert.ToSingle(X2), Convert.ToSingle(Z2));
                    x1 = cal.Z[cal.ME[0][i] - 1] + scale2 * cal.P[(cal.ME[0][i] - 1) * 3 + 2];
                    x2 = cal.Z[cal.ME[1][i] - 1] + scale2 * cal.P[(cal.ME[1][i] - 1) * 3 + 2];
                    y1 = cal.X[cal.ME[0][i] - 1] + scale2 * cal.P[(cal.ME[0][i] - 1) * 3];
                    y2 = cal.X[cal.ME[1][i] - 1] + scale2 * cal.P[(cal.ME[1][i] - 1) * 3];
                    z1 = cal.Y[cal.ME[0][i] - 1] + scale2 * cal.P[(cal.ME[0][i] - 1) * 3 + 1];
                    z2 = cal.Y[cal.ME[1][i] - 1] + scale2 * cal.P[(cal.ME[1][i] - 1) * 3 + 1];
                    X1 = 675 - (0.7071 * x1 - 0.7071 * y1) * scale1;
                    X2 = 675 - (0.7071 * x2 - 0.7071 * y2) * scale1;
                    Z1 = 225 - (-0.4072 * x1 - 0.5781 * y1 + 0.8175 * z1) * scale1;
                    Z2 = 225 - (-0.4072 * x2 - 0.5781 * y2 + 0.8175 * z2) * scale1;
                    g.DrawLine(new Pen(Color.Red, 3), Convert.ToSingle(X1), Convert.ToSingle(Z1), Convert.ToSingle(X2), Convert.ToSingle(Z2));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("输入有误");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {

            NPinput.ReadOnly = false;
            NEinput.ReadOnly = false;
            NMinput.ReadOnly = false;
            NRinput.ReadOnly = false;
            NAEinput.ReadOnly = false;
            EEinput.ReadOnly = false;
            AAinput.ReadOnly = false;
            Xinput.ReadOnly = false;
            Yinput.ReadOnly = false;
            Zinput.ReadOnly = false;
            ME0input.ReadOnly = false;
            ME1input.ReadOnly = false;
            NRRinput.ReadOnly = false;
            Pinput.ReadOnly = false;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
        }
    }
}