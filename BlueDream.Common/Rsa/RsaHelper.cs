using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using System;
using System.Text;

namespace BlueDream.Common
{
    /// <summary>
    /// 秘钥工具类
    /// </summary>
    public class RsaHelper
    {
        /// <summary>
        /// 生成公钥和私钥（Item1 = 公钥，Item2 = 私钥）
        /// </summary>
        /// <returns></returns>
        public static Tuple<string, string> GenerateRsaKeys()
        {
            RsaKeyPairGenerator m_RsaKeyPairGenerator = new RsaKeyPairGenerator();
            RsaKeyGenerationParameters m_RsaKeyGenerationParameters = new RsaKeyGenerationParameters(BigInteger.ValueOf(3), new SecureRandom(), 1028, 25);
            m_RsaKeyPairGenerator.Init(m_RsaKeyGenerationParameters);
            AsymmetricCipherKeyPair m_KeyPair = m_RsaKeyPairGenerator.GenerateKeyPair();
            AsymmetricKeyParameter m_PublicKey = m_KeyPair.Public;//公钥
            AsymmetricKeyParameter m_PrivateKey = m_KeyPair.Private;//私钥

            SubjectPublicKeyInfo m_SubjectPublicKeyInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(m_PublicKey);
            PrivateKeyInfo m_PrivateKeyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(m_PrivateKey);
            Asn1Object m_Asn1ObjectPublic = m_SubjectPublicKeyInfo.ToAsn1Object();
            byte[] m_PublicInfoByte = m_Asn1ObjectPublic.GetEncoded();
            Asn1Object m_Asn1ObjectPrivate = m_PrivateKeyInfo.ToAsn1Object();
            byte[] m_PrivateInfoByte = m_Asn1ObjectPrivate.GetEncoded();

            //这里可以将密钥对保存到本地
            return new Tuple<string, string>(Convert.ToBase64String(m_PublicInfoByte), Convert.ToBase64String(m_PrivateInfoByte));
        }

        #region 私钥加密，公钥解密

        /// <summary>
        /// 私钥加密（必须用公钥解密）
        /// </summary>
        /// <param name="p_Source">要加密的字符串（原文）</param>
        /// <param name="p_PrivateKey">私钥</param>
        /// <returns></returns>
        public static string EncryptByPrivateKey(string p_Source, string p_PrivateKey)
        {
            byte[] m_PrivateInfoByte = Convert.FromBase64String(p_PrivateKey);
            AsymmetricKeyParameter m_PriKey = PrivateKeyFactory.CreateKey(m_PrivateInfoByte);
            IAsymmetricBlockCipher m_Cipher = new RsaEngine();
            m_Cipher.Init(true, m_PriKey);
            byte[] m_SourceData = Encoding.UTF8.GetBytes(p_Source);
            m_SourceData = m_Cipher.ProcessBlock(m_SourceData, 0, m_SourceData.Length);
            return Convert.ToBase64String(m_SourceData);
        }

        /// <summary>
        /// 公钥解密（key公钥解密）- 必须对应私钥加密
        /// </summary>
        /// <param name="m_Source">加密后的数据（密文）</param>
        /// <param name="p_PublicKey">公钥</param>
        /// <returns></returns>
        public static string DecryptByPublibKey(string m_Source, string p_PublicKey)
        {
            byte[] m_PublicInfoByte = Convert.FromBase64String(p_PublicKey);
            Asn1Object m_PubKeyObj = Asn1Object.FromByteArray(m_PublicInfoByte);//这里也可以从流中读取，从本地导入
            AsymmetricKeyParameter m_PubKey = PublicKeyFactory.CreateKey(SubjectPublicKeyInfo.GetInstance(m_PubKeyObj));
            //开始解密
            IAsymmetricBlockCipher m_Cipher = new RsaEngine();
            m_Cipher.Init(false, m_PubKey);
            //解密已加密的数据
            byte[] m_EncryptedData = Convert.FromBase64String(m_Source);
            m_EncryptedData = m_Cipher.ProcessBlock(m_EncryptedData, 0, m_EncryptedData.Length);
            return Encoding.UTF8.GetString(m_EncryptedData, 0, m_EncryptedData.Length);
        }

        #endregion 私钥加密，公钥解密

        #region 公钥加密，私钥解密

