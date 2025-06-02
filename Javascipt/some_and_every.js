// every() method
// The Array.every() method in javascript is used to check whether all the elements of the array satisfy the given condition or not. the output will be false if even one value does not satisfy the element, else if will return true.


// some() method

// The array.somoe() method in javascript is used to check wheter at least one of the elements of the array satisfies  the given condition or not.and it accepts true/false boolean expression, the only difference is that the some() method will return ture if any predicate is ture while every method will return ture if all predicates are true.

function isodd(element,index,array){
    return (element % 2 == 1);
}
function geeks(){
    let arr = [6, 1, 8, 32, 35];
    // check for odd number
    let value = arr.every(isodd);
    let value2 = arr.some(isodd);
    console.log(value);
    console.log(value2);
}
geeks();

// argument key
function add(){
    let sum=0;
    for(let i = 0;i<arguments.length;i++){
        sum +=arguments[i];
    }
    return sum;
}
console.log(add(1,2,3,4,5,6));
console.log("******************************************");
console.log("es6 rest parameter");
console.log("******************************************\n");

// es6 rest parameter
function fun(...input) {
    let sum = 0;
    for (let i of input) {
        sum += i;
    }
    return sum;
}
console.log(fun(1, 2)); //3
console.log(fun(1, 2, 3)); //6
console.log(fun(1, 2, 3, 4, 5)); //15  