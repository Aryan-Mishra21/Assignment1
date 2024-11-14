using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            problem4 problem = new problem4();
            problem.run();
        }
    }
    class problem1
    {
        public void fun1()
        {
            double[] prices = { 1200, 1300, 320, 500, 800 };
            double total = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                total += prices[i];
            }
            if (total > 3000) total = total * (0.9);
            Console.WriteLine(total);
        }
    }
    public class problem2
    {
        public void fun()
        {
            Console.WriteLine("Enter the temprature in Celcius : ");
            double temp = Console.Read();
            if (!(temp < 0)) Console.WriteLine("Temprature is below the freezing point");

            Console.WriteLine(((temp * 9) / 5) + 32);
        }
    }
    class problem3
    {
        double balance = 1000;
        public void atm()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the ATM ");
                Console.WriteLine("For check balance press - 1");
                Console.WriteLine("For deposit money press - 2");
                Console.WriteLine("For withdraw money press - 3");
                Console.WriteLine("For exit press - 4");
                Console.WriteLine();
                Console.Write("Enter your response : ");
                string k = Console.ReadLine();
                switch (k)
                {
                    case "1":

                        checkBalance();
                        Console.WriteLine("\n*\n");
                        break;
                    case "2":

                        Console.Write("Enter the amount : ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(amount);
                        deposit(amount);
                        Console.WriteLine("\n*\n");
                        break;
                    case "3":

                        Console.Write("Enter the amount : ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(amount);
                        withdraw(amount);
                        Console.WriteLine("\n*\n");
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using Simple ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid response\n");
                        break;

                }
            }


            void deposit(double amount)
            {
                balance = balance + amount;
                Console.WriteLine($"Amount deposited succesfully : {amount}");

            }
            void checkBalance()
            {
                Console.WriteLine(balance.ToString());
            }
            void withdraw(double amount)
            {
                if (balance < amount) Console.WriteLine(" Sorry! Insufficient Balance");
                else
                {
                    balance -= amount;
                    Console.WriteLine("Amount withdrawl succesfully");
                }
            }
        }
    }
    public class problem4
    {
        public void run()
        {
            Console.WriteLine("Enter the marks of five subjects ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int a4 = Convert.ToInt32(Console.ReadLine());
            int a5 = Convert.ToInt32(Console.ReadLine());
            double average = (a1 + a2 + a3 + a4 + a5) / 5.0;
            Console.WriteLine(average);
            if (average > 90) Console.WriteLine("A");
            else if (average > 80) Console.WriteLine("B");
            else if (average > 70) Console.WriteLine("C");
            else if (average > 60) Console.WriteLine("D");
            else
            {
                Console.WriteLine("F");
            }
        }
    }
    class Problem5
    {
        //Question: Develop a C# application that asks the user to enter a password. The password should be validated based on the
        //following criteria: at least 8 characters long, contains at least one uppercase letter, one lowercase letter,
        //and one number. Display appropriate messages based on the validation result.
        public void checkPassword()
        {
            Console.Write("Enter the password : ");
            string pass = Console.ReadLine();
            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            if (pass.Length > 7)
            {
                foreach (char c in pass)
                {
                    if (char.IsDigit(c))
                        isDigit = true;
                    else if (char.IsLower(c))
                        isLower = true;
                    else if (char.IsUpper(c))
                        isUpper = true;
                }
                if (isUpper && isLower && isDigit)
                    Console.WriteLine("password is valid");
                return;
            }
            Console.WriteLine("Password is invalid. It must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number like qRi4n9gL");
        }

    }
    class Problem6
    {
        //Question: Write a C# program to calculate the fare of a taxi ride. The fare is calculated based on the distance traveled.
        //The first 2 kilometers are charged at a flat rate (Rs. 20), and any additional kilometers are charged at a per-kilometer rate.
        //Include a night surcharge if the ride occurs after 10 PM.
        public void GetTotalCharge()
        {
            double fixedCharge = 20;
            double chargePerKm = 5;
            double totalCharge = 0;
            Console.Write("Enter the distance travelled : ");
            double dis = double.Parse(Console.ReadLine());
            Console.Write("Enter the subcharge is applied : ");
            double subCharge = double.Parse(Console.ReadLine());
            if (dis < 3)
            {
                totalCharge = totalCharge + fixedCharge;
                Console.WriteLine("Your total charge is " + totalCharge.ToString());
                return;
            }
            totalCharge = ((dis - 2) * chargePerKm) + fixedCharge + subCharge;
            Console.WriteLine("Your total charge is " + totalCharge.ToString());
        }

    }
    class Problem7
    {
        //Question: A school tracks the attendance of students over 5 days.The system should be able to record attendance,
        //calculate the total number of days attended, and identify if a student has perfect attendance.
        int attendece = 0;
        int totalAttendence = 5;
        public void getAttendence()
        {
            Console.WriteLine("Your attendence is " + (totalAttendence - attendece).ToString());
        }
        public void attend()
        {
            attendece++;
        }
        public bool isPerfectattence()
        {
            return attendece > 2 ? true : false;
        }

    }
    class Problem8
    {
        //Question: An individual tracks their expenses for each month in a year.They want to calculate the total expenses for the
        //year and identify the month with the highest and lowest expenses.
        public void getExpenseDetails()
        {
            double[] months = new double[12];
            double totalExpense = 0;
            int maxExpenseMonth = 1;
            int minExpenseMonth = 1;
            for (int i = 0; i < months.Length; i++)
            {
                Console.Write("enter expense of " + (i + 1) + " month : ");
                months[i] = double.Parse(Console.ReadLine());
                totalExpense += months[i];
            }
            for (int i = 0; i < totalExpense; i++)
            {
                if (months[maxExpenseMonth] < months[i])
                {
                    maxExpenseMonth = i;
                }
                else if (months[minExpenseMonth] > months[i])
                {
                    minExpenseMonth = i;
                }
            }
            Console.WriteLine("Maximum expense month : " + maxExpenseMonth.ToString());
            Console.WriteLine("Minimum expense month : " + minExpenseMonth.ToString());
            Console.WriteLine("Total expense of year : " + totalExpense.ToString());


        }

    }
    class Problem9
    {
        //Question: Implement a shopping cart system where a user can add items, remove items, and view the total price.
        //Assume each item has a name and a price.
        Dictionary<string, double> cart = new Dictionary<string, double>();
        double total = 0;

        public void addItem(string name, double price)
        {
            cart.Add(name, price);
            total += price;
        }
        public void removeItem(string name)
        {
            total -= cart[name];
            cart.Remove(name);

        }
        public void getTotalPrice()
        {
            Console.WriteLine("Total price is " + total.ToString());
        }

    }
    class Problem10
    {
        //Question: Create a program that calculates the monthly salary of an employee based on their hourly wage and the number of
        //hours worked in a week.Consider that there are 4 weeks in a month.

        public void getMonthSallery()
        {
            int[] weekHours = new int[4];

            int totalHours = 0;
            Console.Write("Enter the wage per hour rate : ");
            int hourWage = int.Parse(Console.ReadLine());
            for (int i = 0; i < weekHours.Length; i++)
            {
                Console.Write("Enter the hours of " + (i + 1) + "week : ");
                weekHours[i] = int.Parse(Console.ReadLine());
                totalHours += weekHours[i];
            }
            Console.WriteLine("Your tatal sallery of months is " + (totalHours * hourWage).ToString());


        }


        // assignment 03 
        // question 01

        class A3q10
        {

            public string Name { get; set; }
            public int RollNo { get; set; }
            public int[] Marks { get; set; } = new int[5];
            public int TotalMarks { get; private set; }
            public double Percentage { get; private set; }


            public static string UniversityName;


            static A3q10()
            {
                UniversityName = "Default University";
            }


            public A3q10()
            {
                Name = "Unknown";
                RollNo = 0;
                for (int i = 0; i < Marks.Length; i++)
                {
                    Marks[i] = 0;
                }
                TotalMarks = 0;
                Percentage = 0.0;
            }


            public A3q10(string name, int rollNo, int[] marks)
            {
                Name = name;
                RollNo = rollNo;
                Marks = marks;
                CalculateResult();
            }


            public void ReadData()
            {
                Random random = new Random();


                string[] names = { "John", "Alice", "Bob", "Eve", "Charlie" };
                Name = names[random.Next(names.Length)];


                RollNo = random.Next(1, 1000);


                for (int i = 0; i < Marks.Length; i++)
                {
                    Marks[i] = random.Next(40, 100);
                }

                Console.WriteLine("Data generated automatically.");
            }


            public void CalculateResult()
            {
                TotalMarks = 0;
                for (int i = 0; i < Marks.Length; i++)
                {
                    TotalMarks += Marks[i];
                }
                Percentage = TotalMarks / 5.0;
            }


            public void Display()
            {
                Console.WriteLine("\nStudent Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Roll No: {RollNo}");
                Console.WriteLine($"University: {UniversityName}");
                Console.WriteLine("Marks: " + string.Join(", ", Marks));
                Console.WriteLine($"Total Marks: {TotalMarks}");
                Console.WriteLine($"Percentage: {Percentage:F2}%");
            }


        }

        //  Qusestion 02 



        interface Account
        {
            void Open_Account();
            void Close_Account();
        }

        interface Customer
        {
            void Display_Customer_Detail();
        }

        class A3q2 : Account, Customer
        {
            public string CustomerName { get; set; }
            public int AccountNumber { get; set; }
            public double Balance { get; private set; }

            public static string BankName;

            static A3q2()
            {
                BankName = "Default Bank";
            }

            public A3q2()
            {
                CustomerName = "Unknown";
                AccountNumber = 0;
                Balance = 0.0;
            }

            public A3q2(string customerName, int accountNumber, double initialBalance)
            {
                CustomerName = customerName;
                AccountNumber = accountNumber;
                Balance = initialBalance;
            }

            public void Open_Account()
            {
                Console.WriteLine($"Account opened for {CustomerName} with Account Number {AccountNumber} at {BankName}.");
            }

            public void Close_Account()
            {
                Console.WriteLine($"Account {AccountNumber} for {CustomerName} has been closed.");
            }

            public void Display_Customer_Detail()
            {
                Console.WriteLine("\nCustomer Details:");
                Console.WriteLine($"Name: {CustomerName}");
                Console.WriteLine($"Account Number: {AccountNumber}");
                Console.WriteLine($"Bank: {BankName}");
                Console.WriteLine($"Balance: {Balance:C}");
            }

            public void Withdraw(double amount)
            {
                if (amount > Balance)
                {
                    Console.WriteLine("Insufficient balance.");
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawal successful. New balance: {Balance:C}");
                }
            }

            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Deposit amount must be positive.");
                }
                else
                {
                    Balance += amount;
                    Console.WriteLine($"Deposit successful. New balance: {Balance:C}");
                }
            }

            public void Check_And_Display_Balance()
            {
                Console.WriteLine($"Current balance: {Balance:C}");
            }
        }
    }




}