        /// <summary>
        /// 公钥加密 （需私钥解密）
        /// </summary>
        /// <param name="p_Source">要加密的文本</param>
        /// <param name="p_PublicKey">公钥</param>
        /// <returns></returns>
        public static string EncryptByPublicKey(string p_Source, string p_PublicKey)
        {
            byte[] m_PublicInfoByte = Convert.FromBase64String(p_PublicKey);
            Asn1Object m_PubKeyObj = Asn1Object.FromByteArray(m_PublicInfoByte);//这里也可以从流中读取，从本地导入
            AsymmetricKeyParameter m_PubKey = PublicKeyFactory.CreateKey(SubjectPublicKeyInfo.GetInstance(m_PubKeyObj));
            IAsymmetricBlockCipher m_Cipher = new RsaEngine();
            m_Cipher.Init(true, m_PubKey);//true表示加密
            byte[] m_EncryptData = Encoding.UTF8.GetBytes(p_Source);
            m_EncryptData = m_Cipher.ProcessBlock(m_EncryptData, 0, m_EncryptData.Length);
            return Convert.ToBase64String(m_EncryptData);
        }

        /// <summary>
        /// 私钥解密（需公钥加密）
        /// </summary>
        /// <param name="p_Source">加密后的文本（密文）</param>
        /// <param name="p_PrivateKey">私钥</param>
        /// <returns></returns>
        public static string DecryptByPrivateKey(string p_Source, string p_PrivateKey)
        {
            byte[] m_PrivateInfoByte = Convert.FromBase64String(p_PrivateKey);
            AsymmetricKeyParameter m_PriKey = PrivateKeyFactory.CreateKey(m_PrivateInfoByte);
            IAsymmetricBlockCipher m_Cipher = new RsaEngine();
            m_Cipher.Init(false, m_PriKey);//false表示解密
            //解密数据
            byte[] m_EncryptData = Convert.FromBase64String(p_Source);
            byte[] m_DecryptData = m_Cipher.ProcessBlock(m_EncryptData, 0, m_EncryptData.Length);
            return Encoding.UTF8.GetString(m_DecryptData);
        }

        #endregion 公钥加密，私钥解密

        #region 独立公钥解密

        /// <summary>
        /// 获取公钥参数（Item1 = Modules， Item2 = PublicExponent）
        /// </summary>
        /// <param name="p_PublicKey">公钥</param>
        /// <returns></returns>
        private static Tuple<byte[], byte[]> GetPublicKeyParameters(string p_PublicKey)
        {
            //获取modulus和publicExponent
            byte[] m_BtPem = Convert.FromBase64String(p_PublicKey);
        
            byte[] m_BtPemModulus = new byte[128];
            byte[] m_BtPemPublicExponent = new byte[3];

            for (int t_Index = 0; t_Index < 128; t_Index++)
            {
                m_BtPemModulus[t_Index] = m_BtPem[29 + t_Index];
            }

            for (int t_Index = 0; t_Index < 3; t_Index++)
            {
                m_BtPemPublicExponent[t_Index] = m_BtPem[159 + t_Index];
            }

            return new Tuple<byte[], byte[]>(m_BtPemModulus, m_BtPemPublicExponent);
        }

        public static string DecryptByPublicKeyOnly(string p_Source, string p_PublicKey)
        {
            Tuple<byte[], byte[]> m_PublicKeyParams = GetPublicKeyParameters(p_PublicKey);
            BigInteger m_BiModulus = new BigInteger(1, m_PublicKeyParams.Item1);
            BigInteger m_BiExponent = new BigInteger(1, m_PublicKeyParams.Item2);
            RsaKeyParameters m_PublicParameters = new RsaKeyParameters(false, m_BiModulus, m_BiExponent);
            IAsymmetricBlockCipher m_AsymmetricBlockCipher = new Pkcs1Encoding(new RsaEngine());
            m_AsymmetricBlockCipher.Init(false, m_PublicParameters);
            //解密已加密的数据
            byte[] m_EncryptedData = Convert.FromBase64String(p_Source);
            m_EncryptedData = m_AsymmetricBlockCipher.ProcessBlock(m_EncryptedData, 0, m_EncryptedData.Length);
            return Encoding.UTF8.GetString(m_EncryptedData, 0, m_EncryptedData.Length);
        }

        #endregion 独立公钥解密
    }
}