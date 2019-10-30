using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

//namespace TYRTTestAP
//{
    public class EcbDES
    {
        public enum CryptoMeth
        {
            Decrypt = 0,
            Encrypt = 1,
        };


        /// <summary>
        /// Des, Encrypt and Decrypt data with DES.
        /// </summary>
        /// <param name="EncryFlag">1 => Encrypt,  0 => Decrypt</param>
        /// <param name="key">crypto key, 8 bytes</param>
        /// <param name="data">plain text, 8 bytes</param>
        /// <param name="edata">Cryto text, 8 bytes</param>
        [DllImport("DES.dll")] 
        public static extern void Des(int EncryFlag, byte[] key, byte[] data, byte[] edata);


        /// <summary>
        /// TripleDes, Encrypt and Decrypt data with 3DES.
        /// </summary>
        /// <param name="EncryFlag"> 1 => Encrypt,  0 => Decrypt</param>
        /// <param name="key">crypto key, 16 bytes</param>
        /// <param name="data">plain text, 8 bytes</param>
        /// <param name="edata">Cryto text, 8 bytes</param>
        [DllImport("DES.dll")] 
        public static extern void TripleDes(int EncryFlag, byte[] key, byte[] data, byte[] edata);

        //public static string TDesEncrypt(string key, string data)
        //{
        //}

        /// <summary>
        /// {0xae, 0x00, 0xcf} => "AE00CF"
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToHexString(byte[] bytes) 
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                }
                hexString = strB.ToString();
            }
            return hexString;
        }

        /// <summary>
        /// "AE00CF" => {0xae, 0x00, 0xcf}
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(string hexString)
        {
            string newHexString = "";
            char c;

            // remove all none A-F, 0-9, characters
            for (int i = 0; i < hexString.Length; i++)
            {
                c = hexString[i];
                if (Uri.IsHexDigit(c))
                    newHexString += c;
            }

            // if odd number of characters, add a "0" at the start. --Steven Liu 2017/02/06
            if (newHexString.Length % 2 != 0)
            {
                //newHexString = newHexString.Substring(0, newHexString.Length - 1);
                newHexString = "0" + newHexString; //Steven Liu 2017/02/06
            }

            int byteLength = newHexString.Length / 2;
            byte[] bytes = new byte[byteLength];
            string hex;
            int j = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                hex = new String(new Char[] { newHexString[j], newHexString[j + 1] });
                bytes[i] = HexToByte(hex);
                j = j + 2;
            }
            return bytes;
        }

        private static byte HexToByte(string hex)
        {
            if (hex.Length > 2 || hex.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");
            byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return newByte;
        }
    }
//}
