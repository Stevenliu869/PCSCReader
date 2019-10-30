using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

public class TDEA
{
    #region CBC模式**

    /// <summary>
    /// DES3 CBC模式加密
    /// </summary>
    /// <param name="key">密钥</param>
    /// <param name="iv">IV</param>
    /// <param name="data">明文的byte数组</param>
    /// <returns>密文的byte数组</returns>
    public static byte[] CbcEncryption(byte[] key, byte[] iv, byte[] data)
    {
        try
        {
            // Create a MemoryStream.
            MemoryStream mStream = new MemoryStream();

            TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
            tdsp.Mode = CipherMode.CBC;             //默认值
            tdsp.Padding = PaddingMode.Zeros; // PKCS7;       //默认值

            // Create a CryptoStream using the MemoryStream 
            // and the passed key and initialization vector (IV).
            CryptoStream cStream = new CryptoStream(mStream,
                                        tdsp.CreateEncryptor(key, iv),
                                        CryptoStreamMode.Write);

            // Write the byte array to the crypto stream and flush it.
            cStream.Write(data, 0, data.Length);
            cStream.FlushFinalBlock();

            // Get an array of bytes from the 
            // MemoryStream that holds the 
            // encrypted data.
            byte[] ret = mStream.ToArray();

            // Close the streams.
            cStream.Close();
            mStream.Close();

            // Return the encrypted buffer.
            return ret;
        }
        catch (CryptographicException e)
        {
            throw e;
        }
    }

    /// <summary>
    /// DES3 CBC模式解密
    /// </summary>
    /// <param name="key">密钥</param>
    /// <param name="iv">IV</param>
    /// <param name="data">密文的byte数组</param>
    /// <returns>明文的byte数组</returns>
    public static byte[] CbcDecryption(byte[] key, byte[] iv, byte[] data)
    {
        try
        {
            // Create a new MemoryStream using the passed 
            // array of encrypted data.
            MemoryStream msDecrypt = new MemoryStream(data);

            TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
            tdsp.Mode = CipherMode.CBC;
            tdsp.Padding = PaddingMode.Zeros; //PKCS7;

            // Create a CryptoStream using the MemoryStream 
            // and the passed key and initialization vector (IV).
            CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                                            tdsp.CreateDecryptor(key, iv),
                                            CryptoStreamMode.Read);

            // Create buffer to hold the decrypted data.
            byte[] fromEncrypt = new byte[data.Length];

            // Read the decrypted data out of the crypto stream
            // and place it into the temporary buffer.
            csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

            //Convert the buffer into a string and return it.
            return fromEncrypt;
        }
        catch (CryptographicException e)
        {
            throw e;
        }
    }

    #endregion

    #region ECB模式

    /// <summary>
    /// DES3 ECB模式加密
    /// </summary>
    /// <param name="key">密钥</param>
    /// <param name="str">明文的byte数组</param>
    /// <returns>密文的byte数组</returns>
    public static byte[] EcbEncryption(byte[] key, byte[] data)
    {
        try
        {
            // Create a MemoryStream.
            MemoryStream mStream = new MemoryStream();
            byte[] iv = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 }; //The IV is invalid for ECB mode

            TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
            tdsp.Mode = CipherMode.ECB;
            tdsp.Padding = PaddingMode.Zeros; // PKCS7;
            // Create a CryptoStream using the MemoryStream 
            // and the passed key and initialization vector (IV).
            CryptoStream cStream = new CryptoStream(mStream,
                                            tdsp.CreateEncryptor(key, iv),
                                            CryptoStreamMode.Write);

            // Write the byte array to the crypto stream and flush it.
            cStream.Write(data, 0, data.Length);
            cStream.FlushFinalBlock();

            // Get an array of bytes from the 
            // MemoryStream that holds the 
            // encrypted data.
            byte[] ret = mStream.ToArray();

            // Close the streams.
            cStream.Close();
            mStream.Close();

            // Return the encrypted buffer.
            return ret;
        }
        catch (CryptographicException e)
        {
            throw e;
        }
    }

    /// <summary>
    /// DES3 ECB模式解密
    /// </summary>
    /// <param name="key">密钥</param>
    /// <param name="str">密文的byte数组</param>
    /// <returns>明文的byte数组</returns>
    public static byte[] EcbDecryption(byte[] key, byte[] data)
    {
        try
        {
            // Create a new MemoryStream using the passed 
            // array of encrypted data.
            MemoryStream msDecrypt = new MemoryStream(data);
            byte[] iv = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 }; //The IV is invalid for ECB mode

            TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
            tdsp.Mode = CipherMode.ECB;
            tdsp.Padding = PaddingMode.Zeros; //PKCS7;

            // Create a CryptoStream using the MemoryStream 
            // and the passed key and initialization vector (IV).
            CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                                                    tdsp.CreateDecryptor(key, iv),
                                                    CryptoStreamMode.Read);

            // Create buffer to hold the decrypted data.
            byte[] fromEncrypt = new byte[data.Length];

            // Read the decrypted data out of the crypto stream
            // and place it into the temporary buffer.
            csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

            //Convert the buffer into a string and return it.
            return fromEncrypt;
        }
        catch (CryptographicException e)
        {
            throw e;
        }
    }

    #endregion

    #region Generate Random Number

    public static void GetRandoms(byte[] bytes)
    {
        Random rnd = new Random();
        rnd.NextBytes(bytes);
    }
    
    #endregion

    #region Binary Array <=> HexString Convertor
    /// <summary>
    /// Convert binary array to hexstring
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
    /// Convert hexstring to binary array
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
    #endregion
    //== End of Class TDEA ==
}
