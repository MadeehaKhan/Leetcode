//https://leetcode.com/problems/sum-root-to-leaf-numbers/

/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */
var sumNumbers = function(root) {

    const dfs = (node, sum) => {
        if (node == null) return 0;
        //adding the next node mathematically
        sum = sum*10 + node.val;

        if (!node.left && !node.right) return sum; //reached all leaf nodes

        return dfs(node.left, sum) + dfs(node.right, sum) //run dfs on the left and right of the root and return sum

    }

    return dfs(root, 0);
    
};