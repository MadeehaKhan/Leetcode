//https://leetcode.com/problems/validate-binary-search-tree/

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
 * @return {boolean}
 */
var isValidBST = function(root) {
    return checkValidBST(root, null, null);

};

const checkValidBST = (root, min, max) => {
    if (root == null) {
        return true;
    }
    //we use the definition of a bst to check -- 
    //1) is the max value strictly decreasing on the left, is the min value strictly increasing on the right
    if ((max != null && root.val >= max) || (min != null && root.val <= min)) return false;
    //2) are the left and right subtrees also bsts
    if (!checkValidBST(root.left, min, root.val) || !checkValidBST(root.right, root.val, max)) return false;

    return true;
}