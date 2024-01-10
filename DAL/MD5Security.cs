using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security.Cryptography;

namespace DAL
{
    internal class MD5Security
    {
            public static string Encrypt(string toEncrypt, string securityKey, bool useHashing)
            {

                string retVal = string.Empty;

                try
                {
                    byte[] keyArray;
                    byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
                    ValidateInput(toEncrypt);
                    ValidateInput(securityKey);
                    if (useHashing)
                    {
                        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(securityKey));
                        hashmd5.Clear();
                    }
                    else
                    {
                        keyArray = UTF8Encoding.UTF8.GetBytes(securityKey);
                    }
                    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                    tdes.Key = keyArray;
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform cTransform = tdes.CreateEncryptor();
                    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                    tdes.Clear();
                    retVal = Convert.ToBase64String(resultArray, 0, resultArray.Length);
                }
                catch (Exception ex)
                {
                }
                return retVal;
            }
            public static string Decrypt(string cipherString, string securityKey, bool useHashing)
            {
                string retVal = string.Empty;
                try
                {
                    byte[] keyArray;
                    byte[] toEncryptArray = Convert.FromBase64String(cipherString);
                    ValidateInput(cipherString);
                    ValidateInput(securityKey);
                    if (useHashing)
                    {
                        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(securityKey));
                        hashmd5.Clear();
                    }
                    else
                    {
                        keyArray = UTF8Encoding.UTF8.GetBytes(securityKey);
                    }
                    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                    tdes.Key = keyArray;
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform cTransform = tdes.CreateDecryptor();
                    byte[] resultArray = cTransform.TransformFinalBlock( toEncryptArray, 0, toEncryptArray.Length);
                    tdes.Clear();
                    retVal = UTF8Encoding.UTF8.GetString(resultArray);
                }
                catch (Exception ex)
                {

                }
                return retVal;
            }
            private static bool ValidateInput(string inputValue)
            {
                bool valid = string.IsNullOrEmpty(inputValue);
                return valid;
            }
        }
    }


