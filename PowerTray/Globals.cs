using System;
using System.Collections.Generic;
using System.Text;

namespace PowerTray
{   
    class Globals
    {
        public static string APP_SETTINGS_FILE = "PTSettings.xml";


        public static System.Windows.Forms.Shortcut GetShortcutKey(string ShortcutString)
        {
            try
            {
                System.Windows.Forms.Shortcut retVal = new System.Windows.Forms.Shortcut();
                switch (ShortcutString.ToLower())
                {
                    case "alt0": retVal = System.Windows.Forms.Shortcut.Alt0; break;
                    case "alt1": retVal = System.Windows.Forms.Shortcut.Alt1; break;
                    case "alt2": retVal = System.Windows.Forms.Shortcut.Alt2; break;
                    case "alt3": retVal = System.Windows.Forms.Shortcut.Alt3; break;
                    case "alt4": retVal = System.Windows.Forms.Shortcut.Alt4; break;
                    case "alt5": retVal = System.Windows.Forms.Shortcut.Alt5; break;
                    case "alt6": retVal = System.Windows.Forms.Shortcut.Alt6; break;
                    case "alt7": retVal = System.Windows.Forms.Shortcut.Alt7; break;
                    case "alt8": retVal = System.Windows.Forms.Shortcut.Alt8; break;
                    case "alt9": retVal = System.Windows.Forms.Shortcut.Alt9; break;
                    case "altbksp": retVal = System.Windows.Forms.Shortcut.AltBksp; break;
                    case "altdownArrow": retVal = System.Windows.Forms.Shortcut.AltDownArrow; break;
                    case "altf1": retVal = System.Windows.Forms.Shortcut.AltF1; break;
                    case "altf10": retVal = System.Windows.Forms.Shortcut.AltF10; break;
                    case "altf11": retVal = System.Windows.Forms.Shortcut.AltF11; break;
                    case "altf12": retVal = System.Windows.Forms.Shortcut.AltF12; break;
                    case "altf2": retVal = System.Windows.Forms.Shortcut.AltF2; break;
                    case "altf3": retVal = System.Windows.Forms.Shortcut.AltF3; break;
                    case "altf4": retVal = System.Windows.Forms.Shortcut.AltF4; break;
                    case "altf5": retVal = System.Windows.Forms.Shortcut.AltF5; break;
                    case "altf6": retVal = System.Windows.Forms.Shortcut.AltF6; break;
                    case "altf7": retVal = System.Windows.Forms.Shortcut.AltF7; break;
                    case "altf8": retVal = System.Windows.Forms.Shortcut.AltF8; break;
                    case "altf9": retVal = System.Windows.Forms.Shortcut.AltF9; break;
                    case "altleftArrow": retVal = System.Windows.Forms.Shortcut.AltLeftArrow; break;
                    case "altrightArrow": retVal = System.Windows.Forms.Shortcut.AltRightArrow; break;
                    case "altupArrow": retVal = System.Windows.Forms.Shortcut.AltUpArrow; break;
                    case "ctrl0": retVal = System.Windows.Forms.Shortcut.Ctrl0; break;
                    case "ctrl1": retVal = System.Windows.Forms.Shortcut.Ctrl1; break;
                    case "ctrl2": retVal = System.Windows.Forms.Shortcut.Ctrl2; break;
                    case "ctrl3": retVal = System.Windows.Forms.Shortcut.Ctrl3; break;
                    case "ctrl4": retVal = System.Windows.Forms.Shortcut.Ctrl4; break;
                    case "ctrl5": retVal = System.Windows.Forms.Shortcut.Ctrl5; break;
                    case "ctrl6": retVal = System.Windows.Forms.Shortcut.Ctrl6; break;
                    case "ctrl7": retVal = System.Windows.Forms.Shortcut.Ctrl7; break;
                    case "ctrl8": retVal = System.Windows.Forms.Shortcut.Ctrl8; break;
                    case "ctrl9": retVal = System.Windows.Forms.Shortcut.Ctrl9; break;
                    case "ctrla": retVal = System.Windows.Forms.Shortcut.CtrlA; break;
                    case "ctrlb": retVal = System.Windows.Forms.Shortcut.CtrlB; break;
                    case "ctrlc": retVal = System.Windows.Forms.Shortcut.CtrlC; break;
                    case "ctrld": retVal = System.Windows.Forms.Shortcut.CtrlD; break;
                    case "ctrldel": retVal = System.Windows.Forms.Shortcut.CtrlDel; break;
                    case "ctrle": retVal = System.Windows.Forms.Shortcut.CtrlE; break;
                    case "ctrlf": retVal = System.Windows.Forms.Shortcut.CtrlF; break;
                    case "ctrlf1": retVal = System.Windows.Forms.Shortcut.CtrlF1; break;
                    case "ctrlf10": retVal = System.Windows.Forms.Shortcut.CtrlF10; break;
                    case "ctrlf11": retVal = System.Windows.Forms.Shortcut.CtrlF11; break;
                    case "ctrlf12": retVal = System.Windows.Forms.Shortcut.CtrlF12; break;
                    case "ctrlf2": retVal = System.Windows.Forms.Shortcut.CtrlF2; break;
                    case "ctrlf3": retVal = System.Windows.Forms.Shortcut.CtrlF3; break;
                    case "ctrlf4": retVal = System.Windows.Forms.Shortcut.CtrlF4; break;
                    case "ctrlf5": retVal = System.Windows.Forms.Shortcut.CtrlF5; break;
                    case "ctrlf6": retVal = System.Windows.Forms.Shortcut.CtrlF6; break;
                    case "ctrlf7": retVal = System.Windows.Forms.Shortcut.CtrlF7; break;
                    case "ctrlf8": retVal = System.Windows.Forms.Shortcut.CtrlF8; break;
                    case "ctrlf9": retVal = System.Windows.Forms.Shortcut.CtrlF9; break;
                    case "ctrlg": retVal = System.Windows.Forms.Shortcut.CtrlG; break;
                    case "ctrlh": retVal = System.Windows.Forms.Shortcut.CtrlH; break;
                    case "ctrli": retVal = System.Windows.Forms.Shortcut.CtrlI; break;
                    case "ctrlins": retVal = System.Windows.Forms.Shortcut.CtrlIns; break;
                    case "ctrlj": retVal = System.Windows.Forms.Shortcut.CtrlJ; break;
                    case "ctrlk": retVal = System.Windows.Forms.Shortcut.CtrlK; break;
                    case "ctrll": retVal = System.Windows.Forms.Shortcut.CtrlL; break;
                    case "ctrlm": retVal = System.Windows.Forms.Shortcut.CtrlM; break;
                    case "ctrln": retVal = System.Windows.Forms.Shortcut.CtrlN; break;
                    case "ctrlo": retVal = System.Windows.Forms.Shortcut.CtrlO; break;
                    case "ctrlp": retVal = System.Windows.Forms.Shortcut.CtrlP; break;
                    case "ctrlq": retVal = System.Windows.Forms.Shortcut.CtrlQ; break;
                    case "ctrlr": retVal = System.Windows.Forms.Shortcut.CtrlR; break;
                    case "ctrls": retVal = System.Windows.Forms.Shortcut.CtrlS; break;
                    case "ctrlt": retVal = System.Windows.Forms.Shortcut.CtrlT; break;
                    case "ctrlu": retVal = System.Windows.Forms.Shortcut.CtrlU; break;
                    case "ctrlv": retVal = System.Windows.Forms.Shortcut.CtrlV; break;
                    case "ctrlw": retVal = System.Windows.Forms.Shortcut.CtrlW; break;
                    case "ctrlx": retVal = System.Windows.Forms.Shortcut.CtrlX; break;
                    case "ctrly": retVal = System.Windows.Forms.Shortcut.CtrlY; break;
                    case "ctrlz": retVal = System.Windows.Forms.Shortcut.CtrlZ; break;
                    case "ctrlshift0": retVal = System.Windows.Forms.Shortcut.CtrlShift0; break;
                    case "ctrlshift1": retVal = System.Windows.Forms.Shortcut.CtrlShift1; break;
                    case "ctrlshift2": retVal = System.Windows.Forms.Shortcut.CtrlShift2; break;
                    case "ctrlshift3": retVal = System.Windows.Forms.Shortcut.CtrlShift3; break;
                    case "ctrlshift4": retVal = System.Windows.Forms.Shortcut.CtrlShift4; break;
                    case "ctrlshift5": retVal = System.Windows.Forms.Shortcut.CtrlShift5; break;
                    case "ctrlshift6": retVal = System.Windows.Forms.Shortcut.CtrlShift6; break;
                    case "ctrlshift7": retVal = System.Windows.Forms.Shortcut.CtrlShift7; break;
                    case "ctrlshift8": retVal = System.Windows.Forms.Shortcut.CtrlShift8; break;
                    case "ctrlshift9": retVal = System.Windows.Forms.Shortcut.CtrlShift9; break;
                    case "ctrlshifta": retVal = System.Windows.Forms.Shortcut.CtrlShiftA; break;
                    case "ctrlshiftb": retVal = System.Windows.Forms.Shortcut.CtrlShiftB; break;
                    case "ctrlshiftc": retVal = System.Windows.Forms.Shortcut.CtrlShiftC; break;
                    case "ctrlshiftd": retVal = System.Windows.Forms.Shortcut.CtrlShiftD; break;
                    case "ctrlshifte": retVal = System.Windows.Forms.Shortcut.CtrlShiftE; break;
                    case "ctrlshiftf": retVal = System.Windows.Forms.Shortcut.CtrlShiftF; break;
                    case "ctrlshiftf1": retVal = System.Windows.Forms.Shortcut.CtrlShiftF1; break;
                    case "ctrlshiftf10": retVal = System.Windows.Forms.Shortcut.CtrlShiftF10; break;
                    case "ctrlshiftf11": retVal = System.Windows.Forms.Shortcut.CtrlShiftF11; break;
                    case "ctrlshiftf12": retVal = System.Windows.Forms.Shortcut.CtrlShiftF12; break;
                    case "ctrlshiftf2": retVal = System.Windows.Forms.Shortcut.CtrlShiftF2; break;
                    case "ctrlshiftf3": retVal = System.Windows.Forms.Shortcut.CtrlShiftF3; break;
                    case "ctrlshiftf4": retVal = System.Windows.Forms.Shortcut.CtrlShiftF4; break;
                    case "ctrlshiftf5": retVal = System.Windows.Forms.Shortcut.CtrlShiftF5; break;
                    case "ctrlshiftf6": retVal = System.Windows.Forms.Shortcut.CtrlShiftF6; break;
                    case "ctrlshiftf7": retVal = System.Windows.Forms.Shortcut.CtrlShiftF7; break;
                    case "ctrlshiftf8": retVal = System.Windows.Forms.Shortcut.CtrlShiftF8; break;
                    case "ctrlshiftf9": retVal = System.Windows.Forms.Shortcut.CtrlShiftF9; break;
                    case "ctrlshiftg": retVal = System.Windows.Forms.Shortcut.CtrlShiftG; break;
                    case "ctrlshifth": retVal = System.Windows.Forms.Shortcut.CtrlShiftH; break;
                    case "ctrlshifti": retVal = System.Windows.Forms.Shortcut.CtrlShiftI; break;
                    case "ctrlshiftj": retVal = System.Windows.Forms.Shortcut.CtrlShiftJ; break;
                    case "ctrlshiftk": retVal = System.Windows.Forms.Shortcut.CtrlShiftK; break;
                    case "ctrlshiftl": retVal = System.Windows.Forms.Shortcut.CtrlShiftL; break;
                    case "ctrlshiftm": retVal = System.Windows.Forms.Shortcut.CtrlShiftM; break;
                    case "ctrlshiftn": retVal = System.Windows.Forms.Shortcut.CtrlShiftN; break;
                    case "ctrlshifto": retVal = System.Windows.Forms.Shortcut.CtrlShiftO; break;
                    case "ctrlshiftp": retVal = System.Windows.Forms.Shortcut.CtrlShiftP; break;
                    case "ctrlshiftq": retVal = System.Windows.Forms.Shortcut.CtrlShiftQ; break;
                    case "ctrlshiftr": retVal = System.Windows.Forms.Shortcut.CtrlShiftR; break;
                    case "ctrlshifts": retVal = System.Windows.Forms.Shortcut.CtrlShiftS; break;
                    case "ctrlshiftt": retVal = System.Windows.Forms.Shortcut.CtrlShiftT; break;
                    case "ctrlshiftu": retVal = System.Windows.Forms.Shortcut.CtrlShiftU; break;
                    case "ctrlshiftv": retVal = System.Windows.Forms.Shortcut.CtrlShiftV; break;
                    case "ctrlshiftw": retVal = System.Windows.Forms.Shortcut.CtrlShiftW; break;
                    case "ctrlshiftx": retVal = System.Windows.Forms.Shortcut.CtrlShiftX; break;
                    case "ctrlshifty": retVal = System.Windows.Forms.Shortcut.CtrlShiftY; break;
                    case "ctrlshiftz": retVal = System.Windows.Forms.Shortcut.CtrlShiftZ; break;
                    case "f1": retVal = System.Windows.Forms.Shortcut.F1; break;
                    case "f10": retVal = System.Windows.Forms.Shortcut.F10; break;
                    case "f11": retVal = System.Windows.Forms.Shortcut.F11; break;
                    case "f12": retVal = System.Windows.Forms.Shortcut.F12; break;
                    case "f2": retVal = System.Windows.Forms.Shortcut.F2; break;
                    case "f3": retVal = System.Windows.Forms.Shortcut.F3; break;
                    case "f4": retVal = System.Windows.Forms.Shortcut.F4; break;
                    case "f5": retVal = System.Windows.Forms.Shortcut.F5; break;
                    case "f6": retVal = System.Windows.Forms.Shortcut.F6; break;
                    case "f7": retVal = System.Windows.Forms.Shortcut.F7; break;
                    case "f8": retVal = System.Windows.Forms.Shortcut.F8; break;
                    case "f9": retVal = System.Windows.Forms.Shortcut.F9; break;
                    case "shiftdel": retVal = System.Windows.Forms.Shortcut.ShiftDel; break;
                    case "shiftf1": retVal = System.Windows.Forms.Shortcut.ShiftF1; break;
                    case "shiftf10": retVal = System.Windows.Forms.Shortcut.ShiftF10; break;
                    case "shiftf11": retVal = System.Windows.Forms.Shortcut.ShiftF11; break;
                    case "shiftf12": retVal = System.Windows.Forms.Shortcut.ShiftF12; break;
                    case "shiftf2": retVal = System.Windows.Forms.Shortcut.ShiftF2; break;
                    case "shiftf3": retVal = System.Windows.Forms.Shortcut.ShiftF3; break;
                    case "shiftf4": retVal = System.Windows.Forms.Shortcut.ShiftF4; break;
                    case "shiftf5": retVal = System.Windows.Forms.Shortcut.ShiftF5; break;
                    case "shiftf6": retVal = System.Windows.Forms.Shortcut.ShiftF6; break;
                    case "shiftf7": retVal = System.Windows.Forms.Shortcut.ShiftF7; break;
                    case "shiftf8": retVal = System.Windows.Forms.Shortcut.ShiftF8; break;
                    case "shiftf9": retVal = System.Windows.Forms.Shortcut.ShiftF9; break;
                    case "shiftins": retVal = System.Windows.Forms.Shortcut.ShiftIns; break;
                }
                return retVal;
            }
            catch (Exception ex)
            {
                //TODO: Proper exception handling Code
                throw ex;
            }
        }
    }
}
