using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1;2;3;4)
            //1: Degisken türü
            //2:Degisken Adı
            //3:In
            //4:Liste,koleksiyon,dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers) 
            //{
            //Console.WriteLine(number);
            //} 


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach(int number in numbers)
            //{
            //    if (number %2== 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>();
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //     Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach(char c in word) {
            //Console.WriteLine(c);
            //} 



            #endregion


            #region örnek sınav uygulaması

          //  Console.Write("*******c# eğitim kampı sınav uygulaması********");
          //  Console.WriteLine();
          //  Console.WriteLine();
          //  Console.WriteLine();
          //  Console.WriteLine();


          //  //Sınıftaki öğrenci sayısını kullanıcıdan alma
          //  Console.WriteLine("------------------");
          //  Console.WriteLine("Sınıfızda kaç öğrenci var;");
          //  int studentCount = int.Parse(Console.ReadLine());
          //  Console.WriteLine("--------------------");


          //  //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
          //  string[] studentNames = new string[studentCount];
          //  double[] studentExamsAvg = new double[studentCount];

          //  for(int i = 0; i < studentCount; i++)
          //  {
          //      Console.Write($"{i+1}.Öğrenci ismi giriniz");
          //      studentNames[i]=Console.ReadLine();
          //      double totalExamResult = 0;

          //      //Her öğrenci için 3 sınav notu girişi


          //      for(int j=0;j<3;j++) 
          //      {
          //          Console.WriteLine($("{studentNames[i]} isimli öğrencini {j+1}. sınav notunu giriniz:"); 
          //          double value=double.Parse(Console.ReadLine());
          //          totalExamResult += value;//notları topluyoruz

          //      }
          //      Console.WriteLine()

          //      studentExamsAvg[i] = totalExamResult/3;
          //  }


          ////Sınav ortalmaları
          //  for(int i = 0;i < studentCount;i++)
          //  {
          //      Console.WriteLine($"{studentNames[i]} adlı öğrencini ortalması: {studentExamsAvg[i]}");

          //      //öğrencilerin ortalamasını ve geçip kalma durumları

          //      if (studentExamsAvg[i] >=50)
          //      {
          //          Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
          //      }
          //      else 
          //      {
          //          Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
          //      }
          //      Console.WriteLine("------------------");
          //  }



            #endregion
        }
    }
}
