using System;
using System.Collections.Generic;

namespace testcode1
{
    enum Menu
    {
        PlayGame = 1,
        Exit,
    }
    class Program
    {
        static void PrintMenuScreen()//function แสดง หน้าเมนู
        {
            Console.Clear();

            PrintHeader();
            PrintListMenu();
        }
        static void PrintHeader()//function แสดงเมนู header
        {
            Console.WriteLine("Welcome To Hangman Game");
            Console.WriteLine("_______________________");
        }
        static void PrintListMenu()//function แสดง list menu
        {
            Console.WriteLine("1.Play Game");
            Console.WriteLine("2.Exit");
        }
        static void Input()//รับค่า input จาก keyboard
        {
            Console.WriteLine("Please Select Menu :");

            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            Play(menu);
            Exit(menu);
        }
        static void Play(Menu menu)//เล่น
        {
            if (menu == Menu.PlayGame)
            {
                ShowGameScreen();
            }
            else ShowNothing();
        }
        static void Exit(Menu menu)//ปิด
        {
            if (menu == Menu.Exit)
            {
                ExitProgram();
            }
            else ShowNothing();
        }
        static void ShowGameScreen()//แสดงหน้าต่างเล่นเกม
        {
            Console.Clear();
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("_________________");
            Console.WriteLine("");
            //ShowInCorrectScore();

            ShowGameWord();

            InputWord();
        }
        static void ShowGameWord()//สุ่มคำ
        {
            string[] word = new string[] { "Tennis", "Football", "Badminton" };
            Random random = new Random();
            int resultrandom = random.Next(0, 2);
            string mytword = word[resultrandom];
            char[] guess = new char[mytword.Length];

            for (int i = 0; i < mytword.Length; i++)
            {
                Console.Write("_ ", guess);
            }
        }
        static void InputWord()//รับค่า ทายคำ
        {
            Console.WriteLine("Input letter alphabet :");
        }
        static void ExitProgram()//แสดงหน้าต่างปิดเกม
        {
            Console.Clear();
            Console.WriteLine("Close");
        }
        static void ShowNothing()//ใส่ input ผิด ให้ใส่ใหม่
        {
            
        }
        static void Main(string[] args)
        {
            PrintMenuScreen();
            Input();

            Console.ReadLine();
        }
    }
}
