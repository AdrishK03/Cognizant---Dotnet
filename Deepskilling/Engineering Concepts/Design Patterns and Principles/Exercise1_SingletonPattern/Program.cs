class Program
{
    static void Main()
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("First Message");
        logger2.Log("Second Message");

        Console.WriteLine(
            ReferenceEquals(logger1, logger2)
                ? "Same Instance"
                : "Different Instance");
    }
}