using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace MifareCalculator
{
    public class ClassicPasswordGenerator
    {

        private byte[] passwordData = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        public string generatePassword(string keyA, string keyB)
        {
            string result = GetString(generatePassword(GetBytes(keyA), GetBytes(keyB)));
            return result;
        }
        public byte[] generatePassword(byte[] KeyA, byte[] KeyB)
        {
            byte[] tdesdesKeyA;
            byte[] tdesdesKeyB;

            tdesdesKeyA = generateDKeyA(KeyA);
            tdesdesKeyB = generateDKeyB(KeyB);

            //invert the byte
            tdesdesKeyA = invert(tdesdesKeyA);
            tdesdesKeyB = invert(tdesdesKeyB);
            
            // start calling the encryptor
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.None;
            tdes.Key = append(tdesdesKeyA, tdesdesKeyB, tdesdesKeyA);
            var ic = tdes.CreateEncryptor();
            var pass = ic.TransformFinalBlock(passwordData, 0, passwordData.Length);
            pass = invert(pass);

            // return the result
            return pass;
        }
        private byte[] generateDKeyA(byte[] keyA)
        {
            byte[] result = new byte[8];

            for (int i = 0; i < 6; i++)
            {
                result[i] = (byte)(keyA[i] << 1);
            }
            result[7] = 0x00;

            int counter = 1;
            int resultVal = 0;
            foreach (var item in keyA)
            {
                byte temp = (byte)(item & (byte)0x80);
                resultVal += temp >> counter;
                counter++;
            }
            result[6] = (byte)resultVal;

            return result;
        }


        private byte[] generateDKeyB(byte[] keyB)
        {
            byte[] result = new byte[8];

            for (int i = 0; i < 6; i++)
            {
                result[i + 2] = (byte)(keyB[i] << 1);
            }
            result[0] = 0x00;

            int counter = 1;
            int resultVal = 0;
            foreach (var item in keyB)
            {
                byte temp = (byte)(item & (byte)0x80);
                resultVal += temp >> counter;
                counter++;
            }
            result[1] = (byte)resultVal;

            return result;
        }

        private byte[] append(params byte[][] val)
        {
            byte[] result = null;
            int totalNeededSpace = 0;
            foreach (byte[] vals in val)
            {
                totalNeededSpace += vals.Length;
            }

            result = new byte[totalNeededSpace];

            int counter = 0;
            foreach (byte[] vals in val)
            {
                foreach (var BYTE in vals)
                {
                    result[counter] = BYTE;
                    counter++;
                }
            }

            return result;
        }

        private byte[] invert(byte[] val)
        {
            byte[] result = new byte[val.Length];

            for (int i = 0; i < val.Length; i++)
            {
                result[result.Length - i - 1] = val[i];
            }

            return result;
        }

        private static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length/2];
            for (int i = 0; i < str.Length/2; i++)
            {
                bytes[i] = Convert.ToByte(str.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        private static string GetString(byte[] bytes)
        {
            StringBuilder hex = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
                hex.AppendFormat("{0:X2}", b);
            return hex.ToString();
        }
    }
}
