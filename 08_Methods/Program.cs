using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region      Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer listele,ekle,sil,güncelle
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("ayşe yıldız");
            //    Console.WriteLine("hakan öztürk");
            //    Console.WriteLine("merve çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}

            #endregion

            #region    Geriye Deger Döndürmeyen Parametreli Metotlar
            //void WriteMethod(string Customername) 
            //{
            //    Console.WriteLine(Customername);
            //        }
            //WriteMethod("mehmet yıldırım");

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri:"+name+""+surname);
            //}

            //CustomerCard("mehmet", "yıldız");
            //CustomerCard("ayşegül ", "kaya");




            #endregion

            #region     Geriye Değer Döndrmeyen int Parametreli Metotlar
            //void sum(int  number1,int number2,int number3) 
            //{
            //    int result=number1 + number2+number3;
            //    Console.WriteLine(result);
            //}
            //sum(5, 5, 6);

            #endregion
            #region Geriye Deger Döndüren Metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";

            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "kaya";
            //    return name+" " + surname;

            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Deger Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{

            //    string cardInfo = "Ülke: "+ countryName + " - Başkent: "
            //        + capital + " - Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            ////int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Örnek Uygulama

            //string Examresult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi. Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(Examresult("Ali", 78, 41, 85));
            //Console.WriteLine(Examresult("Ayşe", 25, 41, 32));

            #endregion

        }
    }
}
