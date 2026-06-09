namespace PROJE16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] SayiDizisi = new int[5];

                for (int i = 0; i < SayiDizisi.Length; i++)
                {
                    Console.Write("Dizinin {0}. Elemanını Giriniz : ", i);
                    string Metin = Console.ReadLine();
                    SayiDizisi[i] = Convert.ToInt32(Metin);
                }

                for (int i = 0; i < SayiDizisi.Length - 1; i++)
                {
                    for (int j = i + 1; j < SayiDizisi.Length; j++)
                    {
                        if (SayiDizisi[i] > SayiDizisi[j])
                        {
                            int TEMP = SayiDizisi[i];
                            SayiDizisi[i] = SayiDizisi[j];
                            SayiDizisi[j] = TEMP;
                        }
                    }
                }

                string SayiMetin = "";
                foreach (int Sayi in SayiDizisi)
                {
                    SayiMetin += Sayi.ToString() + "-";
                }

                Console.WriteLine("Girilen sayıların küçükten büyüğe sıralanmış şekli {0} 'dır.",
                    SayiMetin.Trim('-'));

            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
