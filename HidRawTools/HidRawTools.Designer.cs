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
            this.xD60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gH60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ps2avrUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyNameShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keymask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 320);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hIDToolStripMenuItem,
            this.xD60ToolStripMenuItem,
            this.gH60ToolStripMenuItem,
            this.ps2avrUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hIDToolStripMenuItem
            // 
            this.hIDToolStripMenuItem.Name = "hIDToolStripMenuItem";
            this.hIDToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.hIDToolStripMenuItem.Text = "HID";
            // 
            // xD60ToolStripMenuItem
            // 
            this.xD60ToolStripMenuItem.Name = "xD60ToolStripMenuItem";
            this.xD60ToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.xD60ToolStripMenuItem.Text = "XD60";
            // 
            // gH60ToolStripMenuItem
            // 
            this.gH60ToolStripMenuItem.Name = "gH60ToolStripMenuItem";
            this.gH60ToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gH60ToolStripMenuItem.Text = "GH60";
            // 
            // ps2avrUToolStripMenuItem
            // 
            this.ps2avrUToolStripMenuItem.Name = "ps2avrUToolStripMenuItem";
            this.ps2avrUToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.ps2avrUToolStripMenuItem.Text = "ps2avrU";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(0, 357);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 318);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(946, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "3415";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(838, 6);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "CCCC";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "VID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 7);
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
            this.KeyName,
            this.KeyNameShort,
            this.KeyCode,
            this.Keymask});
            this.dataGridView1.Location = new System.Drawing.Point(673, 357);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(330, 338);
            this.dataGridView1.TabIndex = 24;
            // 
            // KeyName
            // 
            this.KeyName.HeaderText = "ConsumerKeys";
            this.KeyName.Name = "KeyName";
            this.KeyName.ReadOnly = true;
            this.KeyName.Width = 150;
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
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(348, 353);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(318, 322);
            this.checkedListBox1.TabIndex = 26;
            // 
            // HidRawTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 675);
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
            this.Name = "HidRawTools";
            this.Text = "HidRawTools";
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
        private System.Windows.Forms.ToolStripMenuItem gH60ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ps2avrUToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyNameShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keymask;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

