using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantExample
{

    public class Restaurant
    {
        private string name;
        private string address;
        private double bahşişOranı;



        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double BahşişOranı
        {
            get { return bahşişOranı; }
            set
            {
                if (value >= 0)
                {
                    bahşişOranı = value;
                }


            }
        }


       // Constructor
        public Restaurant(string name, string address, double bahşişOranı)
        {
            Name = name;    
            Address = address;
            BahşişOranı = bahşişOranı;
        }

        public Restaurant()
        {
        }


        // kontrollü bir while döngüsü yönteminin kullanılması, 
        // sipariş edilen her gıda maddesi için fiyatı toplayacak 
        // ve rastgele sayıda gıda maddesi için bir ara toplam tutacaktır. 


        public void GenerateReceipt()       // Method
        {
            double fiyat = 0;

            int kullanıcı = 0;

            double AraToplam = 0;

            double BahşişMiktarı = 0;

            double GenelToplam = 0;
           

            while (fiyat != -1)
            {
                AraToplam = AraToplam + fiyat;      // Kullanıcı yeni fiyat girdikçe ara toplam artmaya devam edecek.

                Console.Write("Ürün fiyatını giriniz : [Çıkış için -1]");

                fiyat = Convert.ToDouble(Console.ReadLine());       // Kullanıcı ne girerse double'ye çevrilir.
            }


            // Tüm yiyecek maddelerinin ara toplamı hesaplandıktan sonra, grup 6 veya daha fazla kişiden oluşuyorsa,
            // metot daha sonra bahşiş miktarını belirleyecektir.


            Console.Write("Grupta kaç kişi var : ");

            kullanıcı = Convert.ToInt32(Console.ReadLine());

            if (kullanıcı >= 6)
            {
                BahşişMiktarı = AraToplam * bahşişOranı;
            }

            GenelToplam = AraToplam + BahşişMiktarı;

            Console.WriteLine("Ara Toplam : {0}", AraToplam);

            Console.WriteLine("{0} Bahşiş : {1}", bahşişOranı, BahşişMiktarı);

            Console.WriteLine("Genel toplam : {0}", GenelToplam);
        }

    }


  
}
