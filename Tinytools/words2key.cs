﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace words2key
{
    public partial class words2key : Form
    {
        public words2key()
        {
            InitializeComponent();
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            string str = "";
            if (of.ShowDialog() == DialogResult.OK)
            {
                str = of.FileName.ToString();
            }
            try
            {
                StreamReader stream = new StreamReader(str);
                textBox1.Text = stream.ReadToEnd();
            }
            catch { }
        }
        private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //0xF1=null 0xF2=shift
            //0xF1,key1,0xF2,key1,key2..
            string output = "";
            char[] ch = textBox1.Text.ToArray();
            int code = 160;
            for (int j = 0; j < ch.Length; j++)
            {
                if (ch[j] < 126)
                {
                    code = ascii_to_scan_code_table[(int)ch[j]];
                }
                if (code != 0)
                {
                    // output += (int)ch[j] + "|";
                    output += code.ToString() + ",";
                }
                if (code == 40) output += "\r\n";
            }
            textBox2.Text = output;
        }
        public static int[] ascii_to_scan_code_table = {
	// /* ASCII:   0 */
	0,
	// /* ASCII:   1 */
	0,
	// /* ASCII:   2 */
	0,
	// /* ASCII:   3 */
	0,
	// /* ASCII:   4 */
	0,
	// /* ASCII:   5 */
	0,
	// /* ASCII:   6 */
	0,
	// /* ASCII:   7 */
	0,
	/* ASCII:   8 */ 42,
	/* ASCII:   9 */ 43,
	/* ASCII:  10 */ 40,
	/* ASCII:  11 */ 0,
	/* ASCII:  12 */ 0,
	/* ASCII:  13 */ 0,
	/* ASCII:  14 */ 0,
	/* ASCII:  15 */ 0,
	/* ASCII:  16 */ 0,
	/* ASCII:  17 */ 0,
	/* ASCII:  18 */ 0,
	/* ASCII:  19 */ 0,
	/* ASCII:  20 */ 0,
	/* ASCII:  21 */ 0,
	/* ASCII:  22 */ 0,
	/* ASCII:  23 */ 0,
	/* ASCII:  24 */ 0,
	/* ASCII:  25 */ 0,
	/* ASCII:  26 */ 0,
	/* ASCII:  27 */ 41,
	/* ASCII:  28 */ 0,
	/* ASCII:  29 */ 0,
	/* ASCII:  30 */ 0,
	/* ASCII:  31 */ 0,
	/* ASCII:  32 */ 44,
	/* ASCII:  33 */ 158,
	/* ASCII:  34 */ 180,
	/* ASCII:  35 */ 160,
	/* ASCII:  36 */ 161,
	/* ASCII:  37 */ 162,
	/* ASCII:  38 */ 164,
	/* ASCII:  39 */ 52,
	/* ASCII:  40 */ 166,
	/* ASCII:  41 */ 167,
	/* ASCII:  42 */ 165,
	/* ASCII:  43 */ 174,
	/* ASCII:  44 */ 54,
	/* ASCII:  45 */ 45,
	/* ASCII:  46 */ 55,
	/* ASCII: / 47 */ 184,
	/* ASCII:  48 */ 39,
	/* ASCII:  49 */ 30,
	/* ASCII:  50 */ 31,
	/* ASCII:  51 */ 32,
	/* ASCII:  52 */ 33,
	/* ASCII:  53 */ 34,
	/* ASCII:  54 */ 35,
	/* ASCII:  55 */ 36,
	/* ASCII:  56 */ 37,
	/* ASCII:  57 */ 38,
	/* ASCII:  58 */ 179,
	/* ASCII:  59 */ 51,
	/* ASCII:  60 */ 182,
	/* ASCII:  61 */ 46,
	/* ASCII:  62 */ 183,
	/* ASCII:  ?63 */ 56,
	/* ASCII:  64 */ 159,
	/* ASCII: A 65 */ 132,
	/* ASCII:  66 */ 133,
	/* ASCII:  67 */ 134,
	/* ASCII:  68 */ 135,
	/* ASCII:  69 */ 136,
	/* ASCII:  70 */ 137,
	/* ASCII:  71 */ 138,
	/* ASCII:  72 */ 139,
	/* ASCII:  73 */ 140,
	/* ASCII:  74 */ 141,
	/* ASCII:  75 */ 142,
	/* ASCII:  76 */ 143,
	/* ASCII:  77 */ 144,
	/* ASCII:  78 */ 145,
	/* ASCII:  79 */ 146,
	/* ASCII:  80 */ 147,
	/* ASCII:  81 */ 148,
	/* ASCII:  82 */ 149,
	/* ASCII:  83 */ 150,
	/* ASCII:  84 */ 151,
	/* ASCII:  85 */ 152,
	/* ASCII:  86 */ 153,
	/* ASCII:  87 */ 154,
	/* ASCII:  88 */ 155,
	/* ASCII:  89 */ 156,
	/* ASCII: Z 90 */ 157,
	/* ASCII:  91 */ 47,
	/* ASCII:  92 */ 49,
	/* ASCII:  93 */ 48,
	/* ASCII:  94 */ 163,
	/* ASCII:  95 */ 173,
	/* ASCII:  96 */ 53,
	/* ASCII: a 97 */ 4,
	/* ASCII:  98 */ 5,
	/* ASCII:  99 */ 6,
	/* ASCII: 100 */ 7,
	/* ASCII: 101 */ 8,
	/* ASCII: 102 */ 9,
	/* ASCII: 103 */ 10,
	/* ASCII: 104 */ 11,
	/* ASCII: 105 */ 12,
	/* ASCII: 106 */ 13,
	/* ASCII: 107 */ 14,
	/* ASCII: 108 */ 15,
	/* ASCII: 109 */ 16,
	/* ASCII: 110 */ 17,
	/* ASCII: 111 */ 18,
	/* ASCII: 112 */ 19,
	/* ASCII: 113 */ 20,
	/* ASCII: 114 */ 21,
	/* ASCII: 115 */ 22,
	/* ASCII: 116 */ 23,
	/* ASCII: 117 */ 24,
	/* ASCII: 118 */ 25,
	/* ASCII: 119 */ 26,
	/* ASCII: 120 */ 27,
	/* ASCII: 121 */ 28,
	/* ASCII: 122 */ 29,
	/* ASCII: 123 */ 175,
	/* ASCII: 124 */ 177,
	/* ASCII: 125 */ 176,
	/* ASCII: 126 */ 181 };
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                Clipboard.SetDataObject(textBox2.Text);
        }

        private void words2key_Load(object sender, EventArgs e)
        {

        }
    }
}
