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
        int pow10 = GetMagnitude(x) - 1; //how big is our number
        while (x > 0)
        {
            double mag = Math.Pow(10, pow10);
            int leftDig = (int)(x / mag); //find the first digit of x
            int rightDig = (int)(x % 10); //find the las digit of x
            if (leftDig != rightDig)
                return false;
            pow10 = pow10 - 2; //looked at the largest and smallest digits
            x = (int)((x - leftDig * mag) / 10); //remove the largest and smallest digits
        }
        return true;
    }
}

//I didn't bother with the string method
//GetMagnitude is borrowed
//Getting the left digit was really easy conceptually but there isn't a built-in method to get the scientific notation of a number or its magnitude in C#
//Getting the right digit tripped me up because i tried to % it by a different number but I just needed 10
//Fun!!!
