﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Web.Security;

namespace DistributedUtil.Helper
{
    public class EncryptHelper
    {

        #region 使用 缺省密钥字符串 加密/解密string

        /// <summary>  
        /// 使用缺省密钥字符串加密string  
        /// </summary>  
        /// <param name="original">明文</param>  
        /// <returns>密文</returns>  
        public static string Encrypt(string original)
        {
            return Encrypt(original, "1C4866630739FD7E2ACE85663A61C40B");
        }
        /// <summary>  
        /// 使用缺省密钥字符串解密string  
        /// </summary>  
        /// <param name="original">密文</param>  
        /// <returns>明文</returns>  
        public static string Decrypt(string original)
        {
            return Decrypt(original, "1C4866630739FD7E2ACE85663A61C40B", System.Text.Encoding.Default);
        }

        #endregion

        #region 使用 给定密钥字符串 加密/解密string
        /// <summary>  
        /// 使用给定密钥字符串加密string  
        /// </summary>  
        /// <param name="original">原始文字</param>  
        /// <param name="key">密钥</param>  
        /// <param name="encoding">字符编码方案</param>  
        /// <returns>密文</returns>  
        public static string Encrypt(string original, string key)
        {
            byte[] buff = System.Text.Encoding.Default.GetBytes(original);
            byte[] kb = System.Text.Encoding.Default.GetBytes(key);
            return Convert.ToBase64String(Encrypt(buff, kb));
        }
        /// <summary>  
        /// 使用给定密钥字符串解密string  
        /// </summary>  
        /// <param name="original">密文</param>  
        /// <param name="key">密钥</param>  
        /// <returns>明文</returns>  
        public static string Decrypt(string original, string key)
        {
            return Decrypt(original, key, System.Text.Encoding.Default);
        }

        /// <summary>  
        /// 使用给定密钥字符串解密string,返回指定编码方式明文  
        /// </summary>  
        /// <param name="encrypted">密文</param>  
        /// <param name="key">密钥</param>  
        /// <param name="encoding">字符编码方案</param>  
        /// <returns>明文</returns>  
        public static string Decrypt(string encrypted, string key, Encoding encoding)
        {
            byte[] buff = Convert.FromBase64String(encrypted);
            byte[] kb = System.Text.Encoding.Default.GetBytes(key);
            return encoding.GetString(Decrypt(buff, kb));
        }
        #endregion

        #region 使用 缺省密钥字符串 加密/解密/byte[]
        /// <summary>  
        /// 使用缺省密钥字符串解密byte[]  
        /// </summary>  
        /// <param name="encrypted">密文</param>  
        /// <param name="key">密钥</param>  
        /// <returns>明文</returns>  
        public static byte[] Decrypt(byte[] encrypted)
        {
            byte[] key = System.Text.Encoding.Default.GetBytes("1C4866630739FD7E2ACE85663A61C40B");
            return Decrypt(encrypted, key);
        }
        /// <summary>  
        /// 使用缺省密钥字符串加密  
        /// </summary>  
        /// <param name="original">原始数据</param>  
        /// <param name="key">密钥</param>  
        /// <returns>密文</returns>  
        public static byte[] Encrypt(byte[] original)
        {
            byte[] key = System.Text.Encoding.Default.GetBytes("1C4866630739FD7E2ACE85663A61C40B");
            return Encrypt(original, key);
        }
        #endregion

        #region  使用 给定密钥 加密/解密/byte[]

        /// <summary>  
        /// 生成MD5摘要  
        /// </summary>  
        /// <param name="original">数据源</param>  
        /// <returns>摘要</returns>  
        public static byte[] MakeMD5(byte[] original)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] keyhash = hashmd5.ComputeHash(original);
            hashmd5 = null;
            return keyhash;
        }

        /// <summary>  
        /// 使用给定密钥加密  
        /// </summary>  
        /// <param name="original">明文</param>  
        /// <param name="key">密钥</param>  
        /// <returns>密文</returns>  
        public static byte[] Encrypt(byte[] original, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;

            return des.CreateEncryptor().TransformFinalBlock(original, 0, original.Length);
        }

        /// <summary>  
        /// 使用给定密钥解密数据  
        /// </summary>  
        /// <param name="encrypted">密文</param>  
        /// <param name="key">密钥</param>  
        /// <returns>明文</returns>  
        public static byte[] Decrypt(byte[] encrypted, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;

            return des.CreateDecryptor().TransformFinalBlock(encrypted, 0, encrypted.Length);
        }

        #endregion

        #region 使用 MD5加密
        /// <summary>
        /// 使用MD5加密数据
        /// </summary>
        /// <param name="original">明文</param>
        /// <returns>MD5密文</returns>
        public static string MD5(string original)
        {
            string md5 = FormsAuthentication.HashPasswordForStoringInConfigFile(original, "MD5").ToLower();
            //16位MD5加密（取32位加密的6~22字符）
            md5 = md5.Substring(6, 16);
            return md5;
        }
        #endregion

    }
}

