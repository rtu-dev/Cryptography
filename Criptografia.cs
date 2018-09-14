using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cript
{
    class Criptografia
    {
        public static bool Criptografar(string chave, string palavra , string arquivo)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            byte[] palavraBytes = System.Text.Encoding.ASCII.GetBytes(palavra);
            int[] PalavraMultiplicada = new int[palavraBytes.Length];
            string[] palavraBin = new string[palavraBytes.Length];
            char[] key;
            string upper = chave.ToUpper();
            key = upper.ToCharArray();
            int finalKey = 0;


            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if (key[i] == alpha[j])
                    {
                        finalKey += j;
                    }
                }
            }


            for (int i = 0; i < palavraBytes.Length; i++)
            {                
                PalavraMultiplicada[i] = palavraBytes[i] + finalKey + key.Length;
            }
            
            for (int i = 0; i < palavraBytes.Length; i++)
            {
                palavraBin[i] = Convert.ToString(PalavraMultiplicada[i], 2);
            }

            System.IO.File.WriteAllLines(@"C:\Users\Rafael\Desktop\criptografia\" + arquivo + ".txt" , palavraBin);

            return true;
        } 
    }
}
