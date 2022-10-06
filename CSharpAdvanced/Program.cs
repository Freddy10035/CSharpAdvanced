internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i%2 == 0)
            {
                Console.WriteLine(i);
            }
        }

       /* 
          var name = "Fredrick Ochieng0";
        foreach(var character in name)
        {
            Console.WriteLine(character);
        }
       */

        var random = new Random();
        var buffer = new char[10];

        for (var i = 0; i < 10; i++)
            //Console.WriteLine(random.Next());
            buffer[i] = (char)('a' + random.Next(0, 26));

        var password = new string(buffer);
            Console.WriteLine(password);
        
    }
}