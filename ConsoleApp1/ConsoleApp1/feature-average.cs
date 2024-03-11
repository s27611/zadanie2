namespace ConsoleApp1;

public class FeatureAverage
{
    public static int Feature_Average(int[] tab)
    {
        int sum=0;
        foreach (int VARIABLE in tab)
        {
            sum = sum + VARIABLE;
        }

        int avg = sum / tab.Length;

        return avg;
    }
}