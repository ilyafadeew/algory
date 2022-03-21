namespace ALGORY.Sort;

public class Recursion
{
    public static (int digit, int loopCount) Multiply(int digit, int loopCount =0)
    {
        loopCount++;

        if (digit * digit <= 0)
        {
            return (digit,loopCount);
        }

        digit = digit * digit;
        
        return Multiply(digit, loopCount);
    }
    
}