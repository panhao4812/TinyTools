﻿namespace HidRawTools
{
    partial class HidRawTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HidRawTools));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xD60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrix1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrix2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ps2avrUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ps2avrGB2XShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xshiftToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xD60AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xShiftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gH60revCNYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staryuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinykeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyNameShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keymask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 320);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hIDToolStripMenuItem,
            this.xD60ToolStripMenuItem,
            this.templateToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hIDToolStripMenuItem
            // 
            this.hIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDeviceToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.hIDToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.hIDToolStripMenuItem.Name = "hIDToolStripMenuItem";
            this.hIDToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.hIDToolStripMenuItem.Text = "HID";
            // 
            // openDeviceToolStripMenuItem
            // 
            this.openDeviceToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.openDeviceToolStripMenuItem.Name = "openDeviceToolStripMenuItem";
            this.openDeviceToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.openDeviceToolStripMenuItem.Text = "OpenDevice";
            this.openDeviceToolStripMenuItem.Click += new System.EventHandler(this.openDeviceToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // xD60ToolStripMenuItem
            // 
            this.xD60ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrix1ToolStripMenuItem,
            this.matrix2ToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.xD60ToolStripMenuItem.Name = "xD60ToolStripMenuItem";
            this.xD60ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.xD60ToolStripMenuItem.Text = "Edit";
            // 
            // matrix1ToolStripMenuItem
            // 
            this.matrix1ToolStripMenuItem.Name = "matrix1ToolStripMenuItem";
            this.matrix1ToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.matrix1ToolStripMenuItem.Text = "OpenMatrix";
            this.matrix1ToolStripMenuItem.Click += new System.EventHandler(this.matrix1ToolStripMenuItem_Click);
            // 
            // matrix2ToolStripMenuItem
            // 
            this.matrix2ToolStripMenuItem.Name = "matrix2ToolStripMenuItem";
            this.matrix2ToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.matrix2ToolStripMenuItem.Text = "SaveMatrix";
            this.matrix2ToolStripMenuItem.Click += new System.EventHandler(this.matrix2ToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.saveAsToolStripMenuItem.Text = "SaveAsFile";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.clearAllToolStripMenuItem.Text = "ClearAll";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // templateToolStripMenuItem
            // 
            this.templateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ps2avrUToolStripMenuItem,
            this.ps2avrGB2XShiftToolStripMenuItem,
            this.xD60AToolStripMenuItem,
            this.gH60revCNYToolStripMenuItem,
            this.staryuToolStripMenuItem,
            this.tinykeyToolStripMenuItem});
            this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
            this.templateToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.templateToolStripMenuItem.Text = "Keyboard";
            // 
            // ps2avrUToolStripMenuItem
            // 
            this.ps2avrUToolStripMenuItem.Name = "ps2avrUToolStripMenuItem";
            this.ps2avrUToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.ps2avrUToolStripMenuItem.Text = "FaceU_ISO";
            this.ps2avrUToolStripMenuItem.Click += new System.EventHandler(this.ps2avrUToolStripMenuItem_Click);
            // 
            // ps2avrGB2XShiftToolStripMenuItem
            // 
            this.ps2avrGB2XShiftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xshiftToolStripMenuItem2,
            this.minilaToolStripMenuItem});
            this.ps2avrGB2XShiftToolStripMenuItem.Name = "ps2avrGB2XShiftToolStripMenuItem";
            this.ps2avrGB2XShiftToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.ps2avrGB2XShiftToolStripMenuItem.Text = "Bface60_ver2.1";
            // 
            // xshiftToolStripMenuItem2
            // 
            this.xshiftToolStripMenuItem2.Name = "xshiftToolStripMenuItem2";
            this.xshiftToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.xshiftToolStripMenuItem2.Text = "2XShift";
            this.xshiftToolStripMenuItem2.Click += new System.EventHandler(this.xshiftToolStripMenuItem2_Click);
            // 
            // minilaToolStripMenuItem
            // 
            this.minilaToolStripMenuItem.Name = "minilaToolStripMenuItem";
            this.minilaToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.minilaToolStripMenuItem.Text = "Minila";
            this.minilaToolStripMenuItem.Click += new System.EventHandler(this.minilaToolStripMenuItem_Click);
            // 
            // xD60AToolStripMenuItem
            // 
            this.xD60AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xShiftToolStripMenuItem,
            this.xShiftToolStripMenuItem1});
            this.xD60AToolStripMenuItem.Name = "xD60AToolStripMenuItem";
            this.xD60AToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.xD60AToolStripMenuItem.Text = "XD60_ver2.0";
            // 
            // xShiftToolStripMenuItem
            // 
            this.xShiftToolStripMenuItem.Name = "xShiftToolStripMenuItem";
            this.xShiftToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.xShiftToolStripMenuItem.Text = "2.15XShift";
            this.xShiftToolStripMenuItem.Click += new System.EventHandler(this.xShiftToolStripMenuItem_Click);
            // 
            // xShiftToolStripMenuItem1
            // 
            this.xShiftToolStripMenuItem1.Name = "xShiftToolStripMenuItem1";
            this.xShiftToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.xShiftToolStripMenuItem1.Text = "2XShift";
            this.xShiftToolStripMenuItem1.Click += new System.EventHandler(this.xShiftToolStripMenuItem1_Click);
            // 
            // gH60revCNYToolStripMenuItem
            // 
            this.gH60revCNYToolStripMenuItem.Name = "gH60revCNYToolStripMenuItem";
            this.gH60revCNYToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.gH60revCNYToolStripMenuItem.Text = "GH60_revCNY";
            this.gH60revCNYToolStripMenuItem.Click += new System.EventHandler(this.gH60revCNYToolStripMenuItem_Click);
            // 
            // staryuToolStripMenuItem
            // 
            this.staryuToolStripMenuItem.Name = "staryuToolStripMenuItem";
            this.staryuToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.staryuToolStripMenuItem.Text = "Staryu_ver1.5";
            this.staryuToolStripMenuItem.Click += new System.EventHandler(this.staryuToolStripMenuItem_Click);
            // 
            // tinykeyToolStripMenuItem
            // 
            this.tinykeyToolStripMenuItem.Name = "tinykeyToolStripMenuItem";
            this.tinykeyToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.tinykeyToolStripMenuItem.Text = "XD002_ver1.0";
            this.tinykeyToolStripMenuItem.Click += new System.EventHandler(this.tinykeyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 24);
            this.toolStripMenuItem1.Text = "Help";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(0, 358);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(342, 318);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(947, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(837, 6);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "VID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "PID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.KeyName,
            this.KeyNameShort,
            this.KeyCode,
            this.Keymask});
            this.dataGridView1.Location = new System.Drawing.Point(673, 358);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(331, 318);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // index
            // 
            this.index.HeaderText = "index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 30;
            // 
            // KeyName
            // 
            this.KeyName.HeaderText = "ConsumerKeys";
            this.KeyName.Name = "KeyName";
            this.KeyName.ReadOnly = true;
            this.KeyName.Width = 120;
            // 
            // KeyNameShort
            // 
            this.KeyNameShort.HeaderText = "ShortName";
            this.KeyNameShort.Name = "KeyNameShort";
            this.KeyNameShort.ReadOnly = true;
            this.KeyNameShort.Width = 80;
            // 
            // KeyCode
            // 
            this.KeyCode.FillWeight = 60F;
            this.KeyCode.HeaderText = "KeyCode";
            this.KeyCode.Name = "KeyCode";
            this.KeyCode.ReadOnly = true;
            this.KeyCode.Width = 50;
            // 
            // Keymask
            // 
            this.Keymask.FillWeight = 60F;
            this.Keymask.HeaderText = "KeyMask";
            this.Keymask.Name = "Keymask";
            this.Keymask.ReadOnly = true;
            this.Keymask.Width = 30;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(348, 352);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(318, 322);
            this.checkedListBox1.TabIndex = 26;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(265, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 19);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Layer0";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(351, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 19);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.Text = "Layer1";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // HidRawTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 675);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HidRawTools";
            this.Text = "HidRawTools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HidRawTools_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xD60ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripMenuItem matrix1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrix2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xD60AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ps2avrUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gH60revCNYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ps2avrGB2XShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyNameShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keymask;
        private System.Windows.Forms.ToolStripMenuItem xShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xShiftToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staryuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xshiftToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinykeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

