//link: https://leetcode.com/problems/palindrome-number/

public class Solution
{
    public static int GetMagnitude(int num)
    {
        int magnitude = 0;
        while (num > 0)
        {
            magnitude++;
            num = num / 10;
        }
        return magnitude;
    }

    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        int pow10 = GetMagnitude(x) - 1;
        while (x > 0)
        {
            double mag = Math.Pow(10, pow10);
            int leftDig = (int)(x / mag);
            int rightDig = (int)(x % 10);
            if (!(leftDig == rightDig))
                return false;
            pow10 = pow10 - 2;
            x = (int)((x - leftDig * mag) / 10);
        }
        return true;
    }
}
