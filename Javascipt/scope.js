// What is Lexical Scope?
// Lexical scope defines the accessiblity of variables and functions depending on their location in the source code.

// Global Scope : When a variable is defined outside of any functions or blocks, it has a global scope. it can be accessed from anywhere within the program, including within functions.
let nam = 'john'; // Global varibale
function sayHello(){
    console.log('hello' + nam);
}
// Local scope
// when a variable is defined within a function or block, it has a local scope. it can only be accessed within that fuction or block.
function f1(){
    let n = 'jjjj';// local variable
    console.log(n);
}
//Nested scope
// when a function is defined within another function it has access to variables defined in the parent function.
function outer(){
    let n = 'jjj'; // ouoter function variable
    function inner(){
        console.log(n);
    }
    inner(); 
}
// Block scope
function jjj(){
    if(true){
        let m = ';;;'; // block variable
        console.log(m);
    }
}