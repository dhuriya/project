//Function in Javascript
//Functions in JavaScript are reusable blocks of code designed to perform specific tasks. 
function welcomeMsg(name){
    return ('Hello ' +name+ ' welcome to my tutorial');
}
console.log(welcomeMsg('Deepu'));
console.log('\n----------------------------------------');
console.log('*********** Arrow Functions *********');
console.log('------------------------------------------')
//An arrow function is a shorter syntax for writing functions in JavaScript.
// 1 Arrow function without Parameters
console.log("\n1 Arrow function without Parameters");
const gfg = () => {
    console.log('Hello Deepu ---');
}
gfg();
//2 Arrow function with single parameters
console.log("\n2 Arrow function with single parameters");
const square = x => x*x;
console.log(square(4));
//3 Arrow function with multiple parameters
console.log("\n3 Arrow function with multiple parameters");
const sum = (x,y,z) => {
    console.log(x+y+z);
}
console.log(sum(10,20,30));
//4 Arrow function with defalut parameters
console.log('\n4 Arrow function with default parameters');
const defalutFun = (x,y,z=30) => {
    console.log(x+" " + y + " " +z);
}
console.log(defalutFun(10,20)) ;
// 5 Return Objects Literals
console.log('\n5 Return Objects Literals');
const makePerson = (firstName, lastName) =>
    ({first: firstName, last: lastName});
    console.log(makePerson("Pankaj", "Bind"));
//Immediately Invoked Function Expressions (IIFE) Examples
//Immediately Invoked Function Expressions (IIFE) are JavaScript functions that are executed immediately after they are defined.
console.log('\n----------------------------------------');
console.log('*** Immediately Invoked Function Expressions (IIFE) Examples***');
console.log('------------------------------------------')
// Basic
// (function() {
//     // IIFE code block
//     var localVar = 'This is a local variable';
//     console.log(localVar); // Output: This is a local variable
// })();

var result = (function() {
    var x = 10;
    var y = 20;
    return x + y;
})();
 
console.log(result); // Output: 30

var counter = (function() {
    var count = 0;
 
    return {
        increment: function() {
            count++;
        },
        decrement: function() {
            count--;
        },
        getCount: function() {
            return count;
        }
    };
})();
 
// Increment the counter
counter.increment();
counter.increment();
counter.increment();
 
console.log(counter.getCount()); // Output: 3
 
// Trying to access the private count variable directly
console.log(counter.count); // Output: undefined (cannot access private variable)

console.log('\n----------------------------------------');
console.log('*** Callback Function ***');
console.log('------------------------------------------')
//Call Function
//A callback function is a function that is passed as an argument to another function and executed later.

//A function can accept another function as a parameter.
//Callbacks allow one function to call another at a later time.
//A callback function can execute after another function has finished.

function greet(name,callback){
    console.log("hello " + name);
    callback();
}
function sayBye(){
    console.log('Goodbye!');
}
greet('Deepu',sayBye);
console.log("\nCallbacks for Asynchronous Execution");
console.log('Start');
    setTimeout(function () {
        console.log('Inside Timeout');
    },2000);
    console.log('End');