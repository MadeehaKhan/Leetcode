//https://leetcode.com/problems/zigzag-conversion/

/**
 * @param {string} s
 * @param {number} numRows
 * @return {string}
 */
var convert = function(s, numRows) {
    
    if (numRows == 1 || s.length < numRows) return s;

    let rowTrack = 0; //sets vertical index of letter
    let dir = false; //are we adding to the vertical index or decreasing it

    let res = Array(numRows).fill("");

    for(let i = 0; i < s.length; i++) {
        let letter = s[i]; 
        res[rowTrack] += letter;
        if(rowTrack == 0 || rowTrack >= numRows-1) dir = !dir //reached top/bottom of zigzag, need to go the other way
        dir ? rowTrack++ : rowTrack--; //puts the next letter in the right spot
    }

    return res.join("");
};