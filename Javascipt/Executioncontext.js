//Execution Context:
// Everything in javascript is wrapped inside execution context, which is an abstract concept that holds the whole information about the environment within which the currant javascript code is being executed.

// Execution context has two components and javascript code gets executed in two phases:
// *1 Memory Allocation Phose:in this all the funciton and variables of the javasctipt code get stored as a key value pair inside memory component of the execution context.in the case of a function javascript copied the whole function into the memory block but in the case of variables, it assigns undefined as a placeholder.

//*2 Code Execution Phase: in this phase,the javascript code is executed one line at a time inside the code component of execution context.
var number = 2;
function Square(n){
    var res = n * n;
    return resl;
}
var newNumber = Square(3);