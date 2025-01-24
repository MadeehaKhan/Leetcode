//link: https://leetcode.com/problems/integer-to-roman/description/

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
        return magnitude - 1;
    }

    public string IntToRoman(int num)
    {
        //num first digit != 4 or 9
        //find the biggest dictionary value to subtract and figure out the rest like normal
        //num first digit == 4 or 9
        //represent the number as the subtracted version (smaller roman before bigger)
        //check if the number is a power of 10
        int pow10 = GetMagnitude(num);
        //could use a stringbuilder
        var soln = new StringBuilder();

        void getThousands(int num)
        {
            if (pow10 == 3)
            {
                int firstDigit = (int)(num / Math.Pow(10, pow10));
                for (int i = 0; i < firstDigit; i++)
                {
                    soln.Append("M"); //add them to the list
                }
                num = num - (int)(firstDigit * Math.Pow(10, pow10));

                pow10 = GetMagnitude(num);
            }
            getHundreds(num);
        }

        void getHundreds(int num)
        {
            if (pow10 == 2)
            {
                int firstDigit = (int)(num / Math.Pow(10, pow10));
                //check for start with 4 or 9
                if (firstDigit == 4)
                {
                    soln.Append("CD");
                    num = num - 400;
                }
                if (firstDigit == 9)
                {
                    soln.Append("CM");
                    num = num - 900;
                }
                else
                {
                    if (firstDigit >= 5)
                    {
                        soln.Append("D");
                        num = num - 500;
                    }
                    while (num >= 100)
                    {
                        soln.Append("C");
                        num = num - 100;
                    }
                }
                pow10 = GetMagnitude(num);
            }
            getTens(num);
        }
        void getTens(int num)
        {
            if (pow10 == 1)
            {
                int firstDigit = (int)(num / Math.Pow(10, pow10));
                //check for start with 4 or 9
                if (firstDigit == 4)
                {
                    soln.Append("XL");
                    num = num - 40;
                }
                if (firstDigit == 9)
                {
                    soln.Append("XC");
                    num = num - 90;
                }
                else
                {
                    if (firstDigit >= 5)
                    {
                        soln.Append("L");
                        num = num - 50;
                    }
                    while (num >= 10)
                    {
                        soln.Append("X");
                        num = num - 10;
                    }
                }
                pow10 = GetMagnitude(num);
            }
            getOnes(num);
        }
        void getOnes(int num)
        {
            int firstDigit = (int)(num / Math.Pow(10, pow10));
            //check for start with 4 or 9
            if (firstDigit == 4)
            {
                soln.Append("IV");
                num = num - 4;
            }
            if (firstDigit == 9)
            {
                soln.Append("IX");
                num = num - 9;
            }
            else
            {
                if (firstDigit >= 5)
                {
                    soln.Append("V");
                    num = num - 5;
                }
                while (num > 0)
                {
                    soln.Append("I");
                    num = num - 1;
                }
            }
        }

        getThousands(num);
        return soln.ToString();
    }
}

//could probably simplify this code a lot since there is so much repitition
//solved this in a literally math-y way but there's a simpler looking recursive solution
