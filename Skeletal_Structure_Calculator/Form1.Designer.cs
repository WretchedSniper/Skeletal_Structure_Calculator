namespace Skeletal_Structure_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.NDinput = new System.Windows.Forms.TextBox();
            this.NFinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Compute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NPinput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NEinput = new System.Windows.Forms.TextBox();
            this.EEinput = new System.Windows.Forms.TextBox();
            this.NAEinput = new System.Windows.Forms.TextBox();
            this.NRinput = new System.Windows.Forms.TextBox();
            this.NMinput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Pinput = new System.Windows.Forms.TextBox();
            this.NRRinput = new System.Windows.Forms.TextBox();
            this.ME1input = new System.Windows.Forms.TextBox();
            this.ME0input = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Zinput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Yinput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Xinput = new System.Windows.Forms.TextBox();
            this.AAinput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.node_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FXi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FYi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FZi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // NDinput
            // 
            this.NDinput.Location = new System.Drawing.Point(104, 10);
            this.NDinput.Name = "NDinput";
            this.NDinput.ReadOnly = true;
            this.NDinput.Size = new System.Drawing.Size(24, 21);
            this.NDinput.TabIndex = 1;
            this.NDinput.Text = "2";
            // 
            // NFinput
            // 
            this.NFinput.Location = new System.Drawing.Point(104, 40);
            this.NFinput.Name = "NFinput";
            this.NFinput.ReadOnly = true;
            this.NFinput.Size = new System.Drawing.Size(24, 21);
            this.NFinput.TabIndex = 2;
            this.NFinput.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "单元节点数ND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "节点自由度NF";
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(383, 10);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(65, 21);
            this.Compute.TabIndex = 0;
            this.Compute.Text = "计算";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "节点数NP";
            // 
            // NPinput
            // 
            this.NPinput.Location = new System.Drawing.Point(208, 10);
            this.NPinput.Name = "NPinput";
            this.NPinput.Size = new System.Drawing.Size(24, 21);
            this.NPinput.TabIndex = 3;
            this.NPinput.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "单元数NE";
            // 
            // NEinput
            // 
            this.NEinput.Location = new System.Drawing.Point(208, 40);
            this.NEinput.Name = "NEinput";
            this.NEinput.Size = new System.Drawing.Size(24, 21);
            this.NEinput.TabIndex = 4;
            this.NEinput.Text = "14";
            // 
            // EEinput
            // 
            this.EEinput.Location = new System.Drawing.Point(104, 110);
            this.EEinput.Multiline = true;
            this.EEinput.Name = "EEinput";
            this.EEinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EEinput.Size = new System.Drawing.Size(350, 30);
            this.EEinput.TabIndex = 8;
            this.EEinput.Text = "2.06e11";
            // 
            // NAEinput
            // 
            this.NAEinput.Location = new System.Drawing.Point(104, 70);
            this.NAEinput.Multiline = true;
            this.NAEinput.Name = "NAEinput";
            this.NAEinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NAEinput.Size = new System.Drawing.Size(350, 30);
            this.NAEinput.TabIndex = 7;
            this.NAEinput.Text = "1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1";
            // 
            // NRinput
            // 
            this.NRinput.Location = new System.Drawing.Point(347, 40);
            this.NRinput.Name = "NRinput";
            this.NRinput.Size = new System.Drawing.Size(24, 21);
            this.NRinput.TabIndex = 6;
            this.NRinput.Text = "12";
            // 
            // NMinput
            // 
            this.NMinput.Location = new System.Drawing.Point(347, 10);
            this.NMinput.Name = "NMinput";
            this.NMinput.Size = new System.Drawing.Size(24, 21);
            this.NMinput.TabIndex = 5;
            this.NMinput.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "弹性模量EE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "单元类别NAE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "约束自由度数NR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "单元类别数NM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "外载荷P";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "约束的自由度NRR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 12);
            this.label11.TabIndex = 30;
            this.label11.Text = "单元节点号ME[1]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "单元节点号ME[0]";
            // 
            // Pinput
            // 
            this.Pinput.Location = new System.Drawing.Point(104, 430);
            this.Pinput.Multiline = true;
            this.Pinput.Name = "Pinput";
            this.Pinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Pinput.Size = new System.Drawing.Size(350, 30);
            this.Pinput.TabIndex = 16;
            this.Pinput.Text = "0, 0, 0, 0, 0, 0, 1000, 0, 0, 1000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0";
            // 
            // NRRinput
            // 
            this.NRRinput.Location = new System.Drawing.Point(104, 390);
            this.NRRinput.Multiline = true;
            this.NRRinput.Name = "NRRinput";
            this.NRRinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NRRinput.Size = new System.Drawing.Size(350, 30);
            this.NRRinput.TabIndex = 15;
            this.NRRinput.Text = "13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24";
            // 
            // ME1input
            // 
            this.ME1input.Location = new System.Drawing.Point(104, 350);
            this.ME1input.Multiline = true;
            this.ME1input.Name = "ME1input";
            this.ME1input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ME1input.Size = new System.Drawing.Size(350, 30);
            this.ME1input.TabIndex = 14;
            this.ME1input.Text = "2, 3, 4, 4, 3, 4, 3, 2, 1, 2, 4, 3, 3, 2";
            // 
            // ME0input
            // 
            this.ME0input.Location = new System.Drawing.Point(104, 310);
            this.ME0input.Multiline = true;
            this.ME0input.Name = "ME0input";
            this.ME0input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ME0input.Size = new System.Drawing.Size(350, 30);
            this.ME0input.TabIndex = 13;
            this.ME0input.Text = "1, 2, 3, 1, 1, 2, 7, 5, 5, 6, 8, 8, 5, 8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "坐标Z";
            // 
            // Zinput
            // 
            this.Zinput.Location = new System.Drawing.Point(104, 270);
            this.Zinput.Multiline = true;
            this.Zinput.Name = "Zinput";
            this.Zinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Zinput.Size = new System.Drawing.Size(350, 30);
            this.Zinput.TabIndex = 12;
            this.Zinput.Text = "3, 0, 0, 3, 3, 0, 0, 3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 22;
            this.label14.Text = "坐标Y";
            // 
            // Yinput
            // 
            this.Yinput.Location = new System.Drawing.Point(104, 230);
            this.Yinput.Multiline = true;
            this.Yinput.Name = "Yinput";
            this.Yinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Yinput.Size = new System.Drawing.Size(350, 30);
            this.Yinput.TabIndex = 11;
            this.Yinput.Text = "4, 4, 4, 4, 0, 0, 0, 0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "坐标X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "横截面积AA";
            // 
            // Xinput
            // 
            this.Xinput.Location = new System.Drawing.Point(104, 190);
            this.Xinput.Multiline = true;
            this.Xinput.Name = "Xinput";
            this.Xinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Xinput.Size = new System.Drawing.Size(350, 30);
            this.Xinput.TabIndex = 10;
            this.Xinput.Text = "0, 0, 4, 4, 0, 0, 4, 4";
            // 
            // AAinput
            // 
            this.AAinput.Location = new System.Drawing.Point(104, 150);
            this.AAinput.Multiline = true;
            this.AAinput.Name = "AAinput";
            this.AAinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AAinput.Size = new System.Drawing.Size(350, 30);
            this.AAinput.TabIndex = 9;
            this.AAinput.Text = "4e-4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.SG,
            this.u1,
            this.u2,
            this.F1,
            this.F2});
            this.dataGridView1.Location = new System.Drawing.Point(466, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(677, 250);
            this.dataGridView1.TabIndex = 33;
            // 
            // id
            // 
            this.id.HeaderText = "单元";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // SG
            // 
            this.SG.HeaderText = "正应力";
            this.SG.Name = "SG";
            this.SG.ReadOnly = true;
            // 
            // u1
            // 
            this.u1.HeaderText = "局部坐标位移u1";
            this.u1.Name = "u1";
            this.u1.ReadOnly = true;
            this.u1.Width = 120;
            // 
            // u2
            // 
            this.u2.HeaderText = "局部坐标位移u2";
            this.u2.Name = "u2";
            this.u2.ReadOnly = true;
            this.u2.Width = 120;
            // 
            // F1
            // 
            this.F1.HeaderText = "局部坐标节点力F1";
            this.F1.Name = "F1";
            this.F1.ReadOnly = true;
            this.F1.Width = 130;
            // 
            // F2
            // 
            this.F2.HeaderText = "局部坐标节点力F2";
            this.F2.Name = "F2";
            this.F2.ReadOnly = true;
            this.F2.Width = 130;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.node_id,
            this.Xi,
            this.Yi,
            this.Zi,
            this.FXi,
            this.FYi,
            this.FZi});
            this.dataGridView2.Location = new System.Drawing.Point(466, 270);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(677, 190);
            this.dataGridView2.TabIndex = 34;
            // 
            // node_id
            // 
            this.node_id.HeaderText = "节点";
            this.node_id.Name = "node_id";
            this.node_id.ReadOnly = true;
            this.node_id.Width = 60;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "节点位移X";
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            // 
            // Yi
            // 
            this.Yi.HeaderText = "节点位移Y";
            this.Yi.Name = "Yi";
            this.Yi.ReadOnly = true;
            // 
            // Zi
            // 
            this.Zi.HeaderText = "节点位移Z";
            this.Zi.Name = "Zi";
            this.Zi.ReadOnly = true;
            // 
            // FXi
            // 
            this.FXi.HeaderText = "节点约束力FX";
            this.FXi.Name = "FXi";
            this.FXi.ReadOnly = true;
            // 
            // FYi
            // 
            this.FYi.HeaderText = "节点约束力FY";
            this.FYi.Name = "FYi";
            this.FYi.ReadOnly = true;
            // 
            // FZi
            // 
            this.FZi.HeaderText = "节点约束力FZ";
            this.FZi.Name = "FZi";
            this.FZi.ReadOnly = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(383, 40);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(65, 21);
            this.Reset.TabIndex = 35;
            this.Reset.Text = "重置";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 481);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Pinput);
            this.Controls.Add(this.NRRinput);
            this.Controls.Add(this.ME1input);
            this.Controls.Add(this.ME0input);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Zinput);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Yinput);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Xinput);
            this.Controls.Add(this.AAinput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EEinput);
            this.Controls.Add(this.NAEinput);
            this.Controls.Add(this.NRinput);
            this.Controls.Add(this.NMinput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NEinput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NPinput);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NFinput);
            this.Controls.Add(this.NDinput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "杆系结构计算程序(By 张晓宇)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NDinput;
        private System.Windows.Forms.TextBox NFinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NPinput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NEinput;
        private System.Windows.Forms.TextBox EEinput;
        private System.Windows.Forms.TextBox NAEinput;
        private System.Windows.Forms.TextBox NRinput;
        private System.Windows.Forms.TextBox NMinput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Pinput;
        private System.Windows.Forms.TextBox NRRinput;
        private System.Windows.Forms.TextBox ME1input;
        private System.Windows.Forms.TextBox ME0input;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Zinput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Yinput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Xinput;
        private System.Windows.Forms.TextBox AAinput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SG;
        private System.Windows.Forms.DataGridViewTextBoxColumn u1;
        private System.Windows.Forms.DataGridViewTextBoxColumn u2;
        private System.Windows.Forms.DataGridViewTextBoxColumn F1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F2;
        private System.Windows.Forms.DataGridViewTextBoxColumn node_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FXi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FYi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FZi;
        private System.Windows.Forms.Button Reset;
    }
}

