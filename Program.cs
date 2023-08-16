using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string soru, cevap;

            do
            {
                Console.WriteLine("*******************************************************************************************************");
                Console.WriteLine("Hoş Geldiniz Hangi Soru İstiyorsunuz Seçeniz ^_^ ");
                Console.WriteLine("*******************************************************************************************************");

                Console.WriteLine("(0).Çıkış.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(1).kullanıcıdan 3 sayı alarak bu sayıların toplamını ve ortalamasını hesaplar. \r\nKullanıcının isteğine bağlı olarak işlemi tekrarlayabilir.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(2).Kullanıcıdan kaç kişi gireceği bilgisini alır, ardından girdiği kişi sayısı \r\nkadar isim alarak bir isim listesi oluşturur ve listeyi ekrana yazar.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(3).Kullanıcıdan kaç adet sayı gireceği bilgisini alır. Ardından girdiği sayı adedi \r\nkadar sayı alarak her bir sayının 3'e bölünüp bölünmediğini kontrol eder ve sonuçları ekrana yazar.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(4).Kullanıcıdan kaç kişinin kaydını gireceği bilgisini alır. Ardından girdiği kişi \r\nsayısı kadar sırasıyla isim ve soyisim alarak bir isim-soyisim listesi oluşturur ve listeyi ekrana yazar.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(5).Rastgele 20 sayı oluşturur ve bu sayıları ekrana yazar. Ardından bu sayılar içinde \r\n50'den küçük olanları filtreleyerek ekrana yazar.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(6).Kullanıcıdan kaç öğrenci bilgisi girileceği bilgisini alır. Ardından girdiği \r\nöğrenci sayısı kadar öğrenci numarası, isim ve telefon numarası bilgilerini alır. \r\nSonrasında kullanıcıdan aranacak öğrenci numarasını alır, bu numarayı arar ve öğrenci \r\nbilgilerini ekrana yazar.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");



                Console.Write("Sorunuz Numarası Giriniz : ");
                soru = Console.ReadLine();
                Console.Clear();


                //****************************************************************************************************//

                if (soru == "1")
                {
                    do
                    {
                        int[] sayilar3 = new int[3];

                        for (int i = 0; i < sayilar3.Length; i++)
                        {
                            Console.Write((i + 1) + ". Sayıyı Giriniz : ");
                            sayilar3[i] = int.Parse(Console.ReadLine());
                        }
                        //int toplam = sayilar3[0]+sayilar3[1]+sayilar3[2];

                        int toplam = 0;
                        foreach (var item in sayilar3)
                        {
                            toplam += item; //toplam = toplam + item;
                        }
                        double ortalama = (double)toplam / sayilar3.Length;

                        Console.WriteLine("Sayıların Toplamı = " + toplam);
                        Console.WriteLine("Sayıların Ortalaması = " + ortalama);


                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();
                }



                //***********************************************************************//

                else if (soru == "2")
                {
                    do
                    {
                        Console.Write("Kaç kişi gireceksiniz : ");
                        int adet = int.Parse(Console.ReadLine());


                        string[] isimler = new string[adet];

                        for (int i = 0; i < isimler.Length; i++)
                        {
                            Console.Write((i + 1) + ".İsimi Girin : ");
                            isimler[i] = Console.ReadLine();
                        }

                        Console.WriteLine("-------------------");
                        Console.WriteLine("İsimleri Listelemek için bir tuşa basınız : ");
                        Console.WriteLine("-------------------");
                        Console.ReadKey();
                   
                        foreach (var veri in isimler)
                        {
                            Console.WriteLine(veri + " ");
                        }

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();
                }



                ////***********************************************************************//

                else if (soru == "3")
                {
                    do
                    {
                        Console.Write("Kaç Adet Sayı Gireceksiniz : ");
                        int adet = int.Parse(Console.ReadLine());

                        int[] kullanicidanGelenSayilar = new int[adet];

                        for (int i = 0; i < kullanicidanGelenSayilar.Length; i++)
                        {
                            Console.Write((i + 1) + ". Sayıyı Giriniz : ");
                            kullanicidanGelenSayilar[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("-------------------");
                        Console.WriteLine("İsimleri Listelemek için bir tuşa basınız : ");
                        Console.WriteLine("-------------------");
                        Console.ReadKey();
                        //Foreach ile ekrana yazdırma
                        foreach (var item in kullanicidanGelenSayilar)
                        {
                            if (item % 3 == 0)
                            {
                                Console.WriteLine(item + "Sayısı 3'e Tam Bölünüyor");
                            }
                        }

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();

                }
                ////***********************************************************************//


                else if (soru == "4")
                {
                    do
                    {
                        Console.Write("Kaç Kişinin Kaydını Yapacaksınız : ");
                        int adet = int.Parse(Console.ReadLine());

                        string[] isim = new string[adet];
                        string[] soyisim = new string[adet];

                        for (int i = 0; i < isim.Length; i++)
                        {
                            Console.Write((i + 1) + ".Kişinin İsmini Girin : ");
                            isim[i] = Console.ReadLine();

                            Console.Write((i + 1) + ".Kişinin Soyismini Girin : ");
                            soyisim[i] = Console.ReadLine();
                        }
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Kayıtlı Kişileri Listelemek İçin Bir Tuşa Basın.");
                        Console.WriteLine("-------------------");
                        Console.ReadKey();
                        Console.WriteLine();

                        for (int i = 0; i < isim.Length; i++)
                        {
                            Console.WriteLine(isim[i] + " " + soyisim[i]);
                        }

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }

                        else
                        {
                            Console.Clear();
                        }

                    } while (true);
                    Console.Clear();
                }


                ////***********************************************************************//

                else if (soru == "5")
                {
                  
                    do
                    {

                        int[] rastgeleSayilar = new int[20];
                        Random rnd = new Random();
                        for (int i = 0; i < rastgeleSayilar.Length; i++)
                        {
                            rastgeleSayilar[i] = rnd.Next(0, 100);
                        }
                        Console.WriteLine("Üretilen rastgele sayılar");
                        foreach (var item in rastgeleSayilar)
                        {

                            Console.WriteLine(item);
                        }
                        Console.WriteLine("50 den küçük olanları görmek için bir tuşa basınız");
                        Console.ReadKey();
                        Console.WriteLine();
                        foreach (var item in rastgeleSayilar)
                        {
                            if (item < 50)
                            {
                                Console.WriteLine(item);
                            }
                        }

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();
                }

                ////***********************************************************************//

                else if (soru == "6")
                {
                    do
                    {
                        Console.Write("Kaç Adet Öğrenci Gireceksini : ");
                        int adet = int.Parse(Console.ReadLine());

                        string[] ogrenciNO = new string[adet];
                        string[] isim = new string[adet];
                        string[] telefonNO = new string[adet];

                        for (int i = 0; i < isim.Length; i++)
                        {
                            Console.Write("Öğrencinin Numarasını Giriniz : ");
                            ogrenciNO[i] = Console.ReadLine();

                            Console.Write("Öğrencinin Adını Giriniz : ");
                            isim[i] = Console.ReadLine();

                            Console.Write("Öğrencinin Telefon Numarasını Giriniz : ");
                            telefonNO[i] = Console.ReadLine();


                        }
                        Console.Clear();
                        int indexNO;
                        do
                        {
                            Console.Write("Aramak İstediğiniz Öğrencinin Okul Numarasını Giriniz : ");
                            string arananNo = Console.ReadLine();
                            indexNO = Array.IndexOf(ogrenciNO, arananNo);
                            if (indexNO == -1)
                            {
                                Console.WriteLine("Bu okul numarasında kayıtlı öğrenci bulunamadı ");
                            }
                            else
                            {
                                Console.WriteLine("---Aranan Öğrencinin Bilgileri---- ");
                                Console.WriteLine("Okul No : " + ogrenciNO[indexNO]);
                                Console.WriteLine("Öğrencinin Adı : " + isim[indexNO]);
                                Console.WriteLine("Öğrencinin Telefon Numarası : " + telefonNO[indexNO]);
                            }
                        } while (indexNO == -1);




                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();

                }


            } while (soru != "0");

            Console.WriteLine("Programdan Çıkılıyor...");
            Console.ReadKey();
        }
    }
}
