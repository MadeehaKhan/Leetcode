//link: https://leetcode.com/problems/roman-to-integer/

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        int sum = 0;
        int letter = 0;
        while (letter < s.Length)
        {
            //when i see a letter, i want to see if the next roman is bigger
            //if so, we have to look at the two romans to find the value and increment accordingly
            if (letter < s.Length - 1 && map[s[letter]] < map[s[letter + 1]])
            {
                int val = map[s[letter + 1]] - map[s[letter]];
                sum += val;
                letter++;
            }
            else
            {
                sum += map[s[letter]];
            }
            letter++;
        }
        return sum;
    }
}

//a lot of people in the solutions did a thing in the dictionary that looked
