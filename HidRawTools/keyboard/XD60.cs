﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidRawTools
{
    class Staryu : IMatrix
    {
        public Staryu()
        {
            this.PrintFlashAddress = 0x2200;
            this.PrintEEpAddress = 40;
            this.eepromsize = 1024;
            this.flashsize = 0x7000;

            this.Name = "Staryu";
            this.ROWS = 1;
            this.COLS = 5;
            this.rowPins = new byte[1] { 0xFF };
            this.colPins = new byte[5] { 16, 17, 18, 19, 20 };
            this.hexaKeys0 = new string[1, 5];
            this.hexaKeys1 = new string[1, 5];
            keycode = new string[5 * 2];
            for (int i = 0; i < keycode.Length; i++)
            {
                keycode[i] = "";
            }
            this.keycap = new double[5, 5] {
                {16,3,1,0,0 },
                {17,3,1,0,1 },
                {15,4,1,0,4 },
                {16,4,1,0,3 },
                {17,4,1,0,2 },
            };
            Defaultkeycode = new string[]{
"0,KEY_UP,MACRO4",
"1,KEY_FN,KEY_FN",
"2,KEY_LEFT,MACRO5",
"3,KEY_DOWN,MACRO6",
"4,KEY_RIGHT,MACRO7"
            };
            RGB = new int[1, 6] { { 782, 255, 0, 255, 255, 255 } };

        }
    }
    class XD004 : IMatrix
    {
        public XD004()
        {
            this.PrintFlashAddress = 0x2400;
            this.PrintEEpAddress = 39;
            this.eepromsize = 512;
            this.flashsize = 0x3000;

            this.Name = "XD004";
            this.ROWS = 1;
            this.COLS = 4;
            this.rowPins = new byte[1] { 0xFF };
            this.colPins = new byte[4] { 19, 16, 12, 4 };
            this.hexaKeys0 = new string[1, 4];
            this.hexaKeys1 = new string[1, 4];
            keycode = new string[4 * 2];
            for (int i = 0; i < keycode.Length; i++)
            {
                keycode[i] = "";
            }
            this.keycap = new double[4, 5] {
                {15,4,1,0,0 },
                {16,4,1,0,1 },
                {17,4,1,0,2 },
                {18,4,1,0,3 },
            };
            Defaultkeycode = new string[]{
"0,KEY_1,MACRO1",
"1,KEY_3,MACRO3",
"2,KEY_4,MACRO4",
"3,KEY_FN,KEY_FN",
            };
            RGB = new int[2, 6]{
                //x,y,type,r,g,b
 {832,355,0,255,255,255},
 {878,355,0,255,255,255}
            };
        }
    }
    class Tinykey : IMatrix
    {
        public Tinykey()
        {
            this.PrintFlashAddress = 0;
            this.PrintEEpAddress = 31;
            this.eepromsize = 512;
            this.flashsize = 0;

            this.Name = "Tinykey";
            this.ROWS = 1;
            this.COLS = 2;
            this.rowPins = new byte[1] { 0xFF };
            this.colPins = new byte[2] { 0, 1 };
            this.hexaKeys0 = new string[1, 2];
            this.hexaKeys1 = new string[1, 2];
            keycode = new string[2 * 2];
            for (int i = 0; i < keycode.Length; i++)
            {
                keycode[i] = "";
            }
            this.keycap = new double[2, 5] {
                {16,4,1,0,0 },
                {17,4,1,0,1 },
            };
            Defaultkeycode = new string[]{
"0,MACRO1,MACRO1",
"1,MACRO3,MACRO3"
            };
            RGB = new int[2, 6]{
                //x,y,type,r,g,b
 {832,355,0,255,255,255},
 {878,355,0,255,255,255}
            };
        }
    }
    class XD60 : IMatrix
    {
        public XD60()
        {
            this.PrintFlashAddress = 0;
            this.PrintEEpAddress = 281;
            this.eepromsize = 1024;
            this.flashsize = 0x7000;

            this.ROWS = 5;
            this.COLS = 14;
            this.rowPins = new byte[5] { 5, 6, 7, 8, 23 };
            this.colPins = new byte[14] { 21, 20, 24, 10, 9, 15, 22, 1, 4, 14, 13, 12, 11, 3 };
            this.hexaKeys0 = new string[5, 14];
            this.hexaKeys1 = new string[5, 14];
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
            RGB = new int[12, 6]{
                //x,y,type,r,g,b
 {630,12,0,255,255,255},
 {530,12,0,255,255,255},
 {430,12,0,255,255,255},
 {330,12,0,255,255,255},
 {230,12,0,255,255,255},
 {130,12,0,255,255,255},
 {130,355,0,255,255,255},
 {230,355,0,255,255,255},
 {330,355,0,255,255,255},
 {430,355,0,255,255,255},
 {530,355,0,255,255,255},
 {630,355,0,255,255,255}
            };
        }
    }
    class XD60_A : XD60
    {
        public XD60_A():base()
        {
            this.Name = "XD60_A";
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
        }
    }
    class XD60_B : XD60
    {
        public XD60_B() : base()
        {
            this.Name = "XD60_B";
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
"63,KEY_SHIFT,KEY_SHIFT",
"66,KEY_Z,KEY_NUM_LOCK",
"67,KEY_X,KEY_SCROLL_LOCK",
"68,KEY_C,KEY_INSERT",
"69,KEY_V,KEY_PRINTSCREEN",
"70,KEY_B,",
"71,KEY_N,",
"72,KEY_M,",
"73,KEY_COMMA,AUDIO_VOL_DOWN",
"74,KEY_PERIOD,AUDIO_VOL_UP",
"75,KEY_SLASH,AUDIO_MUTE",
"77,KEY_UP,KEY_UP",
"79,KEY_RIGHT_SHIFT,KEY_RIGHT_SHIFT",
"81,KEY_FN,KEY_FN",
"82,KEY_LEFT,KEY_LEFT",
"83,KEY_DOWN,KEY_DOWN",
"84,KEY_RIGHT,KEY_RIGHT",
"85,KEY_RIGHT_CTRL,KEY_RIGHT_CTRL",
"86,KEY_CTRL,KEY_CTRL",
"88,KEY_FN,KEY_FN",
"91,KEY_ALT,KEY_ALT",
"93,KEY_SPACE,KEY_SPACE"
};
            //x,y,length,row,col       
        }
    }
    class XD75_Re : IMatrix
    {
        public XD75_Re()
        {
            this.PrintFlashAddress = 0;
            this.PrintEEpAddress = 279;
            this.eepromsize = 1024;
            this.flashsize = 0x7000;

            this.Name = "XD75_Re";
            this.ROWS = 5;
            this.COLS = 15;
            this.rowPins = new byte[5] { 5, 6, 7, 8, 23 };
            this.colPins = new byte[15] { 21, 20, 24, 10, 9, 15, 22, 1, 4, 14, 13, 12, 11, 3, 0 };
            this.hexaKeys0 = new string[5, 15];
            this.hexaKeys1 = new string[5, 15];
            keycode = new string[75 * 2];
            for (int i = 0; i < keycode.Length; i++) { keycode[i] = ""; }
            this.keycap = new double[75, 5] {
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
        {14,0,1,0,14 },
//-----------1---------------
        {0,1,1,1,0 },
        {1,1,1,1,1 },
        {2,1,1,1,2 },
        {3,1,1,1,3 },
        {4,1,1,1,4 },
        {5,1,1,1,5 },
        {6,1,1,1,6 },
        {7,1,1,1,7 },
        {8,1,1,1,8 },
        {9,1,1,1,9 },
        {10,1,1,1,10 },
        {11,1,1,1,11 },
        {12,1,1,1,12 },
        {13,1,1,1,13 },
        {14,1,1,1,14 },
        //-----------2---------------
        {0,2,1,2,0 },
        {1,2,1,2,1 },
        {2,2,1,2,2 },
        {3,2,1,2,3 },
        {4,2,1,2,4 },
        {5,2,1,2,5 },
        {6,2,1,2,6 },
        {7,2,1,2,7 },
        {8,2,1,2,8 },
        {9,2,1,2,9 },
        {10,2,1,2,10 },
        {11,2,1,2,11 },
        {12,2,1,2,12 },
        {13,2,1,2,13 },
        {14,2,1,2,14 },
        //-----------3---------------
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
        {12,3,1,3,12 },
        {13,3,1,3,13 },
        {14,3,1,3,14 },
        //-----------4---------------
        {0,4,1,4,0 },
        {1,4,1,4,1 },
        {2,4,1,4,2 },
        {3,4,1,4,3 },
        {4,4,1,4,4 },
        {5,4,1,4,5 },
        {6,4,1,4,6 },
        {7,4,1,4,7 },
        {8,4,1,4,8 },
        {9,4,1,4,9 },
        {10,4,1,4,10 },
        {11,4,1,4,11 },
        {12,4,1,4,12 },
        {13,4,1,4,13 },
        {14,4,1,4,14 }};
            Defaultkeycode = new string[]{
"0,KEY_ESC,KEY_F1",
"1,KEY_1,KEY_F2",
"2,KEY_2,KEY_F3",
"3,KEY_3,KEY_F4",
"4,KEY_4,KEY_F5",
"5,KEY_5,KEY_F6",
"6,KEY_MINUS,KEY_NUM_LOCK",
"7,KEY_TILDE,KEYPAD_SLASH",
"8,KEY_EQUAL,KEYPAD_ASTERIX",
"9,KEY_6,KEY_F7",
"10,KEY_7,KEY_F8",
"11,KEY_8,KEY_F9",
"12,KEY_9,KEY_F10",
"13,KEY_0,KEY_F11",
"14,KEY_BACKSPACE,KEY_F12",
"15,KEY_TAB,",
"16,KEY_Q,",
"17,KEY_W,",
"18,KEY_E,",
"19,KEY_R,",
"20,KEY_T,",
"21,KEY_LEFT_BRACE,KEYPAD_7",
"22,KEY_BACKSLASH,KEYPAD_8",
"23,KEY_RIGHT_BRACE,KEYPAD_9",
"24,KEY_Y,KEYPAD_MINUS",
"25,KEY_U,",
"26,KEY_I,",
"27,KEY_O,KEY_PRINTSCREEN",
"28,KEY_P,KEY_SCROLL_LOCK",
"29,KEY_QUOTE,KEY_PAUSE",
"30,KEY_CAPS_LOCK,",
"31,KEY_A,MOUSE_LEFT",
"32,KEY_S,MOUSE_MID",
"33,KEY_D,MOUSE_RIGHT",
"34,KEY_F,",
"35,KEY_G,",
"36,KEY_HOME,KEYPAD_4",
"37,KEY_DELETE,KEYPAD_5",
"38,KEY_PAGE_UP,KEYPAD_6",
"39,KEY_H,KEYPAD_PLUS",
"40,KEY_J,",
"41,KEY_K,",
"42,KEY_L,",
"43,KEY_SEMICOLON,",
"44,KEY_ENTER,",
"45,KEY_LEFT_SHIFT,KEY_LEFT_SHIFT",
"46,KEY_Z,MACRO0",
"47,KEY_X,MACRO1",
"48,KEY_C,AUDIO_VOL_DOWN",
"49,KEY_V,AUDIO_VOL_UP",
"50,KEY_B,AUDIO_MUTE",
"51,KEY_END,KEYPAD_1",
"52,KEY_UP,KEYPAD_2",
"53,KEY_PAGE_DOWN,KEYPAD_3",
"54,KEY_N,KEYPAD_ENTER",
"55,KEY_M,",
"56,KEY_COMMA,",
"57,KEY_PERIOD,",
"58,KEY_SLASH,",
"59,KEY_RIGHT_SHIFT,KEY_RIGHT_SHIFT",
"60,KEY_LEFT_CTRL,KEY_LEFT_CTRL",
"61,KEY_LEFT_GUI,KEY_LEFT_GUI",
"62,KEY_LEFT_ALT,KEY_LEFT_ALT",
"63,KEY_FN,KEY_FN",
"64,KEY_SPACE,MACRO3",
"65,KEY_SPACE,MACRO4",
"66,KEY_LEFT,KEYPAD_0",
"67,KEY_DOWN,KEYPAD_0",
"68,KEY_RIGHT,KEYPAD_PERIOD",
"69,KEY_SPACE,KEYPAD_ENTER",
"70,KEY_SPACE,",
"71,KEY_FN,KEY_FN",
"72,KEY_RIGHT_ALT,KEY_RIGHT_ALT",
"73,KEY_RIGHT_GUI,KEY_RIGHT_GUI",
"74,KEY_RIGHT_CTRL,KEY_RIGHT_CTRL"
 };
            RGB = new int[6, 6]{
                //x,y,type,r,g,b
 {630,355,0x01,255,255,255},
 {530,355,0x01,255,255,255},
 {430,355,0x01,255,255,255},
 {330,355,0x01,255,255,255},
 {230,355,0x01,255,255,255},
 {130,355,0x01,255,255,255}
            };
        }
    }
    class GH60_revCNY : IMatrix
    {
        public GH60_revCNY()
        {
            this.PrintFlashAddress = 0;
            this.PrintEEpAddress = 281;
            this.eepromsize = 1024;
            this.flashsize = 0x7000;

            this.Name = "GH60_revCNY";
            this.ROWS = 5;
            this.COLS = 14;
            this.rowPins = new byte[5] { 5, 6, 7, 8, 23 };
            this.colPins = new byte[14] { 21, 20, 24, 10, 9, 4, 22, 0, 1, 14, 13, 12, 11, 3 };
            this.hexaKeys0 = new string[5, 14];
            this.hexaKeys1 = new string[5, 14];
            keycode = new string[106 * 2];
            for (int i = 0; i < keycode.Length; i++)
            { keycode[i] = ""; }
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
"17,KEY_Q,MOUSE_LEFT",
"18,KEY_W,KEY_UP",
"19,KEY_E,MOUSE_RIGHT",
"20,KEY_R,",
"21,KEY_T,",
"22,KEY_Y,",
"23,KEY_U,",
"24,KEY_I,",
"25,KEY_O,",
"26,KEY_P,",
"27,KEY_LEFT_BRACE,",
"28,KEY_RIGHT_BRACE,",
"29,KEY_BACKSLASH,KEY_BACKSLASH",
"30,KEY_CAPS_LOCK,KEY_CAPS_LOCK",
"31,KEY_A,KEY_LEFT",
"32,KEY_S,KEY_DOWN",
"33,KEY_D,KEY_RIGHT",
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
"57,KEY_SLASH,AUDIO_MUTE",
"58,KEY_RIGHT_SHIFT,KEY_RIGHT_SHIFT",
"86,KEY_CTRL,KEY_CTRL",
"88,KEY_FN,KEY_FN",
"91,KEY_ALT,KEY_ALT",
"93,KEY_SPACE,KEY_SPACE",
"97,KEY_RIGHT_ALT,KEY_RIGHT_ALT",
"99,KEY_FN,KEY_FN",
"102,KEY_FN,KEY_FN",
"104,KEY_RIGHT_CTRL,KEY_RIGHT_CTRL"
};
        }
    }
}
