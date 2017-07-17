﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidRawTools
{
    public class IMatrix
    {
        public IMatrix() { }
        public int ROWS;
        public int COLS;
        public byte[] rowPins;
        public byte[] colPins;
        public string[,] hexaKeys0 = new string[5, 14];
        public string[,] hexaKeys1 = new string[5, 14];
        public byte[,] keymask = new byte[5, 14];
        public double[,] keycap;
        public string Name = "unamed";
        public string[] keycode;
        public string[] Defaultkeycode;
    }
    class XD60_A : IMatrix
    {
        public XD60_A()
        {
            this.Name = "XD60_A";
            this.ROWS = 5;
            this.COLS = 14;
            this.rowPins = new byte[5] { 5, 6, 7, 8, 23 };
            this.colPins = new byte[14] { 21, 20, 24, 10, 9, 15, 22, 1, 4, 14, 13, 12, 11, 3 };
            this.hexaKeys0 = new string[5, 14];
            this.hexaKeys1 = new string[5, 14];
            Defaultkeycode = new string[]{
"0,KEY_ESC,KEY_TILDE",
"1,KEY_1,KEY_F1",
"2,KEY_2,KEY_F2",
"3,KEY_3,KEY_F3",
"4,KEY_4,KEY_F4",
"5,KEY_5,KEY_F5",
"6,KEY_6,KEY_F6",
"7,KEY_7,KEY_F7",
"8,KEY_8,KEY_F8",
"9,KEY_9,KEY_F9",
"10,KEY_0,KEY_F10",
"11,KEY_MINUS,KEY_F11",
"12,KEY_EQUAL,KEY_F12",
"14,KEY_BACKSPACE,KEY_DELETE",
"16,KEY_TAB,KEY_TAB",
"17,KEY_Q,KEYPAD_1",
"18,KEY_W,KEYPAD_2",
"19,KEY_E,KEYPAD_3",
"20,KEY_R,KEYPAD_4",
"21,KEY_T,KEYPAD_5",
"22,KEY_Y,KEYPAD_6",
"23,KEY_U,KEYPAD_7",
"24,KEY_I,KEYPAD_8",
"25,KEY_O,KEYPAD_9",
"26,KEY_P,KEYPAD_0",
"27,KEY_LEFT_BRACE,KEYPAD_MINUS",
"28,KEY_RIGHT_BRACE,KEYPAD_PLUS",
"29,KEY_BACKSLASH,KEY_BACKSLASH",
"30,KEY_CAPS_LOCK,KEY_CAPS_LOCK",
"31,KEY_A,MOUSE_LEFT",
"32,KEY_S,MOUSE_MID",
"33,KEY_D,MOUSE_RIGHT",
"34,KEY_F,",
"35,KEY_G,",
"36,KEY_H,",
"37,KEY_J,",
"38,KEY_K,",
"39,KEY_L,",
"40,KEY_SEMICOLON,",
"41,KEY_QUOTE,",
"43,KEY_ENTER,KEY_ENTER",
"45,KEY_SHIFT,KEY_SHIFT",
"48,KEY_Z,KEY_NUM_LOCK",
"49,KEY_X,KEY_SCROLL_LOCK",
"50,KEY_C,KEY_INSERT",
"51,KEY_V,KEY_PRINTSCREEN",
"52,KEY_B,",
"53,KEY_N,",
"54,KEY_M,",
"55,KEY_COMMA,AUDIO_VOL_DOWN",
"56,KEY_PERIOD,AUDIO_VOL_UP",
"62,KEY_SLASH,KEY_SLASH",
"76,KEY_SLASH,KEY_SLASH",
"78,KEY_UP,KEY_UP",
"81,KEY_FN,KEY_FN",
"82,KEY_RIGHT_CTRL,KEY_RIGHT_CTRL",
"83,KEY_LEFT,KEY_LEFT",
"84,KEY_DOWN,KEY_DOWN",
"85,KEY_RIGHT,KEY_RIGHT",
"86,KEY_CTRL,KEY_CTRL",
"88,KEY_FN,KEY_FN",
"91,KEY_ALT,KEY_ALT",
"93,KEY_SPACE,KEY_SPACE"
};

            //x,y,length,row,col
            keycode = new string[106 * 2];
            for (int i = 0; i < keycode.Length; i++)
            {
                keycode[i] = "";
            }
            this.keycap = new double[106, 5] {
        {0,0,1,0,0 },
        {1,0,1,0,1 },
        {2,0,1,0,2 },
        {3,0,1,0,3 },
        {4,0,1,0,4 },
        {5,0,1,0,5 },
        {6,0,1,0,6 },
        {7,0,1,0,7 },
        {8,0,1,0,8 },
        {9,0,1,0,9 },
        {10,0,1,0,10 },
        {11,0,1,0,11 },
        {12,0,1,0,12 },
        {13,0,1,0,13 },
        {13,0,2,0,13 },
        {14,0,1,4,9 },
        {0,1,1.5,1,0 },
        {1.5,1,1,1,1 },
        {2.5,1,1,1,2 },
        {3.5,1,1,1,3 },
        {4.5,1,1,1,4 },
        {5.5,1,1,1,5 },
        {6.5,1,1,1,6 },
        {7.5,1,1,1,7 },
        {8.5,1,1,1,8 },
        {9.5,1,1,1,9 },
        {10.5,1,1,1,10 },
        {11.5,1,1,1,11 },
        {12.5,1,1,1,12 },
        {13.5,1,1.5,1,13 },
        {0,2,1.75,2,0 },
        {1.75,2,1,2,1 },
        {2.75,2,1,2,2 },
        {3.75,2,1,2,3 },
        {4.75,2,1,2,4 },
        {5.75,2,1,2,5 },
        {6.75,2,1,2,6 },
        {7.75,2,1,2,7 },
        {8.75,2,1,2,8 },
        {9.75,2,1,2,9 },
        {10.75,2,1,2,10 },
        {11.75,2,1,2,11 },
        {12.75,2,1,2,12 },
        {12.75,2,2.25,2,13 },
        {13.75,2,1.25,2,13 },
        {0,3,2.25,3,0 },
        {0,3,1.25,3,0 },
        {1.25,3,1,3,1 },
        {2.25,3,1,3,2 },
        {3.25,3,1,3,3 },
        {4.25,3,1,3,4 },
        {5.25,3,1,3,5 },
        {6.25,3,1,3,6 },
        {7.25,3,1,3,7 },
        {8.25,3,1,3,8 },
        {9.25,3,1,3,9 },
        {10.25,3,1,3,10 },
        {11.25,3,1,3,11 },
        {12.25,3,2.75,3,13 },
        {12.25,3,1.75,3,13 },
        {12.25,3,1,3,12 },
        {13.25,3,1.75,3,13 },
        {14,3,1,3,12 },
        {0,3,2,3,0 },
        {0,3,1,3,0 },
        {1,3,1,3,1 },
        {2,3,1,3,2 },
        {3,3,1,3,3 },
        {4,3,1,3,4 },
        {5,3,1,3,5 },
        {6,3,1,3,6 },
        {7,3,1,3,7 },
        {8,3,1,3,8 },
        {9,3,1,3,9 },
        {10,3,1,3,10 },
        {11,3,1,3,11 },
        {11.25,3,1.75,4,7 },
        {12,3,1,4,7 },
        {13,3,1,3,13 },
        {13,3,2,3,13 },
        {14,3,1,3,12 },
        {10,4,1,4,10 },
        {11,4,1,4,11 },
        {12,4,1,4,8 },
        {13,4,1,4,12 },
        {14,4,1,4,13 },
        {0,4,1.25,4,0 },
        {0,4,1.5,4,0 },
        {1.25,4,1.25,4,1 },
        {1.5,4,1.5,4,1 },
        {1.5,4,1,4,1 },
        {2.5,4,1.25,4,2 },
        {2.5,4,1.5,4,2 },
        {3.75,4,6.25,4,5 },
        {3,4,7,4,5 },
        {4,4,7,4,5 },
        {4,4,6,4,5 },
        {10,4,1.25,4,10 },
        {10,4,1.5,4,10 },
        {11.25,4,1.25,4,11 },
        {11.5,4,1,4,11 },
        {11,4,1.5,4,11 },
        {12.5,4,1.25,4,12 },
        {12.5,4,1,4,12 },
        {13.75,4,1.25,4,13 },
        {13.5,4,1.5,4,13 } };
        }
    }
}
