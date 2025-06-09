using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOYI
{
    public partial class FrameDecoder
    {
        //public enum FRAME_MODE
        //{
        //    STANDARD,
        //    EXTENDED,
        //    LUA
        //}

        int FRAME_SIZE = 18;
        byte BIT_4 = 0x10;
        byte[] OL = new byte[] { 0x10, 0x00, 0x61, 0xEB, 0x00 };

        // STD, EXT
        public string? Value { get; private set; }
        // STD
        public string? Label { get; private set; }
        // EXT
        public string? Unit1 { get; private set; }
        // STD, EXT
        public string? Unit2 { get; private set; }
        // EXT
        public string? Mode1 { get; private set; }
        // EXT
        public string? Mode2 { get; private set; }
        // EXT
        public string? Freq { get; private set; }
        // EXT
        public string? Freq_unit { get; private set; }

        private MLua mLua;

        public FrameDecoder()
        {
            mLua = new MLua();
        }

        /*
         * 
         */
        public void DecodeStdandard(String frame)
        {
            string[] label_value = frame.Split(':');
            // label, unit2
            string[] ret = new string[2];

            Value = label_value[1];

            switch (label_value[0])
            {
                case "Electricity":
                    ret[0] = "Ampery";
                    ret[1] += "A";
                    break;
                case "AElectricity":
                    ret[0] = "Ampery";
                    ret[1] = "A";
                    break;
                case "mAElectricity":
                    ret[0] = "Ampery";
                    ret[1] = "mA";
                    break;
                case "MOMResistance":
                    ret[0] = "Rezystancja";
                    ret[1] = "MΩ";
                    break;
                case "OMResistance":
                    ret[0] = "Rezystancja";
                    ret[1] = "Ω";
                    break;
                case "KOMResistance":
                    ret[0] = "Rezystancja";
                    ret[1] = "KΩ";
                    break;
                case "OMbeep":
                    ret[0] = "Buzzer";
                    ret[1] = "";
                    break;
                case "VDiode":
                    ret[0] = "Tryb diody";
                    ret[1] = "mV";
                    if (!ret[1].Contains("0,"))
                        ret[1] = "V";
                    break;
                case "nFCap":
                    ret[0] = "Pojemność nF";
                    ret[1] = "nF";
                    break;
                case "uFCap":
                    ret[0] = "Pojemność uF";
                    ret[1] = "uF";
                    break;
                case "mFCap":
                    ret[0] = "Pojemność mF";
                    ret[1] = "mF";
                    break;
                case "VVoltage":
                    ret[0] = "DC Voltage";
                    ret[1] = "DC";
                    break;
                default:
                    ret[0] = label_value[0];
                    ret[1] = "";
                    break;
            }

            Label = ret[0];
            Unit2 = ret[1];
        }

        /*
         * Extended
         */
        public void DecodeExtended(byte[] frame)
        {
            DecodeDigits(frame);
            DecodeUnit(frame);
            DecodeMode(frame);
            DecodeFreq(frame);

            Label = Mode2;

            //Console.WriteLine($"{Value} {Unit2} {Mode2} {Freq} {Mode1}");
        }

        private void DecodeDigits(byte[] frame)
        {
            // space for minus/avoid shifting values
            Value = " ";

            if (new ArraySegment<byte>(frame, 1, 5).SequenceEqual(OL))
            {
                Value = "OL";
                return;
            }

            for (int i = 5; i > 0; i--)
            {
                if ((frame[i] & BIT_4) > 0)
                {
                    if (i == 5)
                    {
                        Value += "-";
                    }
                    else
                    {
                        Value += ".";
                    }
                    frame[i] ^= BIT_4;
                }

                Value += DecodeDigit(frame[i]);
            }
        }

        private void DecodeUnit(byte[] frame)
        {
            Unit1 = "";
            Unit2 = "";

            byte unit1 = frame[15];
            byte unit2 = frame[16];

            switch (unit1)
            {
                case 0x40:
                    Unit1 = "n";
                    break;
                case 0x80:
                    Unit1 = "u";
                    break;
                case 0x0C:
                    Unit1 = "m";
                    break;
            }

            switch (unit2)
            {
                case 0x01:
                    Unit2 = "A";
                    break;
                case 0x02:
                    Unit2 = "V";
                    break;
                case 0x04:
                    Unit2 = "F";
                    break;
                case 0x09:
                    Unit2 = "mA";
                    break;
                case 0x0A:
                    Unit2 = "mV";
                    break;
                case 0x40:
                    Unit2 = "Ω";
                    break;
                case 0x50:
                    Unit2 = "MΩ";
                    break;
                case 0x60:
                    Unit2 = "kΩ";
                    break;
            }

            if (Unit2 == "F")
            {
                Unit2 = Unit1 + Unit2;
            }
        }

        private void DecodeMode(byte[] frame)
        {
            Mode1 = "";
            Mode2 = "";
            Freq_unit = "";

            byte mode1 = frame[10];
            byte mode2 = frame[11];

            byte AUTO = 0x04;
            byte DC = 0x10;
            byte AC = 0x40;
            byte HOLD = 0x80;

            if ((mode2 & AUTO) > 0)
                Mode2 += " AUTO";
            else
                Mode2 += " MANUAL";

            if ((mode2 & DC) > 0)
                Mode2 += " DC";
            else if ((mode2 & AC) > 0)
                Mode2 += " AC";

            if ((mode2 & HOLD) > 0)
                Mode2 += " HOLD";


            byte Hz = 0x02;
            byte kHz = 0x3;
            byte RELATIVE_M = 0x20;
            byte CONTINUE = 0x40;
            byte DIODE = 0x80;

            if ((mode1 & Hz) > 0)
                Freq_unit = "HZ";
            else if ((mode1 & kHz) > 0)
                Freq_unit = "kHz";
            else if ((mode1 & RELATIVE_M) > 0)
                Mode1 = "RELATIVE";
            else if ((mode1 & CONTINUE) > 0)
                Mode1 = "CONTINUE";
            else if ((mode1 & DIODE) > 0)
                Mode1 = "DIODE";
        }

        private void DecodeFreq(byte[] frame)
        {
            Freq = "";

            for (int i = 9; i >= 6; i--)
            {
                if ((frame[i] & BIT_4) > 0)
                {
                    Freq += ".";
                    frame[i] ^= BIT_4;
                }
                Freq += DecodeDigit(frame[i]);
            }
        }

        private char DecodeDigit(byte hex)
        {
            switch (hex)
            {
                case 0xEB: return '0';
                case 0x0A: return '1';
                case 0xAD: return '2';
                case 0x8F: return '3';
                case 0x4E: return '4';
                case 0xC7: return '5';
                case 0xE7: return '6';
                case 0x8A: return '7';
                case 0xEF: return '8';
                case 0xCF: return '9';
                default: return ' ';
            }
        }

        /*
         * JSON
         */
        public string JsonSerialize()
        {
            var retMembers = new
            {
                Value = this.Value,
                Label = this.Label,
                Unit1 = this.Unit1,
                Unit2 = this.Unit2,
                Mode1 = this.Mode1,
                Mode2 = this.Mode2,
                Freq = this.Freq,
                Freq_unit = this.Freq_unit
            };

            return JsonSerializer.Serialize(retMembers);
        }


        /*
         * LUA
         */
        public void DecodeLua(String frame)
        {
            string[] ret = mLua.parseLabelValueSuffix_LUA(frame);

            Label = ret[0];
            Value = ret[1];
            Unit2 = ret[2];
        }

        public void LuaReload(String path)
        {
            mLua.LuaReload(path);
        }

        public void luaHighlightRichTextBox(string code, RichTextBox rtbEditor)
        {
            mLua.luaHighlightRichTextBox(code, rtbEditor);
        }
    }
}
