//https://leetcode.com/problems/longest-repeating-character-replacement/

/**
 * @param {string} s
 * @param {number} k
 * @return {number}
 */
var characterReplacement = function(s, k) {

    let count = {}; //keep the frequency of chars in window
    let left = 0;
    let maxFreq = 0; //keep track of replacement candidate    
    let longest = 0;

    for (let right = 0; right < s.length; right++) {
        let letter = s[right];
        if (!count[letter]) {
            count[letter] = 0;
        } 
        count[letter] ++;

        maxFreq = Math.max(maxFreq, count[letter]);

        //windowSize - maxFreq <= k is the limit
        if (right - left+1 - maxFreq > k) {
            count[s[left]]--;
            left++;
        }

        longest = Math.max(longest, right-left+1);
    }

    return longest;
    
};