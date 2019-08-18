using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        try
        {
            Box box = new Box(length, width, height);
            Console.WriteLine("Surface Area - {0:F2}", box.GetSurfaceArea());
            Console.WriteLine("Lateral Surface Area - {0:F2}", box.GetLateralSurfaceArea());
            Console.WriteLine("Volume - {0:F2}", box.GetVolume());
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

        
    }
}