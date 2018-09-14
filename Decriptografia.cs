using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Cript
{
    class Decriptografia
    {
        public static string Decriptografar(string chave, string arquivo)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            
            char[] key;
            string upper = chave.ToUpper();
            key = upper.ToCharArray();            
            string[] linhasDoTxt;
            var list = new List<string>();

            var fileStream = new FileStream(@"C:\Users\Rafael\Desktop\criptografia\" + arquivo +".txt", FileMode.Open, FileAccess.Read);


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


            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            linhasDoTxt = list.ToArray();
 

            int[] ASCdecript = new int[linhasDoTxt.Length];
            for (int i = 0; i < ASCdecript.Length; i++)
            {
                int myBin = Convert.ToInt32(linhasDoTxt[i], 2);
                myBin = myBin - finalKey - key.Length;
                ASCdecript[i] = myBin;
            }
            

            byte[] palavraBytes = new byte[ASCdecript.Length];
            for (int i = 0; i < ASCdecript.Length; i++)
            {                
                palavraBytes[i] = Convert.ToByte(ASCdecript[i]);
            }


            string[] final = new string[palavraBytes.Length];
            string s = null;
            for (int i = 0; i < palavraBytes.Length; i++)
            {
                s += Encoding.ASCII.GetString(new byte[] { palavraBytes[i] });
            }
          
            Console.WriteLine(s);
            return s;
        }
    }
}
