using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace xiketang.com.SerialPortPro
{
    public class HexHelper
    {

        #region  �ж��Ƿ�Ϊ16�����ַ���
        /// <summary>
        /// �ж��Ƿ�Ϊ16�����ַ���
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static bool IsHexString(string hexString)
        {
            //ʮ�����Ʒ���ʱ�����Ϳ����ݽ���ʮ��������������У��
            if (Regex.IsMatch(hexString, "^[0-9A-Fa-f]+$"))
            {
                //У��ɹ�
                return true;
            }
            //У��ʧ��
            return false;
        }
        #endregion

        #region ��ASCII���ַ���ת����16�����ַ���
        /// <summary>
        /// ��ascii�ַ���ת����Hex��ʾ
        /// </summary>
        /// <param name="asciiString"></param>
        /// <returns></returns>
        public static string ConvertStringToHexString(string asciiString,Encoding encoding)
        {
            string hexString = "";
            asciiString = asciiString.Replace("\n", "\r\n");                //���richTextBox��ȡ����"\r\n"���з�
            byte[] arrByte = encoding.GetBytes(asciiString);
            foreach (char c in arrByte)
            {
                int tmp = c;
                hexString += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString())).ToUpper() + " ";
            }
            return hexString;
        }

        #endregion

        #region ��16�����ַ���ת����ASCII���ַ���
        /// <summary>
        /// ��Hexת����ascii�ַ�����ʾ
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static string ConvertHexStringToString(string hexString, Encoding encoding)
        {
            string result = string.Empty;
            hexString = hexString.Replace(" ", "");
            //���ʮ�����Ƴ��ֵ��������⣬�Բ�0
            if (hexString.Length % 2 == 1)
            {
                hexString = hexString.Insert(hexString.Length - 1, "0");
            }
            byte[] arrByte = new byte[hexString.Length / 2];
            int index = 0;
            for (int i = 0; i < hexString.Length; i += 2)
            {
                //Convert.ToByte(string,16)��ʮ������stringת����byte 
                arrByte[index++] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            result = encoding.GetString(arrByte);
            return result;
        }
        #endregion

        #region ��ȡ16�����ַ������ֽ���
        /// <summary>
        /// ��ȡhexString��Byte����
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static int GetByteCount(string hexString)
        {
            if (IsHexString(hexString) && (hexString.Length % 2 == 0))
            {
                // 2 characters per byte
                return hexString.Length / 2;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region ����16������ת�ֽ�
        /// <summary>
        /// 16������ת�ֽ�
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        private static byte HexToByte(string hex)
        {
            if (hex.Length > 2 || hex.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");
            byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return newByte;
        }
        #endregion

        #region 16�����ַ���ת�����ֽ�����
        /// <summary>
        ///  16�����ַ���ת�����ֽ�����
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] HexStringToBytes(string hexString)
        {
            //string newString = "";

            if (IsHexString(hexString) == false)
            { return null; }

            int byteLength = hexString.Length / 2;
            byte[] bytes = new byte[byteLength];
            string hex;
            int j = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                hex = new String(new Char[] { hexString[j], hexString[j + 1] });
                bytes[i] = HexToByte(hex);
                j = j + 2;
            }
            return bytes;
        }
        #endregion

        #region �ֽ�����ת����16�����ַ���
        /// <summary>
        /// �ֽ�����ת����16�����ַ���
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string BytesToHexString(byte[] bytes)
        {
            string hexString = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                hexString += bytes[i].ToString("X2");
            }
            return hexString;
        }
        #endregion

        #region ƴ���ֽ�����
        public static byte[] ConcatArrays(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        public static byte[] ConcatArrays(byte[] first, byte[] second, byte[] third)
        {
            byte[] ret = new byte[first.Length + second.Length + third.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            Buffer.BlockCopy(third, 0, ret, first.Length + second.Length,
                             third.Length);
            return ret;
        }

        public static byte[] ConcatArrays(params byte[][] arrays)
        {
            byte[] ret = new byte[arrays.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in arrays)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }
        #endregion

    }
}
