using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cursor
{
    class Program
    {
        static void ShowInfo(DirectoryInfo directory, int cursor) //метод, который выводит информацию об объекте
        {
            Console.BackgroundColor = ConsoleColor.Green; //меняет цвет фона текста
            int index = 0;
            foreach (FileSystemInfo fInfo in directory.GetFileSystemInfos()) //для каждого файла и папки 
            {
                if (index == cursor)
                    Console.ForegroundColor = ConsoleColor.Red; //меняет цвет самого текста
                index++;
                if (fInfo.GetType() == typeof(FileInfo)) //определяет тип объекта , файл или папка
                    Console.Write("File: ");
                else
                    Console.Write("Directory: ");
                Console.WriteLine(fInfo.Name);
            }
                    
        }

        static void Main(string[] args)
        {
            int cursor = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\DELL"); //создает новый экземпляр класса DirectoryInfo
            while(true)
            {
                Console.Clear(); //очищает окно консоли 
                ShowInfo(directory, cursor);
                ConsoleKeyInfo pressedKey = Console.ReadKey(); //описывает функцию нажатой клавиши
                if (pressedKey.Key == ConsoleKey.UpArrow)
                    if (cursor > 0)
                        cursor--;
                if (pressedKey.Key == ConsoleKey.DownArrow)
                    if (cursor < directory.GetFileSystemInfos().Length - 1)
                        cursor++;
                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    FileSystemInfo fs = directory.GetFileSystemInfos()[cursor];
                    if (fs.GetType() == typeof(DirectoryInfo)) 
                    {
                        directory = new DirectoryInfo(fs.FullName); //создает новый экземпляр класса diretoryinfo
                    }
                    else
                    {
                        try // пытается выполнить прописанные операции 
                        {
                            Console.Clear();
                            StreamReader sr = new StreamReader(fs.FullName); 
                            Console.Write(sr.ReadToEnd());
                            Console.ReadKey(); 
                            sr.Close();
                        }

                        catch (Exception e) //при невыполнении выше прописанных операций
                        {
                            Console.WriteLine("error");
                        }
                    }
                    break;
                }
                if (pressedKey.Key == ConsoleKey.Backspace)
                {
                    try
                    {
                        directory = Directory.GetParent(directory.FullName); //возвращается в начальную папку 
                    }
                    catch (Exception e)
                    {

                    }
                }
                if (pressedKey.Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
