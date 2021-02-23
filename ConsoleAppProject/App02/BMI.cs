namespace ConsoleAppProject.App02
{
    /// <summary>
    /// To allow the user to check their overall health by BMI
    /// </summary>
    /// <author>
    /// Hassan Nisar version 0.1
    /// </author>
    public class BMI
    {
    }

    private void OutputHeading()
    {
        Console.WriteLine();
        Console.WriteLine(" -------------------------");
        Console.WriteLine("   Body Mass Index Calculator      ");
        Console.WriteLine("    By Hassan Nisar       ");
        Console.WriteLine(" -------------------------");
    }

    public void Run()
    {
        fromUnit = SelectUnit(" Please select the from distance unit > ");
        toUnit = SelectUnit(" Please select  the to distance unit");

        OutputHeading();

        Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

        fromDistance = InputDistance($"Please enter the number of {fromUnit}  > ");

        CalculatetoDistance();

        OutputtoDistance();
    }
}
