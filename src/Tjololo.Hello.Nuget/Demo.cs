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

    /// <summary>
    /// GetSmallestNumber - Returns the smallest number from the given list of numbers.
    /// </summary>
    /// <param name="numbers">The list of numbers</param>
    /// <returns>The smallest number.</returns>
    public int GetSmallestNumber(int[] numbers)
    {
        int smallestNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallestNumber)
            {
                smallestNumber = numbers[i];
            }
        }
        return smallestNumber;
    }
}
