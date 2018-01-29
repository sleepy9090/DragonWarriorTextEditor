using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 2016, 2017, 2018+
 */
namespace DragonWarriorTextEditor {
    class Backend {

        // 0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ“”'*:$.,-?!;)(<’>
        // @ pointer to the character's name
        // # pointer to the enemy, e.g. The ё’s Hitϋ have been reduced by %.
        // % pointer to numeric amount, e.g. Imperial Scroll number, Gold amount, maximum hit points increase by, etc
        // & pointer to the spell that was used
        // + pointer to the item
        // < Thy Maximum Hitϋ increase by %.,  Thy Maximum Magicϋ increase by %.
        // = pointer to enemy e.g. Aш draws near!
        // | pointer to experience points e.g. ‘Before reaching thy next level of experience thou must gain Ě.’
        // ~ New line
        // > Cursor pointing right
        // _ Cursor pointing down
        // ^ equals .’

        int textFlag = 0;
        string path;

        public Backend(string gamePath)
        {
            path = gamePath;
        }

        #region common methods
        private static string convertAsciiToHex(String asciiString)
        {
            char[] charValues = asciiString.ToCharArray();
            string hexValue = "";
            foreach(char c in charValues)
            {
                int value = Convert.ToInt32(c);
                hexValue += String.Format("{0:X}", value);
            }
            return hexValue;
        }

