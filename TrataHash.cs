using System;
using System.Security.Cryptography;
using System.Text;

namespace Net_Hashing
{
    public class TrataHash
    {
        private HashAlgorithm _algoritmo;

        public TrataHash(HashAlgorithm algoritmo)
        {
            _algoritmo = algoritmo;
        }

        public string GerarHash(string senha)
        {
            var valorCodificado = Encoding.UTF8.GetBytes(senha);

            var senhaCifrada = _algoritmo.ComputeHash(valorCodificado);

            var sb = new StringBuilder();

            foreach (var caractere in senhaCifrada)
            {
                sb.Append(caractere.ToString("X2"));
            }
            return sb.ToString();
        }

        public bool VerificarHash(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                throw new NullReferenceException("Cadastre uma senha.");

            var senhaCifrada = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));

            var sb = new StringBuilder();

            foreach (var caractere in senhaCifrada)
            {
                sb.Append(caractere.ToString("X2"));
            }
            return sb.ToString() == senhaCadastrada;
        }

    }
}
