using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Random random = new Random();
            string text = "";
            int value;
            string output = "";
            double valueFixed;
            string newPath = "";
            var startDate = new DateTime(2018, 1, 1);
            char[] lettersEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] lettersRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            int count = 0;
            int amountOfFiles = 3; //to amount files
            int amountOfNotes = 4;  //to amount notes 

            for (int i = 0; i < amountOfNotes; i++)
            {

                string wordEng = "";
                string wordRus = "";

                // Adding new word to the list Eng
                for (int j = 1; j <= 10; j++)
                {
                    int letter_num = random.Next(0, lettersEng.Length - 1);
                    wordEng += lettersEng[letter_num];
                }
                // Adding new word to the list Rus
                for (int j = 1; j <= 10; j++)
                {
                    int letter_num = random.Next(0, lettersRus.Length - 1);
                    wordRus += lettersRus[letter_num];
                }



                for (int jk = 1; jk <= amountOfFiles; jk++)
                {
                    string path = $@"D:\file{jk}.txt";


                    using (StreamWriter stream = new StreamWriter(path, true))
                    {
                        string AlphabetEng = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
                        value = random.Next(1, 100000000);
                        Random rnd = new Random();
                        int Length = 10;
                        //объект StringBuilder с заранее заданным размером буфера под результирующую строку
                        StringBuilder sb = new StringBuilder(Length - 1);
                        //переменную для хранения случайной позиции символа из строки Alphabet
                        int Position = 0;

                        for (int zap = 0; zap < Length; zap++)
                        {
                            //получаем случайное число от 0 до последнего
                            //символа в строке Alphabet
                            Position = rnd.Next(0, AlphabetEng.Length - 1);
                            //добавляем выбранный символ в объект
                            //StringBuilder
                            sb.Append(AlphabetEng[Position]);
                        }
                        output = sb.ToString();

                        // To definite random int numbers
                        valueFixed = random.NextDouble() * 20; //To definite random float numbers
                        if (valueFixed <= 1)
                        {
                            valueFixed = random.NextDouble() * 20;
                        }

                        string strI = valueFixed.ToString("N8");

                        var newDate = startDate.AddDays(random.Next(1825));
                        var dat = newDate.ToString("yyyy.dd.MM");
                        int number = 0;
                        do
                        {
                            number = random.Next(1, 100000000);
                        }
                        while (number % 2 != 0);


                        text = dat + "||" + wordEng + "||" + wordRus + "||" + number + "||" + strI;
                        stream.WriteLine(text);
                        stream.Close();
                       }
                }
                 
               // var files = new[] { $@"D:\file{jk}.txt", $@"D:\file{jk}.txt" };
                var builder = new StringBuilder();
                
               
                
                
                

                for (int jk = 1; jk <= amountOfFiles; jk++)
                    builder.Append(File.ReadAllText($@"D:\file{jk}.txt"));
                    


                File.WriteAllText(@"D:\fileOutput.txt", builder.ToString());

               
               
            }
            Console.WriteLine("Введите элемент, который хотите удалить ");
            string chars = Console.ReadLine();
            if (chars == text)
            {
                count++;

            }
            Console.WriteLine(count);
            Console.ReadKey();
            
        }


    }


}
