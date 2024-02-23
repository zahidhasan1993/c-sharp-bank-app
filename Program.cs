class Bank
{
    static void Main()
    {
        string userName = null,
            passWord = null;
        Console.WriteLine("***************Zahid Bank***************");
        Console.WriteLine("::LOGIN PAGE::");

        // taking input from user
        Console.Write("Username : ");
        userName = Console.ReadLine();

        if (userName != "")
        {
            Console.Write("Password : ");
            passWord = Console.ReadLine();
        }

        if (userName == "zahid" && passWord == "123456")
        {
            Console.Clear();
            Console.WriteLine("::Select anu option from the menu key::");
            Console.WriteLine("1 . Balance");
            Console.WriteLine("2 . Withdraw");
            Console.WriteLine("3 . Cash In");
            Console.WriteLine("4 . Details");
            string a;
            Console.Write("Menu Key from upper list : ");
            a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.Write("1542222");
                    break;
                case "2":
                    Console.Write("52156");
                    break;
                case "3":
                    Console.Write("25000");
                    break;
                case "4":
                    string c;
                    Console.Clear();
                    Console.WriteLine("1. Transiction Details");
                    Console.WriteLine("2. User Details");

                    Console.WriteLine("Enter your key details : ");
                    c = Console.ReadLine();

                    if (c == "1")
                    {
                        Console.Clear();

                        Console.WriteLine("august 17, august 18");
                    }
                    else if (c == "2")
                    {
                        Console.Clear();

                        Console.WriteLine("Username : " + userName + " Password : " + passWord);
                    }
                    else
                    {
                        Console.WriteLine("key is not valid");
                    }
                    ;
                    break;

                default:
                    Console.Write("Not Applicable");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Wrond username or password");
        }

        Console.ReadKey();
        Console.WriteLine("Thank You!!!");
        Console.ReadKey();
    }
}
