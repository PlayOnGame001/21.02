using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02
{
    #region ex 2
    delegate void Content(string str);
    class Backpack
    {
    //    private string color;
    //    private string company;
    //    private string textile;
    //    private int weight;
    //    private int volume;
    //    private List<string> content;
    //    private string ContentName;
    //    public Backpack() { }
    //    public Backpack(string color, string company, string textile, int weight, int volume, List<string> content, string contentName)
    //    {
    //        this.color = color;
    //        this.company = company;
    //        this.textile = textile;
    //        this.weight = weight;
    //        this.volume = volume;
    //        this.content = content;
    //        ContentName = contentName;
    //    }

    //    public void EnterBackpack()
    //    {
    //        Console.Write("Enter color: ");
    //        color = Console.ReadLine();
    //        Console.Write("Enter company: ");
    //        company = Console.ReadLine();
    //        Console.Write("Enter textile: ");
    //        textile = Console.ReadLine();
    //        Console.Write("Enter weight: ");
    //        weight = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter volume: ");
    //        volume = Convert.ToInt32(Console.ReadLine());

    //    }
    //    public void PrintBackpack()
    //    {
    //        Console.WriteLine($"Color: {color}");
    //        Console.WriteLine($"Company: {company}");
    //        Console.WriteLine($"Textile: {textile}");
    //        Console.WriteLine($"Weight: {weight}");
    //        Console.WriteLine($"Volume: {volume}");
    //        Console.WriteLine($"Content: {content}");
    //    }
    //    event Content ev;
    //    public void EnterContent()
    //    {
    //        Console.WriteLine("Enter content name:");
    //        ContentName = Console.ReadLine();
    //        content.Add(ContentName);
    //        ev?.Invoke(ContentName);
    //    }
    //}
    #endregion

    #region ex3
    //internal class Program
    //{
    //    delegate void ColorRGB(int rgb);
    //    delegate void Massive(int[] mas);
    //    delegate bool FindWord(string str);

    //    static void Main(string[] args)
    //    {
    //        #region ex1
    //        ColorRGB RGB = delegate (int rgb)
    //        {
    //            Console.WriteLine($"RGB = {rgb}");
    //        };
    //        RGB(23);
    //        #endregion

    //        #region ex3
    //        Massive Multiply = (int[] arr) =>
    //        {
    //            int amount = 0;
    //            foreach (int a in arr)
    //            {
    //                if (a % 7 == 0) { amount++; }
    //            }
    //            Console.WriteLine($"Total multiples of seven: {amount}");
    //        };
    //        int[] mas = new int[] { 12, 49, 21, 78, 32, 7, 11, 3, 56 };
    //        Multiply(mas);
            #endregion

            #region ex4
            //Massive Positive = (int[] arr) =>
            //{
            //    int count = 0;
            //    foreach (int a in arr)
            //    {
            //        if (a >= 0)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"Total positive number: {count}");
            //};
            //int[] mas = new int[10];
            //Random rand = new Random();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = rand.Next(-50, 50);
            //}
            //Positive(mas);
            #endregion

            #region ex5
            //Massive UniqueNegative = (int[] arr) =>
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] < 0)
            //        {
            //            count = 0;
            //            for (int j = 0; j < arr.Length; j++)
            //            {
            //                if (arr[i] != arr[j]) { count++; }
            //            }
            //            Console.WriteLine($"Count = {count}");
            //            if (count == arr.Length - 1)
            //            {
            //                Console.Write($"{arr[i]}  ");
            //            }
            //        }
            //    }
            //};
            //int[] mas = new int[10];
            //Random rand = new Random();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = rand.Next(-10, 10);
            //    Console.Write($"{mas[i]}  ");
            //}
            //Console.WriteLine();
            //UniqueNegative(mas);
            #endregion

            #region ex6
            //FindWord find = (string str) =>
            //{
            //    Console.Write("Enter word: ");
            //    string word = Console.ReadLine();
            //    bool answer = str.Contains(word);
            //    return answer;
            //};
            //Console.WriteLine("Enter text: ");
            //string text = Console.ReadLine();
            //find(text);
            #endregion
        }
    }
