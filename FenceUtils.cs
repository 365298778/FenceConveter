using System;
using System.Collections.Generic;

namespace TestFencePassword
{
    static class FenceUtils
    {
        #region 栅栏密码加密
        public static void ENCRYPT(string info)
        {
            info = info.ToUpper();
            info = info.Replace(" ", "");
            List<char> infoLetters1 = new List<char>();
            List<char> infoLetters2 = new List<char>();
            List<char> cipherText = new List<char>();
            for (int i = 0; i < info.Length; i++)
            {
                if (i%2!=0)
                {
                    infoLetters2.Add(info[i]);
                }
                else if(i%2==0)
                {
                    infoLetters1.Add(info[i]);
                }
            }
            foreach (char letter in infoLetters1)
            {
                cipherText.Add(letter);
            }
            foreach (char letter in infoLetters2)
            {
                cipherText.Add(letter);
            }
            Console.WriteLine("encryptResult:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var letter in cipherText)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
            Console.Read();
        }
        #endregion

        #region 栅栏密码解密
        public static void DECRYPT(string ciphertext)
        {
            ciphertext = ciphertext.ToUpper();
            ciphertext = ciphertext.Replace(" ", "");
            bool flag=false;
            List<char> cipherTextLetters1 = new List<char>();
            List<char> cipherTextLetters2 = new List<char>();
            List<char> info = new List<char>();
            if (ciphertext.Length%2==0)
            {
                flag = true;
            }
            if (flag == true)
            {
                for (int i = 0; i < ciphertext.Length/2; i++)
                {
                cipherTextLetters1.Add(ciphertext[i]);
                }

                for (int i = ciphertext.Length / 2; i < ciphertext.Length; i++)
                {
                    cipherTextLetters2.Add(ciphertext[i]);
                }

                for (int i = 0; i < ciphertext.Length/2; i++)
                {
                    if (i == 0)
                    {
                        info.Add(cipherTextLetters1[i]);
                        info.Add(cipherTextLetters2[i]);
                        continue;
                    }
                    if (i % 2 != 0)
                    {
                        info.Add(cipherTextLetters1[i]);
                        info.Add(cipherTextLetters2[i]);
                    }
                    else if (i % 2 == 0)
                    {
                        info.Add(cipherTextLetters2[i]);
                        info.Add(cipherTextLetters1[i]);
                    }
                }
            }
            else if (flag == false)
            {
                for (int i = 0; i < ciphertext.Length / 2+1; i++)
                {
                    cipherTextLetters1.Add(ciphertext[i]);
                }

                for (int i = ciphertext.Length / 2+1; i < ciphertext.Length; i++)
                {
                    cipherTextLetters2.Add(ciphertext[i]);
                }

                for (int i = 0; i < ciphertext.Length/2+1; i++)
                {
                    if (i==0)
                    {
                        info.Add(cipherTextLetters1[i]);
                        info.Add(cipherTextLetters2[i]);
                        continue;
                    }
                    if (i % 2 != 0)
                    {
                        info.Add(cipherTextLetters1[i]);
                        info.Add(cipherTextLetters2[i]);
                    }
                    else if (i % 2 == 0)
                    {
                        info.Add(cipherTextLetters2[i]);
                        info.Add(cipherTextLetters1[i]);
                    }
                }
            }
            Console.WriteLine("encryptResult:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var letter in info)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
            Console.Read();
        }
        #endregion
    }
}
