using System;


namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
            // -- KURALLAR --
            // 1- Program içerisinde kullanılan isimler degişken olarak kullanılmaz. (ör. class)
            // 2- string System = "Bu değişken olamaz"; 
            // 3- Herhangi bir sayı veya rakamla başlayan değişken isimleri kullanılamaz. (ör. 1ad)
            // 4- Değişken adı hiçbir zaman boşluk içeremez. (ör. degisken ad)
            // 5- Boşluk yerine _ kullanılabilir. (ör. degisken_ad)


            // string kelime = null;
            string kelime = "Ilayda";
            Console.WriteLine(kelime);



            //         --- Veri Tipleri ----

/*
            byte b = 5;         //0-255 1byte
            sbyte sb = 5;        //-128 - +127 1byte
            short s = 5;        //-32.000 - +32.000 2byte
            ushort us = 5;       //0 -  65365 2byte

            Int16 i16 = 2;      // 2byte
            int i = 2;          //4 byte
            Int32 i32 = 2;      //4byte
            Int64 i64 = 2;      //8 byte
            uint ui = 2;        //4byte
            long l = 2;         //8byte
            ulong ul = 2;        //8byte

            float f = 5;        //4byte
            double d = 5.4;     //8byte

            char c = 'a';       //2byte
            string str = "Tolunay"; 

            bool bl = false;
            
            

            DateTime dt = DateTime.Now;     // Anlık olarak saat ve tarihi verir.
            Console.WriteLine(dt);

            // Object yani nesne bütün herşeyi tutabilir. -char -string -int -decimal

            object o1 = "x";    //string
            object o2 = 'y';    //char
            object o3 = 4.5;    //decimal
            object o4 = 6;      //integer
           
            string metin1 = string.Empty;
            string metin2 = null;
            string metin3;

            string strName = "Ilayda Leblebici";
            string isim = "Ilayda";
            string soyisim = "Leblebici";
            string tamisim = isim + " " + soyisim;

            Console.WriteLine(strName);
            Console.WriteLine(tamisim);
    
            
            int sayi1 = 5;
            int sayi2 = 3;
            int sayi3 = sayi1 * sayi2;


            //Bool ==> True yada False değer alır. Genelde kıyaslama işlemlerinde kullanılır.
            bool boolean1 = 10 > 2;//True değer döndürür.
*/


            // -- Değişken Dönüşümleri -- 

            //string => int
            //--------------------------------
            // 1 - int.Parse("16") 
            // 2 - Convert.ToInt32(Stringe Dönüştürülecek Nesne);


            string metin20 = "20"; //string türündekiler her zaman " " içerisinde yazılır.
            int sayi20 = 20;
            string metin4 = metin20 + sayi20.ToString();  // String cinsinde toplama yapılır. String'te toplama yanyana yazmak anlamına gelir.

            Console.WriteLine(metin4);   //2020 şeklinde iki stringi birleştirmiş oldu. 

            // int => str 
            // -------------------------------
            // 1 - .ToString() 
            // 2 - Convert.ToString(String'e Dönüştürülecek Nesne);


            int sayi3 = sayi20 + Convert.ToInt32(metin20);  
            /*Burada sayi20 zaten integer ve diğer metin20 değeride int çevrildiğinden dolayı iki integer değerin toplamı anlamına gelir. 
            Yani sayısal 2 ifadenin toplamı olarak ifade edilebilir.Çünkü iki değerde int olur.*/

            Console.WriteLine(sayi3);  //Çıktı: 40 



            int sayi4 = sayi20 + int.Parse(metin20);  //Çıktı: 40
           
            Console.WriteLine(sayi4);

            string gunayyıl = DateTime.Now.ToString("dd.MM.yyyy");  //Şu anki zaman string veritipinde gün.ay.yıl olarak gelir. (05.10.2022)
            Console.WriteLine(gunayyıl);
            
            string saat = DateTime.Now.ToString("HH.mm");  //Şu anki saati bize verir. (ör. 22.16)
            Console.WriteLine(saat);

            Console.ReadLine();  // External Terminali Açık Tutmak İçin Kullanılır.
        }
    }
}
