
function inputParsing(input) {
    input = input.split("\n");
    var output = "";
    for (var i=1; i<=input[0]; i++) {
        output = output + uptopianTree(input[i]) + "\n";
    }
    return output;
}

//Bottom up
function uptopianTree(cycles) {
    var heights = [];
    heights.push(1);
    for (var i=1; i<=cycles; i++) {
        var currentHeights = 0;
        //Double height in spring
        if(i%2!==0) {
            currentHeights = heights[i-1]*2;
        }
        // increase by 1 in summer
        else {
            currentHeights = heights[i-1] + 1;
        }
        heights[i] = currentHeights;
    }
    return heights[heights.length-1];
}

//Test case 1
var input1 = `3
0
1
4`
//Test case 2
var input2 = `3
6
5
4`
console.log(inputParsing(input1));
console.log(inputParsing(input2));