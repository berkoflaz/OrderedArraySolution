using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedArraySolution
{
    class Program
    {
        static void Main(string[] args)
        {

            #region README
            Console.WriteLine("Verilen iki dizi arasinda , 1. dizinin icinde 2. dizinin sirali bulunup bulunmadigini belirleyen program.");
            Console.WriteLine("Once 1. dizi uzunlugunu girip 'ENTER' a basiniz.Dizi elemanlarini girmek icin , dizi elemani yazildiktan sonra tekrar 'ENTER' a basiniz.");
            Console.WriteLine("Ayni islemi 2. dizi icin de yapiniz.");
            Console.WriteLine("------------------------------------------------------");
            #endregion

            #region variables
            int size1 = 0;
            int size2 = 0;

            int[] Array1;
            int[] Array2;

            #endregion

            #region user input
            try
            {
                Console.WriteLine("1. dizi uzunlugunu giriniz:");
                var firstSizeInput = Console.In.ReadLine();

                size1 = Convert.ToInt32(firstSizeInput);

                Array1 = new int[size1];

                Console.WriteLine("1. dizi elemanlarini giriniz:");

                for (int i = 0; i < Array1.Length; i++)
                {
                    var input = Console.In.ReadLine();
                    Array1[i] = Convert.ToInt32(input);

                }
                string outputStr1 = "";
                foreach (var item in Array1)
                {
                    outputStr1 += " " + item;
                }

                Console.WriteLine();
                Console.WriteLine("1. Dizi :" + outputStr1);
                Console.WriteLine();


                Console.WriteLine("2. dizi uzunlugunu giriniz:");
                var secondSizeInput = Console.In.ReadLine();

                size2 = Convert.ToInt32(secondSizeInput);


                Array2 = new int[size2];

                if (Array2.Count() > Array1.Count())
                {
                    Console.WriteLine("2. dizi, 1. diziden daha uzun olamaz.Lutfen programi yeniden baslatiniz");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("2. dizi elemanlarini giriniz:");

                    for (int i = 0; i < Array2.Length; i++)
                    {
                        var input = Console.In.ReadLine();
                        Array2[i] = Convert.ToInt32(input);
                    }

                    Console.WriteLine();

                    string outputStr2 = "";
                    foreach (var item in Array2)
                    {
                        outputStr2 += " " + item;
                    }

                    Console.WriteLine("1. Dizi :" + outputStr1);
                    Console.WriteLine("2. Dizi :" + outputStr2);
                    Console.WriteLine();
                }

                #endregion

            #region SiraliAltKumeMi
                if (SiraliAltKumeMi(Array1, Array2))
                {
                    Console.WriteLine("2. Dizi  1. Dizi içinde sıralı biçimde bulunmaktadir.");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("2. Dizi , 1. Dizi içinde sıralı biçimde bulunmamaktadir.");
                    Console.Read();
                }
                #endregion


            }
            catch (Exception ex)
            {
                Console.WriteLine("Girilen deger gecerli bir deger degildir.Lutfen programi yeniden baslatiniz");
                Console.Read();
            }


            #region algorithm
            bool SiraliAltKumeMi(int[] array1, int[] array2)
            {

                int index = 0;
                int[] tempArray = new int[array2.Length];

                for (int i = 0; i < array1.Length; i++)
                {
                    var compItem = array1[i];
                    var listedItem = array2[index];
                    if (compItem == listedItem)
                    {
                        tempArray[index] = listedItem;
                        if (index < array2.Length - 1)
                            index++;
                    }
                }

                if (Enumerable.SequenceEqual(array2, tempArray))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            #endregion
        }
    }
}
