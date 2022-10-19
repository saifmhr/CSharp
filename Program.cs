using System;
  class Program
    {
        static void Main()
        {
        Console.WriteLine("Main function");
        forloop();
        whileloop();
        }

    static void forloop()
    {
        Console.WriteLine("for Loop  ");
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("0 to 9 =" + i);
        }
    }

    static void whileloop()
    {
        Console.WriteLine("While loop");
        int j=0;
        while (j<5)
        {
            Console.WriteLine("while loop = " + j);
            j++;
        }
    }
    }
