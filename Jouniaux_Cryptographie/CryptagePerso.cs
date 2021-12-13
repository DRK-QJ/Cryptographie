using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jouniaux_Cryptographie
{
    class CryptagePerso
    {
        private string _clé;
        public string Clé_crypt
        {
            get { return _clé; }
        }

        public CryptagePerso(string cle)
        {
            _clé = cle;

        }

        public string Encrypt(string Chaine_Encode)
        {
            string encrypt = null;

            for (int i = 0; i < Chaine_Encode.Length; i++)
            {
                encrypt += Convert.ToString(Convert.ToChar((Convert.ToInt16(_clé[i % _clé.Length]) + Convert.ToInt16(Chaine_Encode[i])) % 65536));
            }

            return encrypt;
        }

        public string Decrypt(string Chaine_Decrypte)
        {
            string decrypt = null;

            for (int i = 0; i < Chaine_Decrypte.Length; i++)
            {
                decrypt += Convert.ToString(Convert.ToChar(((Convert.ToInt16(Chaine_Decrypte[i]) - Convert.ToInt16(_clé[i % _clé.Length])) % 65536)));
            }

            return decrypt;
        }
    }
}
