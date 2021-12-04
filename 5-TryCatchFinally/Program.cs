using System;

namespace PatikaCSharpTutorials
{
    class Program
    {
        public static void Main(string[] args)
        {

            try{
                Console.WriteLine("Bir Sayı giriniz:");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" +sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            // finally
            // {
            //    //Kod bloğu hata alsa bile çalışmasını istediğimiz durumları yazıyoruz
            //     Console.WriteLine("İşlem Tamamlandı.");
            // }


            //Özel Exceptipn mesajları


              try
              {
                  //int a=int.Parse(null); 
                  //int a=int.Parse("test");
                  int a=int.Parse("-20000000");
              }
            //   catch (ArgumentNullException ex)
            //   {
            //     Console.WriteLine("Boş değer girdiniz");
            //     Console.WriteLine(ex);
                  
            //   }      
              catch (FormatException ex)
              {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
                  
              }      
              catch (OverflowException ex)
              {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz!");
                Console.WriteLine(ex);
                  
              }      

        }
    }
}