        private static string convertHexToAscii(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for(int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch(Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        private string getHexStringFromFile(int startPoint, int length)
        {
            string hexString = "";
            using(FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read))
            {
                long offset = fileStream.Seek(startPoint, SeekOrigin.Begin);

                for(int x = 0; x < length; x++)
                {
                    hexString += fileStream.ReadByte().ToString("X2");
                }

            }

            return hexString;
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private bool writeByteArrayToFile(string fileName, int startPoint, byte[] byteArray)
        {
            bool result = false;
            try
            {
                using(var fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs.Position = startPoint;
                    fs.Write(byteArray, 0, byteArray.Length);
                    result = true;
                }
            }
            catch(Exception ex)
            {
                // Console.WriteLine("Error writing file: {0}", ex);
                result = false;
            }

            return result;
        }
        #endregion

        public string getROMText(int length, int offset, int decodeOption) {

            string romCodeString = "";
            string dragonWarriorAsciiOut = "";
            string tempHexString = "";
            int x = 0;
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read)) {
                try {
                    fileStream.Seek(offset, SeekOrigin.Begin);

                    while (x < length) {
                        romCodeString = fileStream.ReadByte().ToString("X");
                        //if length is single digit add a 0 ( 1 now is 01)
                        if (romCodeString.Length == 1) {
                            romCodeString = "0" + romCodeString;
                        }
                        tempHexString = romCodeString;
                        if (decodeOption == 0) {
                            decodeRomText1(tempHexString);
                            if (textFlag == 0) {
                                dragonWarriorAsciiOut += decodeRomText1(tempHexString);
                            }
                        }
                        else if (decodeOption == 1)
                        {
                            decodeRomText2(tempHexString);
                            if (textFlag == 0) {
                                dragonWarriorAsciiOut += decodeRomText2(tempHexString);
                            }
                        }
                        else if (decodeOption == 2)
                        {
                            decodeRomText3(tempHexString);
                            if (textFlag == 0)
                            {
                                dragonWarriorAsciiOut += decodeRomText3(tempHexString);
                            }
                        }

                        x++;

                    }

                    fileStream.Close();
                } catch (Exception e) {
                    // TODO: Bubble up the error message
                    // MessageBox.Show("Error: " + e, "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dragonWarriorAsciiOut;
        }

        public void updateROMText(int length, string newDragonWarriorString, int offset, int encodeOption) {
            // TODO: Optimize/refactor, this is ugly
            // TODO: padding on newDragonWarriorString
            //string newDragonWarriorString = textBox.Text;

            newDragonWarriorString = newDragonWarriorString.PadRight(length);
            string hexReturn = "";
            string tempascii = "";
            string[] newDragonWarriorStringArray = new string[length];
            byte[] newDragonWarriorStringByteArray = new byte[length];
            int[] dragonWarriorDecimal = new int[length];
            string[] dragonWarriorFinal = new string[length];
            string[] dragonWarriorS = new string[length];

            int x = 0;
            while (x < length) {
                newDragonWarriorStringArray[x] = newDragonWarriorString[x].ToString();
                tempascii = newDragonWarriorStringArray[x];
                if (encodeOption == 0) {
                    hexReturn += encodeRomText1(tempascii);
                } else  if (encodeOption == 1) {
                    hexReturn += encodeRomText2(tempascii);
                } else  if (encodeOption == 2) {
                    hexReturn += encodeRomText3(tempascii);
                }
                
                x++;
            }

            int i = 0;
            int j = 0;
            while (i < length) {
                dragonWarriorS[i] = hexReturn[j].ToString() + hexReturn[j + 1].ToString();
                i++;
                j += 2;
            }

            x = 0;
            while (x < length) {
                dragonWarriorDecimal[x] = int.Parse(dragonWarriorS[x], System.Globalization.NumberStyles.HexNumber);
                dragonWarriorFinal[x] = dragonWarriorDecimal[x].ToString();
                newDragonWarriorStringByteArray[x] = byte.Parse(dragonWarriorFinal[x]);
                x++;
            }

            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Write)) {
                try {
                    fileStream.Seek(offset, SeekOrigin.Begin);
                    x = 0;
                    while (x < length) {
                        fileStream.WriteByte(newDragonWarriorStringByteArray[x]);
                        x++;
                    }
                } catch (Exception e) {
                    // TODO: Bubble up the error message
                    // MessageBox.Show("Error: " + e, "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Main decode table
        private string decodeRomText1(string tempHexString) {
            string dragonWarriorAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "00":
                    dragonWarriorAscii += "0";
                    break;
                case "01":
                    dragonWarriorAscii += "1";
                    break;
                case "02":
                    dragonWarriorAscii += "2";
                    break;
                case "03":
                    dragonWarriorAscii += "3";
                    break;
                case "04":
                    dragonWarriorAscii += "4";
                    break;
                case "05":
                    dragonWarriorAscii += "5";
                    break;
                case "06":
                    dragonWarriorAscii += "6";
                    break;
                case "07":
                    dragonWarriorAscii += "7";
                    break;
                case "08":
                    dragonWarriorAscii += "8";
                    break;
                case "09":
                    dragonWarriorAscii += "9";
                    break;
                case "0A":
                    dragonWarriorAscii += "a";
                    break;
                case "0B":
                    dragonWarriorAscii += "b";
                    break;
                case "0C":
                    dragonWarriorAscii += "c";
                    break;
                case "0D":
                    dragonWarriorAscii += "d";
                    break;
                case "0E":
                    dragonWarriorAscii += "e";
                    break;
                case "0F":
                    dragonWarriorAscii += "f";
                    break;
                case "10":
                    dragonWarriorAscii += "g";
                    break;
                case "11":
                    dragonWarriorAscii += "h";
                    break;
                case "12":
                    dragonWarriorAscii += "i";
                    break;
                case "13":
                    dragonWarriorAscii += "j";
                    break;
                case "14":
                    dragonWarriorAscii += "k";
                    break;
                case "15":
                    dragonWarriorAscii += "l";
                    break;
                case "16":
                    dragonWarriorAscii += "m";
                    break;
                case "17":
                    dragonWarriorAscii += "n";
                    break;
                case "18":
                    dragonWarriorAscii += "o";
                    break;
                case "19":
                    dragonWarriorAscii += "p";
                    break;
                case "1A":
                    dragonWarriorAscii += "q";
                    break;
                case "1B":
                    dragonWarriorAscii += "r";
                    break;
                case "1C":
                    dragonWarriorAscii += "s";
                    break;
                case "1D":
                    dragonWarriorAscii += "t";
                    break;
                case "1E":
                    dragonWarriorAscii += "u";
                    break;
                case "1F":
                    dragonWarriorAscii += "v";
                    break;
                case "20":
                    dragonWarriorAscii += "w";
                    break;
                case "21":
                    dragonWarriorAscii += "x";
                    break;
                case "22":
                    dragonWarriorAscii += "y";
                    break;
                case "23":
                    dragonWarriorAscii += "z";
                    break;
                case "24":
                    dragonWarriorAscii += "A";
                    break;
                case "25":
                    dragonWarriorAscii += "B";
                    break;
                case "26":
                    dragonWarriorAscii += "C";
                    break;
                case "27":
                    dragonWarriorAscii += "D";
                    break;
                case "28":
                    dragonWarriorAscii += "E";
                    break;
                case "29":
                    dragonWarriorAscii += "F";
                    break;
                case "2A":
                    dragonWarriorAscii += "G";
                    break;
                case "2B":
                    dragonWarriorAscii += "H";
                    break;
                case "2C":
                    dragonWarriorAscii += "I";
                    break;
                case "2D":
                    dragonWarriorAscii += "J";
                    break;
                case "2E":
                    dragonWarriorAscii += "K";
                    break;
                case "2F":
                    dragonWarriorAscii += "L";
                    break;
                case "30":
                    dragonWarriorAscii += "M";
                    break;
                case "31":
                    dragonWarriorAscii += "N";
                    break;
                case "32":
                    dragonWarriorAscii += "O";
                    break;
                case "33":
                    dragonWarriorAscii += "P";
                    break;
                case "34":
                    dragonWarriorAscii += "Q";
                    break;
                case "35":
                    dragonWarriorAscii += "R";
                    break;
                case "36":
                    dragonWarriorAscii += "S";
                    break;
                case "37":
                    dragonWarriorAscii += "T";
                    break;
                case "38":
                    dragonWarriorAscii += "U";
                    break;
                case "39":
                    dragonWarriorAscii += "V";
                    break;
                case "3A":
                    dragonWarriorAscii += "W";
                    break;
                case "3B":
                    dragonWarriorAscii += "X";
                    break;
                case "3C":
                    dragonWarriorAscii += "Y";
                    break;
                case "3D":
                    dragonWarriorAscii += "Z";
                    break;
                case "3E":
                    dragonWarriorAscii += "“";
                    break;
                case "3F":
                    dragonWarriorAscii += "”";
                    break;
                case "40":
                    dragonWarriorAscii += "'";
                    break;
                case "41":
                    dragonWarriorAscii += "*";
                    break;
                case "42":
                    // Cursor pointing right
                    dragonWarriorAscii += ">";
                    break;
                case "43":
                    // Cursor pointing down
                    dragonWarriorAscii += "_";
                    break;
                case "44":
                    dragonWarriorAscii += ":";
                    break;
                case "45":
                    // Represent .. with $
                    dragonWarriorAscii += "$";
                    // dragonWarriorAscii += "..";
                    break;
                case "47":
                    dragonWarriorAscii += ".";
                    break;
                case "48":
                    dragonWarriorAscii += ",";
                    break;
                case "49":
                    dragonWarriorAscii += "-";
                    break;
                case "4B":
                    dragonWarriorAscii += "?";
                    break;
                case "4C":
                    dragonWarriorAscii += "!";
                    break;
                case "4D":
                    dragonWarriorAscii += ";";
                    break;
                case "4E":
                    dragonWarriorAscii += ")";
                    break;
                case "4F":
                    dragonWarriorAscii += "(";
                    break;
                case "50":
                    dragonWarriorAscii += "‘";
                    break;
                case "51":
                    dragonWarriorAscii += "’";
                    break;
                case "52":
                    // Represent .’ with ^
                    dragonWarriorAscii += "^";
                    // dragonWarriorAscii += ".’";
                    break;
                case "53":
                    dragonWarriorAscii += "’";
                    break;
                case "54":
                    dragonWarriorAscii += "’";
                    break;
                case "5F":
                    dragonWarriorAscii += " ";
                    break;
                case "F8":
                    dragonWarriorAscii += "@"; // pointer to the character's name
                    break;
                case "F4":
                    dragonWarriorAscii += "#"; // pointer to the enemy, e.g. The #’s Hit< have been reduced by %.
                    break;
                case "F5":
                    dragonWarriorAscii += "%"; // pointer to numeric amount, e.g. Imperial Scroll number, Gold amount, maximum hit points increase by, etc
                    break;
                case "F6":
                    dragonWarriorAscii += "&"; // pointer to the spell that was used
                    break;
                case "F7":
                    dragonWarriorAscii += "+"; // pointer to the item
                    break;
                case "F0":
                    dragonWarriorAscii += "<"; // Thy Maximum Hit< increase by %.,  Thy Maximum Magic< increase by %.
                    break;
                case "F1":
                    dragonWarriorAscii += "="; // pointer to enemy e.g. A= draws near!
                    break;
                case "F3":
                    dragonWarriorAscii += "|"; // pointer to experience points e.g. ‘Before reaching thy next level of experience thou must gain |.’
                    break;
                case "FD":
                    dragonWarriorAscii += "~"; // New line
                    break;
                default:
                    dragonWarriorAscii += " ";
                    textFlag = 1;
                    break;
            }

            return dragonWarriorAscii;
        }

        // Title menu dialog screens decode table
        // Only difference appears to be the space.
        private string decodeRomText2(string tempHexString)
        {
            string dragonWarriorAscii = "";
            textFlag = 0;

            switch (tempHexString)
            {
                case "00":
                    dragonWarriorAscii += "0";
                    break;
                case "01":
                    dragonWarriorAscii += "1";
                    break;
                case "02":
                    dragonWarriorAscii += "2";
                    break;
                case "03":
                    dragonWarriorAscii += "3";
                    break;
                case "04":
                    dragonWarriorAscii += "4";
                    break;
                case "05":
                    dragonWarriorAscii += "5";
                    break;
                case "06":
                    dragonWarriorAscii += "6";
                    break;
                case "07":
                    dragonWarriorAscii += "7";
                    break;
                case "08":
                    dragonWarriorAscii += "8";
                    break;
                case "09":
                    dragonWarriorAscii += "9";
                    break;
                case "0A":
                    dragonWarriorAscii += "a";
                    break;
                case "0B":
                    dragonWarriorAscii += "b";
                    break;
                case "0C":
                    dragonWarriorAscii += "c";
                    break;
                case "0D":
                    dragonWarriorAscii += "d";
                    break;
                case "0E":
                    dragonWarriorAscii += "e";
                    break;
                case "0F":
                    dragonWarriorAscii += "f";
                    break;
                case "10":
                    dragonWarriorAscii += "g";
                    break;
                case "11":
                    dragonWarriorAscii += "h";
                    break;
                case "12":
                    dragonWarriorAscii += "i";
                    break;
                case "13":
                    dragonWarriorAscii += "j";
                    break;
                case "14":
                    dragonWarriorAscii += "k";
                    break;
                case "15":
                    dragonWarriorAscii += "l";
                    break;
                case "16":
                    dragonWarriorAscii += "m";
                    break;
                case "17":
                    dragonWarriorAscii += "n";
                    break;
                case "18":
                    dragonWarriorAscii += "o";
                    break;
                case "19":
                    dragonWarriorAscii += "p";
                    break;
                case "1A":
                    dragonWarriorAscii += "q";
                    break;
                case "1B":
                    dragonWarriorAscii += "r";
                    break;
                case "1C":
                    dragonWarriorAscii += "s";
                    break;
                case "1D":
                    dragonWarriorAscii += "t";
                    break;
                case "1E":
                    dragonWarriorAscii += "u";
                    break;
                case "1F":
                    dragonWarriorAscii += "v";
                    break;
                case "20":
                    dragonWarriorAscii += "w";
                    break;
                case "21":
                    dragonWarriorAscii += "x";
                    break;
                case "22":
                    dragonWarriorAscii += "y";
                    break;
                case "23":
                    dragonWarriorAscii += "z";
                    break;
                case "24":
                    dragonWarriorAscii += "A";
                    break;
                case "25":
                    dragonWarriorAscii += "B";
                    break;
                case "26":
                    dragonWarriorAscii += "C";
                    break;
                case "27":
                    dragonWarriorAscii += "D";
                    break;
                case "28":
                    dragonWarriorAscii += "E";
                    break;
                case "29":
                    dragonWarriorAscii += "F";
                    break;
                case "2A":
                    dragonWarriorAscii += "G";
                    break;
                case "2B":
                    dragonWarriorAscii += "H";
                    break;
                case "2C":
                    dragonWarriorAscii += "I";
                    break;
                case "2D":
                    dragonWarriorAscii += "J";
                    break;
                case "2E":
                    dragonWarriorAscii += "K";
                    break;
                case "2F":
                    dragonWarriorAscii += "L";
                    break;
                case "30":
                    dragonWarriorAscii += "M";
                    break;
                case "31":
                    dragonWarriorAscii += "N";
                    break;
                case "32":
                    dragonWarriorAscii += "O";
                    break;
                case "33":
                    dragonWarriorAscii += "P";
                    break;
                case "34":
                    dragonWarriorAscii += "Q";
                    break;
                case "35":
                    dragonWarriorAscii += "R";
                    break;
                case "36":
                    dragonWarriorAscii += "S";
                    break;
                case "37":
                    dragonWarriorAscii += "T";
                    break;
                case "38":
                    dragonWarriorAscii += "U";
                    break;
                case "39":
                    dragonWarriorAscii += "V";
                    break;
                case "3A":
                    dragonWarriorAscii += "W";
                    break;
                case "3B":
                    dragonWarriorAscii += "X";
                    break;
                case "3C":
                    dragonWarriorAscii += "Y";
                    break;
                case "3D":
                    dragonWarriorAscii += "Z";
                    break;
                case "3E":
                    dragonWarriorAscii += "“";
                    break;
                case "3F":
                    dragonWarriorAscii += "”";
                    break;
                case "40":
                    dragonWarriorAscii += "’";
                    break;
                case "41":
                    dragonWarriorAscii += "*";
                    break;
                case "42":
                    // Cursor pointing right
                    dragonWarriorAscii += ">";
                    break;
                case "43":
                    // Cursor pointing down
                    dragonWarriorAscii += "_";
                    break;
                case "44":
                    dragonWarriorAscii += ":";
                    break;
                case "45":
                    // Represent .. with $
                    dragonWarriorAscii += "$";
                    // dragonWarriorAscii += "..";
                    break;
                case "47":
                    dragonWarriorAscii += ".";
                    break;
                case "48":
                    dragonWarriorAscii += ",";
                    break;
                case "49":
                    dragonWarriorAscii += "-";
                    break;
                case "4B":
                    dragonWarriorAscii += "?";
                    break;
                case "4C":
                    dragonWarriorAscii += "!";
                    break;
                case "4D":
                    dragonWarriorAscii += ";";
                    break;
                case "4E":
                    dragonWarriorAscii += ")";
                    break;
                case "4F":
                    dragonWarriorAscii += "(";
                    break;
                case "50":
                    dragonWarriorAscii += "‘";
                    break;
                case "51":
                    dragonWarriorAscii += "‘";
                    break;
                case "52":
                    // Represent .’ with ^
                    dragonWarriorAscii += "^";
                    // dragonWarriorAscii += ".’";
                    break;
                case "53":
                    dragonWarriorAscii += "’";
                    // dragonWarriorAscii += " ’";
                    break;
                case "54":
                    dragonWarriorAscii += "’";
                    break;
                //case "5F": // On the title screen, this is a space in fceux debugger, but is 81 in a hex editor.
                //    dragonWarriorAscii += " ";
                //    break;
                case "81":
                    dragonWarriorAscii += " "; // On the title screen, this is a space.
                    break;
                case "F8":
                    dragonWarriorAscii += "@"; // pointer to the character's name
                    break;
                case "F4":
                    dragonWarriorAscii += "#"; // pointer to the enemy, e.g. The #’s Hit< have been reduced by %.
                    break;
                case "F5":
                    dragonWarriorAscii += "%"; // pointer to numeric amount, e.g. Imperial Scroll number, Gold amount, maximum hit points increase by, etc
                    break;
                case "F6":
                    dragonWarriorAscii += "&"; // pointer to the spell that was used
                    break;
                case "F7":
                    dragonWarriorAscii += "+"; // pointer to the item
                    break;
                case "F0":
                    dragonWarriorAscii += "<"; // Thy Maximum Hit< increase by %.,  Thy Maximum Magic< increase by %.
                    break;
                case "F1":
                    dragonWarriorAscii += "="; // pointer to enemy e.g. A= draws near!
                    break;
                case "F3":
                    dragonWarriorAscii += "|"; // pointer to experience points e.g. ‘Before reaching thy next level of experience thou must gain |.’
                    break;
                case "FD":
                    dragonWarriorAscii += "~"; // New line
                    break;
                default:
                    dragonWarriorAscii += " ";
                    textFlag = 1;
                    break;
            }

            return dragonWarriorAscii;
        }

        // Ending / Credits
        // . and ! is different here
        // TODO: lowercase is different here also
        private string decodeRomText3(string tempHexString)
        {
            string dragonWarriorAscii = "";
            textFlag = 0;

            switch (tempHexString)
            {
                case "00":
                    dragonWarriorAscii += "0";
                    break;
                case "01":
                    dragonWarriorAscii += "1";
                    break;
                case "02":
                    dragonWarriorAscii += "2";
                    break;
                case "03":
                    dragonWarriorAscii += "3";
                    break;
                case "04":
                    dragonWarriorAscii += "4";
                    break;
                case "05":
                    dragonWarriorAscii += "5";
                    break;
                case "06":
                    dragonWarriorAscii += "6";
                    break;
                case "07":
                    dragonWarriorAscii += "7";
                    break;
                case "08":
                    dragonWarriorAscii += "8";
                    break;
                case "09":
                    dragonWarriorAscii += "9";
                    break;
                case "0A":
                    dragonWarriorAscii += "a";
                    break;
                case "0B":
                    dragonWarriorAscii += "b";
                    break;
                case "0C":
                    dragonWarriorAscii += "c";
                    break;
                case "0D":
                    dragonWarriorAscii += "d";
                    break;
                case "0E":
                    dragonWarriorAscii += "e";
                    break;
                case "0F":
                    dragonWarriorAscii += "f";
                    break;
                case "10":
                    dragonWarriorAscii += "g";
                    break;
                case "11":
                    dragonWarriorAscii += "h";
                    break;
                case "12":
                    dragonWarriorAscii += "i";
                    break;
                case "13":
                    dragonWarriorAscii += "j";
                    break;
                case "14":
                    dragonWarriorAscii += "k";
                    break;
                case "15":
                    dragonWarriorAscii += "l";
                    break;
                case "16":
                    dragonWarriorAscii += "m";
                    break;
                case "17":
                    dragonWarriorAscii += "n";
                    break;
                case "18":
                    dragonWarriorAscii += "o";
                    break;
                case "19":
                    dragonWarriorAscii += "p";
                    break;
                case "1A":
                    dragonWarriorAscii += "q";
                    break;
                case "1B":
                    dragonWarriorAscii += "r";
                    break;
                case "1C":
                    dragonWarriorAscii += "s";
                    break;
                case "1D":
                    dragonWarriorAscii += "t";
                    break;
                case "1E":
                    dragonWarriorAscii += "u";
                    break;
                case "1F":
                    dragonWarriorAscii += "v";
                    break;
                case "20":
                    dragonWarriorAscii += "w";
                    break;
                case "21":
                    dragonWarriorAscii += "x";
                    break;
                case "22":
                    dragonWarriorAscii += "y";
                    break;
                case "23":
                    dragonWarriorAscii += "z";
                    break;
                case "24":
                    dragonWarriorAscii += "A";
                    break;
                case "25":
                    dragonWarriorAscii += "B";
                    break;
                case "26":
                    dragonWarriorAscii += "C";
                    break;
                case "27":
                    dragonWarriorAscii += "D";
                    break;
                case "28":
                    dragonWarriorAscii += "E";
                    break;
                case "29":
                    dragonWarriorAscii += "F";
                    break;
                case "2A":
                    dragonWarriorAscii += "G";
                    break;
                case "2B":
                    dragonWarriorAscii += "H";
                    break;
                case "2C":
                    dragonWarriorAscii += "I";
                    break;
                case "2D":
                    dragonWarriorAscii += "J";
                    break;
                case "2E":
                    dragonWarriorAscii += "K";
                    break;
                case "2F":
                    dragonWarriorAscii += "L";
                    break;
                case "30":
                    dragonWarriorAscii += "M";
                    break;
                case "31":
                    dragonWarriorAscii += "N";
                    break;
                case "32":
                    dragonWarriorAscii += "O";
                    break;
                case "33":
                    dragonWarriorAscii += "P";
                    break;
                case "34":
                    dragonWarriorAscii += "Q";
                    break;
                case "35":
                    dragonWarriorAscii += "R";
                    break;
                case "36":
                    dragonWarriorAscii += "S";
                    break;
                case "37":
                    dragonWarriorAscii += "T";
                    break;
                case "38":
                    dragonWarriorAscii += "U";
                    break;
                case "39":
                    dragonWarriorAscii += "V";
                    break;
                case "3A":
                    dragonWarriorAscii += "W";
                    break;
                case "3B":
                    dragonWarriorAscii += "X";
                    break;
                case "3C":
                    dragonWarriorAscii += "Y";
                    break;
                case "3D":
                    dragonWarriorAscii += "Z";
                    break;
                //case "3E":
                //    dragonWarriorAscii += "“";
                //    break;
                //case "3F":
                //    dragonWarriorAscii += "”";
                //    break;
                //case "40":
                //    dragonWarriorAscii += "'";
                //    break;
                //case "41":
                //    dragonWarriorAscii += "*";
                //    break;
                //case "42":
                //    // Cursor pointing right
                //    dragonWarriorAscii += ">";
                //    break;
                //case "43":
                //    // Cursor pointing down
                //    dragonWarriorAscii += "_";
                //    break;
                //case "44":
                //    dragonWarriorAscii += ":";
                //    break;
                //case "45":
                //    // Represent .. with $
                //    dragonWarriorAscii += "$";
                //    // dragonWarriorAscii += "..";
                //    break;
                ////case "47":
                ////    dragonWarriorAscii += ".";
                ////    break;
                //case "48":
                //    dragonWarriorAscii += ",";
                //    break;
                //case "49":
                //    dragonWarriorAscii += "-";
                //    break;
                //case "4B":
                //    dragonWarriorAscii += "?";
                //    break;
                ////case "4C":
                ////    dragonWarriorAscii += "!";
                ////    break;
                //case "4D":
                //    dragonWarriorAscii += ";";
                //    break;
                //case "4E":
                //    dragonWarriorAscii += ")";
                //    break;
                //case "4F":
                //    dragonWarriorAscii += "(";
                //    break;
                //case "50":
                //    dragonWarriorAscii += "‘";
                //    break;
                //case "51":
                //    dragonWarriorAscii += "’";
                //    break;
                //case "52":
                //    // Represent .’ with ^
                //    dragonWarriorAscii += "^";
                //    // dragonWarriorAscii += ".’";
                //    break;
                //case "53":
                //    dragonWarriorAscii += "’";
                //    break;
                //case "54":
                //    dragonWarriorAscii += "’";
                //    break;
                case "5F":
                    dragonWarriorAscii += " ";
                    break;
                case "60":
                    dragonWarriorAscii += "!";
                    break;
                case "61":
                    dragonWarriorAscii += ".";
                    break;
                //case "F8":
                //    dragonWarriorAscii += "@"; // pointer to the character's name
                //    break;
                //case "F4":
                //    dragonWarriorAscii += "#"; // pointer to the enemy, e.g. The #’s Hit< have been reduced by %.
                //    break;
                //case "F5":
                //    dragonWarriorAscii += "%"; // pointer to numeric amount, e.g. Imperial Scroll number, Gold amount, maximum hit points increase by, etc
                //    break;
                //case "F6":
                //    dragonWarriorAscii += "&"; // pointer to the spell that was used
                //    break;
                //case "F7":
                //    dragonWarriorAscii += "+"; // pointer to the item
                //    break;
                //case "F0":
                //    dragonWarriorAscii += "<"; // Thy Maximum Hit< increase by %.,  Thy Maximum Magic< increase by %.
                //    break;
                //case "F1":
                //    dragonWarriorAscii += "="; // pointer to enemy e.g. A= draws near!
                //    break;
                //case "F3":
                //    dragonWarriorAscii += "|"; // pointer to experience points e.g. ‘Before reaching thy next level of experience thou must gain |.’
                //    break;
                //case "FD":
                //    dragonWarriorAscii += "~"; // New line
                //    break;
                default:
                    dragonWarriorAscii += " ";
                    textFlag = 1;
                    break;
            }

            return dragonWarriorAscii;
        }

        // Main encode table
        private string encodeRomText1(string tempAscii) {
            string dragonWarriorHex = "";

            switch (tempAscii) {
                case "0":
                    dragonWarriorHex += "00";
                    break;
                case "1":
                    dragonWarriorHex += "01";
                    break;
                case "2":
                    dragonWarriorHex += "02";
                    break;
                case "3":
                    dragonWarriorHex += "03";
                    break;
                case "4":
                    dragonWarriorHex += "04";
                    break;
                case "5":
                    dragonWarriorHex += "05";
                    break;
                case "6":
                    dragonWarriorHex += "06";
                    break;
                case "7":
                    dragonWarriorHex += "07";
                    break;
                case "8":
                    dragonWarriorHex += "08";
                    break;
                case "9":
                    dragonWarriorHex += "09";
                    break;
                case "a":
                    dragonWarriorHex += "0A";
                    break;
                case "b":
                    dragonWarriorHex += "0B";
                    break;
                case "c":
                    dragonWarriorHex += "0C";
                    break;
                case "d":
                    dragonWarriorHex += "0D";
                    break;
                case "e":
                    dragonWarriorHex += "0E";
                    break;
                case "f":
                    dragonWarriorHex += "0F";
                    break;
                case "g":
                    dragonWarriorHex += "10";
                    break;
                case "h":
                    dragonWarriorHex += "11";
                    break;
                case "i":
                    dragonWarriorHex += "12";
                    break;
                case "j":
                    dragonWarriorHex += "13";
                    break;
                case "k":
                    dragonWarriorHex += "14";
                    break;
                case "l":
                    dragonWarriorHex += "15";
                    break;
                case "m":
                    dragonWarriorHex += "16";
                    break;
                case "n":
                    dragonWarriorHex += "17";
                    break;
                case "o":
                    dragonWarriorHex += "18";
                    break;
                case "p":
                    dragonWarriorHex += "19";
                    break;
                case "q":
                    dragonWarriorHex += "1A";
                    break;
                case "r":
                    dragonWarriorHex += "1B";
                    break;
                case "s":
                    dragonWarriorHex += "1C";
                    break;
                case "t":
                    dragonWarriorHex += "1D";
                    break;
                case "u":
                    dragonWarriorHex += "1E";
                    break;
                case "v":
                    dragonWarriorHex += "1F";
                    break;
                case "w":
                    dragonWarriorHex += "20";
                    break;
                case "x":
                    dragonWarriorHex += "21";
                    break;
                case "y":
                    dragonWarriorHex += "22";
                    break;
                case "z":
                    dragonWarriorHex += "23";
                    break;
                case "A":
                    dragonWarriorHex += "24";
                    break;
                case "B":
                    dragonWarriorHex += "25";
                    break;
                case "C":
                    dragonWarriorHex += "26";
                    break;
                case "D":
                    dragonWarriorHex += "27";
                    break;
                case "E":
                    dragonWarriorHex += "28";
                    break;
                case "F":
                    dragonWarriorHex += "29";
                    break;
                case "G":
                    dragonWarriorHex += "2A";
                    break;
                case "H":
                    dragonWarriorHex += "2B";
                    break;
                case "I":
                    dragonWarriorHex += "2C";
                    break;
                case "J":
                    dragonWarriorHex += "2D";
                    break;
                case "K":
                    dragonWarriorHex += "2E";
                    break;
                case "L":
                    dragonWarriorHex += "2F";
                    break;
                case "M":
                    dragonWarriorHex += "30";
                    break;
                case "N":
                    dragonWarriorHex += "31";
                    break;
                case "O":
                    dragonWarriorHex += "32";
                    break;
                case "P":
                    dragonWarriorHex += "33";
                    break;
                case "Q":
                    dragonWarriorHex += "34";
                    break;
                case "R":
                    dragonWarriorHex += "35";
                    break;
                case "S":
                    dragonWarriorHex += "36";
                    break;
                case "T":
                    dragonWarriorHex += "37";
                    break;
                case "U":
                    dragonWarriorHex += "38";
                    break;
                case "V":
                    dragonWarriorHex += "39";
                    break;
                case "W":
                    dragonWarriorHex += "3A";
                    break;
                case "X":
                    dragonWarriorHex += "3B";
                    break;
                case "Y":
                    dragonWarriorHex += "3C";
                    break;
                case "Z":
                    dragonWarriorHex += "3D";
                    break;
                case "“":
                    dragonWarriorHex += "3E";
                    break;
                case "”":
                    dragonWarriorHex += "3F";
                    break;
                case "'":
                    dragonWarriorHex += "40";
                    break;
                case "*":
                    dragonWarriorHex += "41";
                    break;
                case ">":
                    // Cursor pointing right
                    dragonWarriorHex += "42";
                    break;
                case "_":
                    // Cursor pointing down
                    dragonWarriorHex += "43";
                    break;
                case ":":
                    dragonWarriorHex += "44";
                    break;
                case "$":
                    dragonWarriorHex += "45";
                    break;
                case ".":
                    dragonWarriorHex += "47";
                    break;
                case ",":
                    dragonWarriorHex += "48";
                    break;
                case "-":
                    dragonWarriorHex += "49";
                    break;
                case "?":
                    dragonWarriorHex += "4B";
                    break;
                case "!":
                    dragonWarriorHex += "4C";
                    break;
                case ";":
                    dragonWarriorHex += "4D";
                    break;
                case ")":
                    dragonWarriorHex += "4E";
                    break;
                case "(":
                    dragonWarriorHex += "4F";
                    break;
                case "‘":
                    dragonWarriorHex += "50";
                    break;
                case "’":
                    dragonWarriorHex += "51";
                    break;
                case "^":
                    // Represent .’ with ^
                    dragonWarriorHex += "52";
                    break;
                //case "’":
                //    dragonWarriorHex += "53";
                //    break;
                //case "’":
                //    dragonWarriorHex += "54";
                //    break;
                case " ":
                    dragonWarriorHex += "5F";
                    break;
                case "@": // pointer to the character's name
                    dragonWarriorHex += "F8";
                    break;
                case "#": // pointer to the enemy, e.g. The #’s Hit< have been reduced by %.
                    dragonWarriorHex += "F4";
                    break;
                case "%": // pointer to numeric amount, e.g. Imperial Scroll number, Gold amount, maximum hit points increase by, etc
                    dragonWarriorHex += "F5";
                    break;
                case "&": // pointer to the spell that was used
                    dragonWarriorHex += "F6";
                    break;
                case "+": // pointer to the item
                    dragonWarriorHex += "F7";
                    break;
                case "<": // Thy Maximum Hit< increase by %.,  Thy Maximum Magic< increase by %.
                    dragonWarriorHex += "F0";
                    break;
                case "=": // pointer to enemy e.g. A= draws near!
                    dragonWarriorHex += "F1";
                    break;
                case "|": // pointer to experience points e.g. ‘Before reaching thy next level of experience 
                    dragonWarriorHex += "F3";
                    break;
                case "~": // New line
                    dragonWarriorHex += "FD";
                    break;
                default:
                    // space
                    dragonWarriorHex += "5F";
                    break;
            }

            return dragonWarriorHex;
        }

        // Title menu dialog screens encode table
        // Only difference appears to be the space.
        private string encodeRomText2(string tempAscii)
        {
            string dragonWarriorHex = "";

            switch (tempAscii)
            {
                case "0":
                    dragonWarriorHex += "00";
                    break;
                case "1":
                    dragonWarriorHex += "01";
                    break;
                case "2":
                    dragonWarriorHex += "02";
                    break;
                case "3":
                    dragonWarriorHex += "03";
                    break;
                case "4":
                    dragonWarriorHex += "04";
                    break;
                case "5":
                    dragonWarriorHex += "05";
                    break;
                case "6":
                    dragonWarriorHex += "06";
                    break;
                case "7":
                    dragonWarriorHex += "07";
                    break;
                case "8":
                    dragonWarriorHex += "08";
                    break;
                case "9":
                    dragonWarriorHex += "09";
                    break;
                case "a":
                    dragonWarriorHex += "0A";
                    break;
                case "b":
                    dragonWarriorHex += "0B";
                    break;
                case "c":
                    dragonWarriorHex += "0C";
                    break;
                case "d":
                    dragonWarriorHex += "0D";
                    break;
                case "e":
                    dragonWarriorHex += "0E";
                    break;
                case "f":
                    dragonWarriorHex += "0F";
                    break;
                case "g":
                    dragonWarriorHex += "10";
                    break;
                case "h":
                    dragonWarriorHex += "11";
                    break;
                case "i":
                    dragonWarriorHex += "12";
                    break;
                case "j":
                    dragonWarriorHex += "13";
                    break;
                case "k":
                    dragonWarriorHex += "14";
                    break;
                case "l":
                    dragonWarriorHex += "15";
                    break;
                case "m":
                    dragonWarriorHex += "16";
                    break;
                case "n":
                    dragonWarriorHex += "17";
                    break;
                case "o":
                    dragonWarriorHex += "18";
                    break;
                case "p":
                    dragonWarriorHex += "19";
                    break;
                case "q":
                    dragonWarriorHex += "1A";
                    break;
                case "r":
                    dragonWarriorHex += "1B";
                    break;
                case "s":
                    dragonWarriorHex += "1C";
                    break;
                case "t":
                    dragonWarriorHex += "1D";
                    break;
                case "u":
                    dragonWarriorHex += "1E";
                    break;
                case "v":
                    dragonWarriorHex += "1F";
                    break;
                case "w":
                    dragonWarriorHex += "20";
                    break;
                case "x":
                    dragonWarriorHex += "21";
                    break;
                case "y":
                    dragonWarriorHex += "22";
                    break;
                case "z":
                    dragonWarriorHex += "23";
                    break;
                case "A":
                    dragonWarriorHex += "24";
                    break;
                case "B":
                    dragonWarriorHex += "25";
                    break;
                case "C":
                    dragonWarriorHex += "26";
                    break;
                case "D":
                    dragonWarriorHex += "27";
                    break;
                case "E":
                    dragonWarriorHex += "28";
                    break;
                case "F":
                    dragonWarriorHex += "29";
                    break;
                case "G":
                    dragonWarriorHex += "2A";
                    break;
                case "H":
                    dragonWarriorHex += "2B";
                    break;
                case "I":
                    dragonWarriorHex += "2C";
                    break;
                case "J":
                    dragonWarriorHex += "2D";
                    break;
                case "K":
                    dragonWarriorHex += "2E";
                    break;
                case "L":
                    dragonWarriorHex += "2F";
                    break;
                case "M":
                    dragonWarriorHex += "30";
                    break;
                case "N":
                    dragonWarriorHex += "31";
                    break;
                case "O":
                    dragonWarriorHex += "32";
                    break;
                case "P":
                    dragonWarriorHex += "33";
                    break;
                case "Q":
                    dragonWarriorHex += "34";
                    break;
                case "R":
                    dragonWarriorHex += "35";
                    break;
                case "S":
                    dragonWarriorHex += "36";
                    break;
                case "T":
                    dragonWarriorHex += "37";
                    break;
                case "U":
                    dragonWarriorHex += "38";
                    break;
                case "V":
                    dragonWarriorHex += "39";
                    break;
                case "W":
                    dragonWarriorHex += "3A";
                    break;
                case "X":
                    dragonWarriorHex += "3B";
                    break;
                case "Y":
                    dragonWarriorHex += "3C";
                    break;
                case "Z":
                    dragonWarriorHex += "3D";
                    break;
                case "“":
                    dragonWarriorHex += "3E";
                    break;
                case "”":
                    dragonWarriorHex += "3F";
                    break;
                case "’":
                    dragonWarriorHex += "40";
                    break;
                case "*":
                    dragonWarriorHex += "41";
                    break;
                case ">":
                    // Cursor pointing right
                    dragonWarriorHex += "42";
                    break;
                case "_":
                    // Cursor pointing down
                    dragonWarriorHex += "43";
                    break;
                case ":":
                    dragonWarriorHex += "44";
                    break;
                case "$":
                    // Represent .. with $
                    dragonWarriorHex += "45";
                    break;
                case ".":
                    dragonWarriorHex += "47";
                    break;
                case ",":
                    dragonWarriorHex += "48";
                    break;
                case "-":
                    dragonWarriorHex += "49";
                    break;
                case "?":
                    dragonWarriorHex += "4B";
                    break;
                case "!":
                    dragonWarriorHex += "4C";
                    break;
                case ";":
                    dragonWarriorHex += "4D";
                    break;
                case ")":
                    dragonWarriorHex += "4E";
                    break;
                case "(":
                    dragonWarriorHex += "4F";
                    break;
                case "‘":
                    dragonWarriorHex += "50";
                    break;
                //case "‘":
                //    dragonWarriorHex += "51";
                //    break;
                case "^":
                    // Represent .’ with ^
                    dragonWarriorHex += "52";
                    break;
                //case "’":
                //    // " ’"
                //    dragonWarriorHex += "53";
                //    break;
                //case "’":
                //    dragonWarriorHex += "54";
                //    break;
                //case " ":
                //    dragonWarriorHex += "5F";
                //    break;
                case "@": // pointer to the character's name
                    dragonWarriorHex += "F8";
                    break;
                case "#": // pointer to the enemy, e.g. The #’s Hit< have been reduced by %.
                    dragonWarriorHex += "F4";
                    break;
                case "%": // pointer to numeric amount, e.g. Imperial Scroll number, Gold amount, maximum hit points increase by, etc
                    dragonWarriorHex += "F5";
                    break;
                case "&": // pointer to the spell that was used
                    dragonWarriorHex += "F6";
                    break;
                case "+": // pointer to the item
                    dragonWarriorHex += "F7";
                    break;
                case "<": // Thy Maximum Hit< increase by %.,  Thy Maximum Magic< increase by %.
                    dragonWarriorHex += "F0";
                    break;
                case "=": // pointer to enemy e.g. A= draws near!
                    dragonWarriorHex += "F1";
                    break;
                case "|": // pointer to experience points e.g. ‘Before reaching thy next level of experience 
                    dragonWarriorHex += "F3";
                    break;
                case "~": // New line
                    dragonWarriorHex += "FD";
                    break;
                case " ":
                    dragonWarriorHex += "81";
                    break;
                default:
                    //dragonWarriorHex += "5F";
                    dragonWarriorHex += "81";
                    break;
            }

            return dragonWarriorHex;
        }

        // Ending / Credits
        // . and ! is different here
        // TODO: lowercase is different here also
        private string encodeRomText3(string tempAscii)
        {
            string dragonWarriorHex = "";

            switch (tempAscii)
            {
                case "0":
                    dragonWarriorHex += "00";
                    break;
                case "1":
                    dragonWarriorHex += "01";
                    break;
                case "2":
                    dragonWarriorHex += "02";
                    break;
                case "3":
                    dragonWarriorHex += "03";
                    break;
                case "4":
                    dragonWarriorHex += "04";
                    break;
                case "5":
                    dragonWarriorHex += "05";
                    break;
                case "6":
                    dragonWarriorHex += "06";
                    break;
                case "7":
                    dragonWarriorHex += "07";
                    break;
                case "8":
                    dragonWarriorHex += "08";
                    break;
                case "9":
                    dragonWarriorHex += "09";
                    break;
                case "a":
                    dragonWarriorHex += "0A";
                    break;
                case "b":
                    dragonWarriorHex += "0B";
                    break;
                case "c":
                    dragonWarriorHex += "0C";
                    break;
                case "d":
                    dragonWarriorHex += "0D";
                    break;
                case "e":
                    dragonWarriorHex += "0E";
                    break;
                case "f":
                    dragonWarriorHex += "0F";
                    break;
                case "g":
                    dragonWarriorHex += "10";
                    break;
                case "h":
                    dragonWarriorHex += "11";
                    break;
                case "i":
                    dragonWarriorHex += "12";
                    break;
                case "j":
                    dragonWarriorHex += "13";
                    break;
                case "k":
                    dragonWarriorHex += "14";
                    break;
                case "l":
                    dragonWarriorHex += "15";
                    break;
                case "m":
                    dragonWarriorHex += "16";
                    break;
                case "n":
                    dragonWarriorHex += "17";
                    break;
                case "o":
                    dragonWarriorHex += "18";
                    break;
                case "p":
                    dragonWarriorHex += "19";
                    break;
                case "q":
                    dragonWarriorHex += "1A";
                    break;
                case "r":
                    dragonWarriorHex += "1B";
                    break;
                case "s":
                    dragonWarriorHex += "1C";
                    break;
                case "t":
                    dragonWarriorHex += "1D";
                    break;
                case "u":
                    dragonWarriorHex += "1E";
                    break;
                case "v":
                    dragonWarriorHex += "1F";
                    break;
                case "w":
                    dragonWarriorHex += "20";
                    break;
                case "x":
                    dragonWarriorHex += "21";
                    break;
                case "y":
                    dragonWarriorHex += "22";
                    break;
                case "z":
                    dragonWarriorHex += "23";
                    break;
                case "A":
                    dragonWarriorHex += "24";
                    break;
                case "B":
                    dragonWarriorHex += "25";
                    break;
                case "C":
                    dragonWarriorHex += "26";
                    break;
                case "D":
                    dragonWarriorHex += "27";
                    break;
                case "E":
                    dragonWarriorHex += "28";
                    break;
                case "F":
                    dragonWarriorHex += "29";
                    break;
                case "G":
                    dragonWarriorHex += "2A";
                    break;
                case "H":
                    dragonWarriorHex += "2B";
                    break;
                case "I":
                    dragonWarriorHex += "2C";
                    break;
                case "J":
                    dragonWarriorHex += "2D";
                    break;
                case "K":
                    dragonWarriorHex += "2E";
                    break;
                case "L":
                    dragonWarriorHex += "2F";
                    break;
                case "M":
                    dragonWarriorHex += "30";
                    break;
                case "N":
                    dragonWarriorHex += "31";
                    break;
                case "O":
                    dragonWarriorHex += "32";
                    break;
                case "P":
                    dragonWarriorHex += "33";
                    break;
                case "Q":
                    dragonWarriorHex += "34";
                    break;
                case "R":
                    dragonWarriorHex += "35";
                    break;
                case "S":
                    dragonWarriorHex += "36";
                    break;
                case "T":
                    dragonWarriorHex += "37";
                    break;
                case "U":
                    dragonWarriorHex += "38";
                    break;
                case "V":
                    dragonWarriorHex += "39";
                    break;
                case "W":
                    dragonWarriorHex += "3A";
                    break;
                case "X":
                    dragonWarriorHex += "3B";
                    break;
                case "Y":
                    dragonWarriorHex += "3C";
                    break;
                case "Z":
                    dragonWarriorHex += "3D";
                    break;
                //case "“":
                //    dragonWarriorHex += "3E";
                //    break;
                //case "”":
                //    dragonWarriorHex += "3F";
                //    break;
                //case "'":
                //    dragonWarriorHex += "40";
                //    break;
                //case "*":
                //    dragonWarriorHex += "41";
                //    break;
                //case ">":
                //    // Cursor pointing right
                //    dragonWarriorHex += "42";
                //    break;
                //case "_":
                //    // Cursor pointing down
                //    dragonWarriorHex += "43";
                //    break;
                //case ":":
                //    dragonWarriorHex += "44";
                //    break;
                //case "$":
                //    dragonWarriorHex += "45";
                //    break;
                //case ".":
                //    dragonWarriorHex += "47";
                //    break;
                //case ",":
                //    dragonWarriorHex += "48";
                //    break;
                //case "-":
                //    dragonWarriorHex += "49";
                //    break;
                //case "?":
                //    dragonWarriorHex += "4B";
                //    break;
                //case "!":
                //    dragonWarriorHex += "4C";
                //    break;
                //case ";":
                //    dragonWarriorHex += "4D";
                //    break;
                //case ")":
                //    dragonWarriorHex += "4E";
                //    break;
                //case "(":
                //    dragonWarriorHex += "4F";
                //    break;
                //case "‘":
                //    dragonWarriorHex += "50";
                //    break;
                //case "’":
                //    dragonWarriorHex += "51";
                //    break;
                //case "^":
                //    // Represent .’ with ^
                //    dragonWarriorHex += "52";
                //    break;
                //case "’":
                //    dragonWarriorHex += "53";
                //    break;
                //case "’":
                //    dragonWarriorHex += "54";
                //    break;
                case " ":
                    dragonWarriorHex += "5F";
                    break;
                case "!":
                    dragonWarriorHex += "60";
                    break;
                case ".":
                    dragonWarriorHex += "61";
                    break;
                //case "@": // pointer to the character's name
                //    dragonWarriorHex += "F8";
                //    break;
                //case "#": // pointer to the enemy, e.g. The #’s Hit< have been reduced by %.
                //    dragonWarriorHex += "F4";
                //    break;
                //case "%": // pointer to numeric amount, e.g. Imperial Scroll number, Gold amount, maximum hit points increase by, etc
                //    dragonWarriorHex += "F5";
                //    break;
                //case "&": // pointer to the spell that was used
                //    dragonWarriorHex += "F6";
                //    break;
                //case "+": // pointer to the item
                //    dragonWarriorHex += "F7";
                //    break;
                //case "<": // Thy Maximum Hit< increase by %.,  Thy Maximum Magic< increase by %.
                //    dragonWarriorHex += "F0";
                //    break;
                //case "=": // pointer to enemy e.g. A= draws near!
                //    dragonWarriorHex += "F1";
                //    break;
                //case "|": // pointer to experience points e.g. ‘Before reaching thy next level of experience 
                //    dragonWarriorHex += "F3";
                //    break;
                //case "~": // New line
                //    dragonWarriorHex += "FD";
                //    break;
                default:
                    // space
                    dragonWarriorHex += "5F";
                    break;
            }

            return dragonWarriorHex;
        }
    }
}
