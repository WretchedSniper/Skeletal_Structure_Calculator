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
        }
    }
}
