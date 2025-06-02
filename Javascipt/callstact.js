// Call Stack
// The call stack is a crucail concept in javascript's runtime environement, representing the mechanism by which the javascript engine keeps track of function calls in program. it operates as a Last in, First Out(LIFO) data structure.
function f1(){
    console.log("Hi by f1!");
}
function f2(){
    f1();
    console.log('HI by f2!');
}
f2();
// Step 1 when the code loads in memory, the global execution context gets pushed in the stack.
// step 2 the f2() get called, and the exection context of f2() gets pushed into the stack.

// stepd 3 the execution of f2() starts and during its execution, the f1() funciton gets called inside the f2() function. this causes the execution context of f1() to get pushed in the call stack.

// step 4 now the f1() function starts executing . A new stack frame of the console.log() method will be pushed to the stack.
// step 5 when the console.log() method runs, it will print, "HI by f1" and the it will be popped from the stack. the execution context will go back to the function and how there are no lines of code that remain in the f1() function,and a result it will be popped from the call stack.

// step 6 this will similary happen with the console.log() method that prints the line "hi by f2" and the finally the function f2() would finish and would be pushed off the stack.