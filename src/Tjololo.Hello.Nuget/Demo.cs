namespace Tjololo.Hello.Nuget;
public class Demo
{
    /// <summary>
    /// GetLargestNumber - Returns the largest number from the given list of numbers.
    /// </summary>
    /// <param name="numbers">The list of numbers.</param>
    /// <returns>The largest number.</returns>
    public int GetLargestNumber(int[] numbers)
    {
        int largestNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }
        return largestNumber;
    }

}
