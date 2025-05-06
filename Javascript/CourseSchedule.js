//https://leetcode.com/problems/course-schedule/

/**
 * @param {number} numCourses
 * @param {number[][]} prerequisites
 * @return {boolean}
 */
var canFinish = function(numCourses, prerequisites) {
    let adjList = {}
    let visited = new Set();

    //let tuple of instead of let tuple in
    for(let [course, prereq] of prerequisites) {
        if (!adjList[course]) {
            adjList[course] = [prereq]; 
        }
        //first FAT mistake i made was putting .push[prereq] which was overriding the adjacency list
        else adjList[course].push(prereq);
    }

    //run dfs on the adjacency list
    const dfs = (course) => {
        //prerequisites = [[0,1],[1,0]]
        //say we start at node 1, we mark it as visited and then check its prereq
        //if we have already visited it in this path, we have a cycle
        if (visited.has(course)) return false;

        if (adjList[course] == []) return true;  //if there are no prereqs, we are good

        //need to check if we have an adjList
        if (adjList[course]){
            visited.add(course);

            //let p of instead of let p in
            for(let p of adjList[course]) {
                if (!dfs(p)) return false;
            }

            visited.delete(course);
            adjList[course] = []; //no rerunning on neighbours
        }

        return true;
    }

    for(let c in adjList) {
        if (!dfs(c)) return false;
    }

    return true;

};