// JavaScript setTimeout() & setInterval() Method
//JavaScript SetTimeout and SetInterval are the only native function in JavaScript that is used to run code asynchronously, it means allowing the function to be executed immediately, there is no need to wait for the current execution completion, it will be for further execution.

// setTimeout() method
// the setTimeout() method executes a function,after waiting a specified number of milliseconds
setTimeout(gfg1,2000);
function gfg1(){
    console.log('gfg1');
}
// setInterval() method
// The setInterval() method repeats a given function at every given time interval
function gfg(){
    console.log('gggg');
}
setInterval(gfg,1000);