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
            Console.WriteLine("5 . History");
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
                    Console.WriteLine("1. App Details");
                    Console.WriteLine("2. User Details");
                    Console.WriteLine("Enter your key details : ");
                    Console.Write("Enter a key : ");
                    c = Console.ReadLine();

                    if (c == "1")
                    {
                        Console.Clear();

                        Console.WriteLine("A money management app");
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

                case "5":
                    History();
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

    static void History()
    {
        Console.Clear();
        Console.WriteLine("::History Menu::");
        Console.WriteLine("1. Transfer History");
        Console.WriteLine("2. Deposite History");

        string a = Console.ReadLine();

        if (a == "1")
        {
            Console.WriteLine("Almost $125000 Transfred");
            Console.ReadKey();
        }
        else if (a == "2")
        {
            Console.WriteLine("Almost $15246 deposited");
        }
        else
        {
            Console.WriteLine("Wrong Key");
        }
    }
}
