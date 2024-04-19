
// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using DataLayer;
using BusinessLogic;
using Model;
using UI;

public class Program
{
    static void Main(string[] args)
    {
        GroupInfo groupList = new GroupInfo();

        Console.WriteLine("Good Day Welcome to Magic Shop WikiGroup Information Site!");
        Console.WriteLine();
        Console.WriteLine("Enter Your Favorite Kpop Group: ");
        string Name = Console.ReadLine();

        Business ver = new Business();
        bool result = ver.VerifyGroup(Name);
       
        Console.WriteLine();
        Console.WriteLine("View a Kpop Group Profile Your Choice");
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Select a Kpop Group: ");
            Console.WriteLine();
            Console.WriteLine("1. BTS");
            Console.WriteLine("2. TXT");
            Console.WriteLine("3. SEVENTEEN");
            Console.WriteLine("4. TWICE");
            Console.WriteLine("5. BLACKPINK");
            Console.WriteLine("6. TREASURE");
            Console.WriteLine("7. ITZY");
            Console.WriteLine("8. ENYPHEN");
            Console.WriteLine("9. MAMAMOO");
            Console.WriteLine("10.LESSERAFIM");
            Console.WriteLine("11.ADD YOUR KPOP GROUP");
            Console.WriteLine();
            Console.WriteLine("Enter Your Choice Group: ");

            string choices = Console.ReadLine();
            Profile pro = new Profile();

            switch (choices)
            {
                case "1":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[0]);
                    return;
                case "2":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[1]);
                    break;
                case "3":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[2]);
                    return;
                case "4":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[3]);
                    break;
                case "5":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[4]);
                    return;
                case "6":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[5]);
                    break;
                case "7":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[6]);
                    return;
                case "8":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[7]);
                    break;
                case "9":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[8]);
                    return;
                case "10":
                    Console.WriteLine();
                    pro.DisplayGroup(groupList.groupList[9]);
                    break;
                case "11":
                    Group g = new Group();
                    Console.WriteLine("Input a KPOP Group Name: ");
                    g.Name = Console.ReadLine();
                    Console.WriteLine("Input a Members: ");
                    g.Members = Console.ReadLine();
                    Console.WriteLine("Input a Fandom Name: ");
                    g.FandomName = Console.ReadLine();
                    Console.WriteLine("Input a Group Debut Date:");
                    g.DebutDate = Console.ReadLine();
                    Console.WriteLine("Input a Group Company:");
                    g.Company = Console.ReadLine();
                    Console.WriteLine();
                    pro.DisplayGroup(g);

                    return;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}