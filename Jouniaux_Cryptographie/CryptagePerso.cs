using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jouniaux_Cryptographie
{
    class CryptagePerso
    {
        private string key;
        public string Key
        {
            get { return key; }
        }

        public CryptagePerso(string cle)
        {
            key = cle;

        }

        public string Encrypt(string ChaineaEncoder)
        {
            string encrypt = null;

            for (int i = 0; i < ChaineaEncoder.Length; i++)
            {
                encrypt += Convert.ToString(Convert.ToChar((Convert.ToInt16(key[i % key.Length]) + Convert.ToInt16(ChaineaEncoder[i])) % 65536));
            }

            return encrypt;
        }

        public string Decrypt(string ChaineaDecrypter)
        {
            string decrypt = null;

            for (int i = 0; i < ChaineaDecrypter.Length; i++)
            {
                decrypt += Convert.ToString(Convert.ToChar(((Convert.ToInt16(ChaineaDecrypter[i]) - Convert.ToInt16(key[i % key.Length])) % 65536)));
            }

            return decrypt;
        }
    }
}
