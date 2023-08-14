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

          
            int adt;     
            string soru, cevap;

            do
            {
                Console.WriteLine("*******************************************************************************************************");
                Console.WriteLine("Hoş Geldiniz Hangi Soru İstiyorsunuz Seçeniz ^_^ ");
                Console.WriteLine("*******************************************************************************************************");

                Console.WriteLine("(0).Çıkış.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(1).kullanıcının girdiği sayıların her birinin 3'e bölünüp bölünmediğini kontrol eder.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(2).kullanıcının isim ve soyisim girmesini sağlar, bu bilgileri kaydeder ve kaydedilen kişilerin listesini gösterir.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(3).astgele üretilen bir dizi sayıyı görüntüler ve bu dizide 50'den küçük olanları ayırarak tekrar görüntüler.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(4).kullanıcının istediği sayıda öğrenci bilgisi girmesine olanak sağlar. Her öğrenci için numara, isim ve telefon bilgilerini alır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(5).kullanıcının sürekli olarak iki sayı girmesine ve seçilen matematiksel işlemi sonuçlandırmasına olanak tanır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(6).kullanıcının bir ay numarası girmesiyle o ayın kaç gün çektiğini belirtir.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(7).kullanıcının girdiği bir sayının faktöriyelini hesaplayarak sonucu gösterir.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.Write("Sorunuz Numarası Giriniz : ");
                soru = Console.ReadLine();
                Console.Clear();


                //****************************************************************************************************//

                if (soru == "1")
                {
                    do
                    {
                        Console.Write("kaç Adet Sayaı Gireceksiniz : ");
                        adt = int.Parse(Console.ReadLine());

                        int[] sayılar = new int[adt];

                        for (int i = 0; i < sayılar.Length; i++)
                        {
                            Console.Write((i + 1) + ".Sayının Giriniz : ");
                            sayılar[i] = int.Parse(Console.ReadLine());
                        }
                        foreach (var item in sayılar)
                        {
                            if (item % 3 == 0)
                            {
                                Console.WriteLine("Bu Sayı 3,Te Tem Bölünebilir : " + item);
                            }
                            else
                            {
                                Console.WriteLine("Bu Sayı 3,Ten Tem Bölünmez." + item);
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



                //***********************************************************************//

                else if (soru == "2")
                {
                    do
                    {
                        Console.Write("kaç Adet İsim Gireceksiniz : ");
                        adt = int.Parse(Console.ReadLine());
                        Console.Clear();

                        string[] isemler = new string[adt];
                        string[] soyisim = new string[adt];

                        for (int i = 0; i < isemler.Length; i++)
                        {
                            Console.Write((i + 1) + ".Kişinin İsimni Giriniz : ");
                            isemler[i] = Console.ReadLine();

                            Console.Write((i + 1) + ".Kişinin Soyisimnin Giriniz : ");
                            soyisim[i] = Console.ReadLine();
                            Console.Clear();

                        }
                        Console.WriteLine("Kayıtlı Kişiler Listemek İçin Bir Tuşe Basın.");

                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Kayıtlımış İsimler.");

                        for (int i = 0; i < isemler.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "." + isemler[i] + " " + soyisim[i]);
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
                        int[] sayılar = new int[20];
                        Random rastgele = new Random();

                        Console.WriteLine("Üretlen Rastgele Sayılar.");

                        for (int i = 0; i < sayılar.Length; i++)
                        {
                            sayılar[i] = rastgele.Next(1, 100);
                            Console.WriteLine(sayılar[i]);
                        }
                        Console.WriteLine("Üretlen Rastgele Sayılar Görmek İçin Tuşe Basın.");
                        Console.ReadKey();
                        foreach (var item in sayılar)
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


                else if (soru == "4")
                {
                    do
                    {
                        Console.Write("kaç Adet Öğrenci Gireceksiniz : ");
                        adt = int.Parse(Console.ReadLine());
                        Console.Clear();

                        int[] Öğrenci_numarası = new int[adt];
                        string[] Öğrenci_isemler = new string[adt];
                        int[] Öğrenci_tel = new int[adt];


                        for (int i = 0; i < Öğrenci_isemler.Length; i++)
                        {
                            Console.Write((i + 1) + ".Öğrenci Numarası Giriniz : ");
                            Öğrenci_numarası[i] = int.Parse(Console.ReadLine());

                            Console.Write((i + 1) + ".Öğrenci İseminin Giriniz : ");
                            Öğrenci_isemler[i] = (Console.ReadLine());

                            Console.Write((i + 1) + ".Öğrenci Tel Giriniz : ");
                            Öğrenci_tel[i] = int.Parse(Console.ReadLine());

                        }
                        Console.Clear();
                        int indexNO;
                        do
                        {
                            Console.Write("Aramak İstediğiniz Öğrencinin Okul Numarasını Giriniz : ");
                            int arama = int.Parse(Console.ReadLine());
                            indexNO = Array.IndexOf(Öğrenci_numarası, arama);

                            if (indexNO == -1)
                            {
                                Console.WriteLine("Bu Okul Numarasında Kayıtlı Öğrenci Bulunamdı. ");
                            }
                            else
                            {
                                Console.WriteLine("-----------Aranan Öğrencinin Bilgileri--------------");
                                Console.WriteLine("Öğrencinin Numarasını : " + Öğrenci_numarası[indexNO]);
                                Console.WriteLine("Öğrencinin İseminin : " + Öğrenci_isemler[indexNO]);
                                Console.WriteLine("Öğrencinin Tel Numarasını : " + Öğrenci_tel[indexNO]);
                            }
                        } while (indexNO == -1);

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
                    double sayı1, sayı2, islem, toplam;
                    do
                    {
                        Console.Write("1.Sayayı Giriniz : ");
                        sayı1 = int.Parse(Console.ReadLine());
                        Console.Write("2.Sayayı Giriniz : ");
                        sayı2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("0.Çıkış.");
                        Console.WriteLine("1.Toplam.");
                        Console.WriteLine("2.Çıkarma.");
                        Console.WriteLine("3.Çarpma.");
                        Console.WriteLine("4.Bölme.");

                        Console.Write("Bir işlem Seçeniz : ");
                        islem = int.Parse(Console.ReadLine());

                        switch (islem)
                        {
                            case 1:
                                toplam = sayı1 + sayı2;
                                Console.WriteLine("İşlemi Sonucu : " + toplam);
                            break;

                            case 2:
                                toplam = sayı1 - sayı2;
                                Console.WriteLine("İşlemi Sonucu : " + toplam);
                            break;

                            case 3:
                                toplam = sayı1 * sayı2;
                                Console.WriteLine("İşlemi Sonucu : " + toplam);
                            break;

                            case 4:
                                toplam = sayı1 / sayı2;
                                Console.WriteLine("İşlemi Sonucu : " + toplam);
                            break;

                            default:
                                Console.WriteLine("Geçersiz Seçem Lütfen Tekrer Giriniz.");
                            continue;
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
                        int ay;
                        Console.WriteLine("Bir Ay Numarası Giriniz (1-12) : ");
                        ay = int.Parse(Console.ReadLine());

                        switch (ay)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                Console.WriteLine("Girdiğiniz Ay 31 Gün Çekiyor.");
                            break;

                            case 2:
                                Console.WriteLine("Girdiğiniz Ay 28 Gün Çekiyor.");
                            break;

                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                Console.WriteLine("Girdiğiniz Ay 30 Gün Çekiyor.");
                            break;

                            default:
                                Console.WriteLine("Geçersiz Seçem Lütfen Tekrer Giriniz.");
                            break;
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

                else if (soru == "7")
                {

                    do
                    {
                        int sayı;

                        Console.Write("Bir Sayıyı Giriniz : ");
                        sayı = int.Parse(Console.ReadLine());
                        int faktöryal = 1;

                        for (int i = 1; i <= sayı; i++)
                        {
                            faktöryal *= i;
                        }
                        Console.WriteLine(sayı + "!= " + faktöryal);

                        Console.Write("Devam etmek istiyor musunuz? (Evet için 'e' veya 'E', Hayır için 'h' veya 'H'): ");
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
