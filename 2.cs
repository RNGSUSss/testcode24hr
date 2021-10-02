using System;

namespace testcode2
{
    enum Menu
    {
        Login = 1,
        Register,
    }
    class Program
    {
        static void PrintScreenMenu()//พิมหน้าหลัก
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            Input();
        }
        static void PrintHeader()//พิมส่วนหัว
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("__________________________");
        }
        static void PrintListMenu()//พิมลิสเมนู
        {
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
        }
        static void Input()
        {
            Console.WriteLine("Select Menu");//รับค่า input จาก keyboard
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            Login(menu);
            Register(menu);
            
        }
        static void Login(Menu menu)
        {
            if (menu == Menu.Login)
            {
                ShowLoginMenu();
            }
        }
        static void ShowLoginMenu()//แสดงหน้าต่าง login 
        {
            Console.Clear();
            PrintLogin();
        }
        static void PrintLogin()//แสดงหน้า login 
        {
            Console.WriteLine("Login Screen");
            Console.WriteLine("____________");
            Console.WriteLine("Input name :");
            Console.WriteLine("Input pasword :");
        }
        static void ShowMessageInputIncorrect()//ใส่ผิด ให้ใส่ใหม่
        {
            Console.Clear();
            Console.WriteLine("Menu In correct try again ");
            PrintListMenu();
            Input();
        }
        static void Register(Menu menu)
        {
            if (menu == Menu.Register)
            {
                ShowRegisterMenu();
            }
        }
        static void ShowRegisterMenu()//แสดงหน้าต่างก่อน register
        {
            Console.Clear();
            StudentOrEmployee();
            
        }
        static void StudentOrEmployee()//ถามว่าเป็นนักเรียนหรือพนักงาน
        {
            Console.WriteLine("Your are Student(1) Or Employee(2) ");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                PrintStudentRegister();
            }
            else if (type == 2)
            {
                PrintEmployeeRegister();
            }
        }
        static void PrintStudentRegister()//แสดงหน้าต่าง register ของนักเรียน
        {
            Console.WriteLine("Register new Person");
            Console.WriteLine("___________________");
            Console.WriteLine("Input name :");
            Console.WriteLine("Input password :");
            Console.WriteLine("Input User Type :");
            Console.WriteLine("Student ID :");
        }
        static void PrintEmployeeRegister()//แสดงหน้าต่าง register ของพนักงาน
        {
            Console.WriteLine("Register new Person");
            Console.WriteLine("___________________");
            Console.WriteLine("Input name :");
            Console.WriteLine("Input password :");
            Console.WriteLine("Input User Type :");
            Console.WriteLine("Employee ID :");
        }
        static void Main(string[] args)
        {
            PrintScreenMenu();

            Console.ReadLine();
        }
    }
}
