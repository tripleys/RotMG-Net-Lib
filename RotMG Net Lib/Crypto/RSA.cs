using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.OpenSsl;
using System;
using System.IO;
using System.Text;

namespace RotMG_Net_Lib.Crypto
{
    public class RSA
    {

        public static readonly RSA Instance = new RSA("-----BEGIN PUBLIC KEY-----\r\n" + "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDCKFctVrhfF3m2Kes0FBL/JFeO" + "cmNg9eJz8k/hQy1kadD+XFUpluRqa//Uxp2s9W2qE0EoUCu59ugcf/p7lGuL99Uo" + "SGmQEynkBvZct+/M40L0E0rZ4BVgzLOJmIbXMp0J4PnPcb6VLZvxazGcmSfjauC7" + "F3yWYqUbZd/HCBtawwIDAQAB" + "\r\n-----END PUBLIC KEY-----");

        private RsaEngine engine;
        private readonly AsymmetricKeyParameter key;

        private RSA(string pem)
        {
            key = new PemReader(new StringReader(pem)).ReadObject() as AsymmetricKeyParameter;
            engine = new RsaEngine();
            engine.Init(true, key);
        }

        public string Encrypt(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            var encoding = new Pkcs1Encoding(engine);
            encoding.Init(true, key);
            return Convert.ToBase64String(encoding.ProcessBlock(bytes, 0, bytes.Length));
        }
    }
}
