using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace Jouniaux_Cryptographie
{
    class CryptageDotNet
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        private RSAParameters _clesprive;
        private RSAParameters _clespublique;

        public CryptageDotNet()
        {
            _clesprive = csp.ExportParameters(true);
            _clespublique = csp.ExportParameters(false);
        }
        public string Publiquecles()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _clespublique);
            return sw.ToString();
        }
        public string Encrypt(string plainText)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(_clespublique);

            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }
        public string Decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.ImportParameters(_clesprive);
            var plainext = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(plainext);
        }
    }
        
}
