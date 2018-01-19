var date = new Date ();
    document.body.innerHTML= "<h1>Today Date is " + (date.getMonth()+1) + "/" + date.getDate() + "/" + date.getFullYear() + "</h1>";
    
    
var negInteger = -3.14159265359;
var escQuote = "Quotes can also be \"escaped\".";
var theSunIsWarm = true;
var emptyInside = null;
var justAnotherVariable;

// Try this in your console:
// console.log(typeof insertVariableName);

var a = 5;
var b = 5;
var theNumbersMatch

if ( a == b ) {
    theNumbersMatch = true;
} else {
    theNumbersMatch = false;
}

console.log("The Numbers Match: " +theNumbersMatch);


pens = ["red", "blue", "green", "orange"];

console.log("Before: ", pens);

// PROPERTIES:
// Get a property of an object by name:
// console.log("Array length: ", pens.length);

// METHODS:
// Reverse the array:
// pens.reverse();

// Remove the first value of the array:
// pens.shift();

// Add comma-separated list of values to the front of the array:
// pens.unshift("purple", "black");

// Remove the last value of the array:
// pens.pop();

// Add comma-separated list of values to the end of the array:
// pens.push("pink", "prussian blue");

// Find the specified position (pos) and remove n number of items from the array. Arguments: pens.splice(pos,n):
// pens.splice(pos e.g. position 3 from position 0, n e.g. 2) // Starts at the seccond item and removes two items.

// console.log("After: ", pens);

// Create a copy of an array. Typically assigned to a new variable:
// var newPens = pens.slice();
// console.log("New pens: ", newPens);

// Return the first element that matches the search parameter after the specified index position. Defaults to index position 0. Arguments: pens.indexOf(search, index):
// var result = pens.indexOf(search, index);
// console.log("The search result index is: ", result);

// Return the items in an array as a comma separated string. The separator argument can be used to change the comma to something else. Arguments: pens.join(separator):
// var arrayString = pens.join("|");
// console.log("String from array: ", arrayString);

// MDN documentation for Array:
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array


function findBiggestFraction (a,b){
    var result;
    a>b ? result = ["firstFraction", a] : result = ["secondFraction", b];
    return result;
}
 
var firstFraction = 3/4;
var secondFraction = 5/7;
var fractionResult = findBiggestFraction(firstFraction, secondFraction);

console.log ("First Fraction: ", firstFraction);
console.log ("Second Fraction: ", secondFraction);

console.log("The fraction named " + fractionResult[0]+ " with a value of " + fractionResult[1] + ", is the biggest!");

findBiggestFraction (2.4/434, 4343/535243);


/*var c = 5/7;
var d = 4/5;*/

var theBiggestNumber = function (c,d){
    var result;
    a>b ? result = ["firstFraction", c] : result = ["secondFraction", d];
   // console.log(result);
    return result;
}

//theBiggestNumber();
console.log(theBiggestNumber(4543/346453546, 545645/574554));