for (int h = 0; h <= 23; h++)
{
    for (int m = 0; m <= 59; m++)
    {
        for (int s = 0; s <= 59; s++)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write($"{h}:{m}:{s}");
            System.Threading.Thread.Sleep(1000);
        }
    }
}