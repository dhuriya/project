// Higher order Functions
// A higher order function is a function tha does one of the following:
// # Takes another function as an argument.
// # Returns anoather function as its result.

function fun(){
    console.log('hello');
}
function fun2(action){
    action();
    action();
}
fun2(fun);

// Popular Higher Order Functions in Javascript
// 1 map
// the map function is used to transform an array by applying a callback function to each element it returns a new array.
const n = [1,2,3,4,5];
const square = n.map((num) => num * num);
console.log(square);

// 2 filter
// the filter function is used to create a new array containing elements that satisfy a  given condition.
const even = n.filter((num) => num % 2 == 0);
console.log(even);

// 3 reduce
// the reduce function accumulates array elements into a single value based on a callback function.
const sum = n.reduce((acc,curr) => acc + curr,0);
console.log(sum);

// 4 forEach
n.forEach((num) => console.log(num * 2));

// 5 find 
// the find function returns the first element in the array that satisfies a given condition.
const fEven = n.find((num) => num % 2 === 0);
console.log(fEven);

// 6 some
// The some function checks if at least one array element satisfies a condition.
const hasNeg = n.some((num) => num < 0);
console.log(hasNeg);

// 7 every
// The every function checks if all array elements satisfy a condition
const allPos = n.every((num) => num>0);
console.log(allPos);

// Advanced Techniques with higher oredr function

// 1 function compositions
// function composition is the process of combining multiple functions to create a new function. the composed function applies multiple operations in sequence.
function add(x){
    return x + 2;
}
function mul(x){
    return x * 3;
}
function compose(f,g){
    return function(x){
        return f(g(x));
    }
}
var res = compose(add,mul)(4);
console.log(res);

//  2 Currying
// Currying transforms a function that takes multiple arguments into a series of functions that each take  one argument. This allows partial application of the function.
function mulf(x){
    return function(y){
        return x * y;
    }
}
var muls = mulf(2);
console.log(mulf(5));

// 3 Memoization
// Memoization is a technique where function results are cached so that repeated calls with the same arguments return faster. this is particularly useful for expensive function calls.
function memoize(func){
    var cahce = {};
    return function(arg){
        if(cahce[arg]){
            return cahce[arg];
        }else{
            var res = func(arg);
            cahce[arg] = res;
            return res;
        }
    };
}
function slow(num){
    console.log("computing....");
    return num*2;
}
var fast = memoize(slow);
console.log(fast(5));
console.log(fast(5));

// use case's of higher order functions
// 1 passing functions as Arguments
function greet(name,callback){
    console.log(name);
    callback();
}
function sayGoodbye(){
    console.log('goddbye');
}
greet('dd',sayGoodbye);

// 2 Returning functions from function
function mmm(factor){
    return function(num){
        return num * factor;
    };
}

const mu = mmm(2);
console.log(mu(5));