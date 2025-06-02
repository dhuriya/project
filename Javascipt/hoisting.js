// JavaScript Hoisting
// Hoisting refers to the behaviour where javascript moves the declarations of variables, function and classes to the top of their scope during the compilatioin phase.
//* Hoisting applies  to variables and function declarations.
// * Initializations are not hoisted, they are only declarations.
// * var variables are hoisted with undefined, while let and const are hoisted but remain in the Temporal Dead Zone until initialized.

// Temporal Dead Zone(TDZ)
// The Temporal Dead Zone is a critical concept in javascript hoistig, it refers to the period between the entering of a scope(such as a function or block) and the actual initialization of a variable declared with let or const.

// 1 Variable Hoisting with var
console.log(a); // undefined
var a =5;
// 2 Variable Hoisting with let and const
console.log(b)// cannot access before initialization
let b = 10;
//3 function declaration hoisting
greet();// Hello world
function greet(){
    console.log("Hello, world");
}
//  4 function Expression hoisting
hello();
var h = function(){
    console.log('hi');
}
// 5 Hoisting with let and const in function
function test(){
    console.log(x); // cannot access before initialization
    let x =50;
}
// 6 Hoisting with classes
const obj = new MyClass();
class MyClass{
    constructor(){
        this.name = 'hhhh';
    }
}
// 7 re-declaring variables with var
var a = 10;
var a = 20;
console.log(a);
// 8 Accessing variables declared later in loops
for(var i = 0; i< 3 ;i++){
    setTimeout(function (){
        console.log(i);
    },100);
}
// 9 using Hoisted functions with parameters
test(10);
function test(num){
    console.log(num);
}
// 10 hoisting in Nested functions
function outer(){
    console.log(a);
    var a =5;
    function inner(){
        console.log(b);
        var b =10;
    }
    inner();
}
outer();