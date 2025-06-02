// an array is an ordered list of values. Each value is called an element, and each element has a numeric position in the array.
console.log("\n1 Create Array using Literal");
let a = [];
console.log(a);
let b = [10,20,30];
console.log(b);
console.log('\n----2 Create using new keyword(Constructor)');
let c = new Array(13,20,30);
console.log(c);
console.log('\n-------------------------------------------------');
console.log('--- Basic Operation on JavaScript');
console.log('-------------------------------------------------');
console.log('1 Accessing Elements of an Array');
let d = ['HTML','CSS','JS'];
console.log(d[0]);
console.log(d[1]);
console.log('2 Accessing the Last of an Array');
let lst = d[d.length-1];
console.log('Last Item: ',lst);
console.log('3 Modifying the Array Elements');
d[1] = 'Boostrap';
console.log(d);
console.log('4 Adding Elements to Array ');
// add element to the end of Array
d.push('Node.js');
console.log(d);
// add Element to the beginnig
d.unshift('Web Development');
console.log(d);
console.log('5 Removing Elements from an Array ');
// Removes and returns the last element
console.log( d.pop());
console.log(d);
// Removes and retruns the first element
console.log(d.shift());
console.log(d);
// Removes 2 elements starting from index 1
console.log(d.slice(1,2));
console.log('6 Iterating Through Array Elements ');
b.forEach(function myfunc(x){
    console.log(x);
})
console.log('7 Array Concatention ');
let concateArray = b.concat(d);
console.log('Concatenated Array: ',concateArray);
console.log('8 Conversion of an Array to string ');
console.log(b.toString());
console.log('9 Check the Type of an Arrays ');
console.log(typeof b);
console.log('\n----------------------------------------------------------');
console.log('---- Basic problems on Array in JavaScript ----');
console.log('----------------------------------------------------------');
console.log('====== Alternate elemetns of an Array =====');
//1 Iterative Approach
console.log('**********1 Iterative Approach*************');
function getAlternatesArr1(arr){
    let res = [];
    for(let i = 0; i< arr.length; i+=2){
        //console.log(arr[i])
        res.push(arr[i]);
    }
    return res;
}
const arr = [10,20,30,40,50];
console.log(getAlternatesArr1(arr));
// Recursive Approach
console.log('**********2 Recursive Approach *************');
function getAlternatesRes(arr, idx,res){
    if(idx<arr.length){
        res.push(arr[idx]);
        getAlternatesRes(arr,idx+2,res);
    }
}
function getAlternatesArr2(arr){
    let res = [];
    getAlternatesRes(arr,0,res);
    return res;
}
console.log(getAlternatesArr2(arr));

console.log('====== Linear Search =====');
function LinarSearch(arr,n,x){
    let result=0;
    let i;
    for(i = 0; i<n;i++){
        if(arr[i]==x){
            result=i;
            break;
        }else{
            result =-1;
        }
    }
    if(result==-1){
        console.log('element is not present in Array ');
    }else{
        console.log('element is present at index ',i);
    }
}
LinarSearch(arr,arr.length,20);

console.log('====== Largest element in an Array =====');
console.log('**********1 Iterative Approach *************');
function largestEl(arr){
    let max = arr[0];
    for(let i =0;i<arr.length;i++){
        if(arr[i]>max){
            max = arr[i];
        }
    }
    console.log("Largest element is : ",max);
}
const arr2 = [10,324,45,90,9808];
largestEl(arr2);