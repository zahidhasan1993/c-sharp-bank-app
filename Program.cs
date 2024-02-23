class Bank
{
    static void Main()
    {
        string userName = null,
            passWord = null;
        Console.WriteLine("***************Zahid Bank***************");
        Console.WriteLine("::LOGIN PAGE::");

        // taking input from user
        Console.Write("User Name : ");
        userName = Console.ReadLine();

        if (userName != "")
        {
            Console.Write("Password : ");
            passWord = Console.ReadLine();
        }

        if (userName == "zahid" && passWord == "123456")
        {
            Console.WriteLine("Successfully Login!!");
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
