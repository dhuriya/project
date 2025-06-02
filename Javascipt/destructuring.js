//Destructuring in JavaScript
//Destructuring Assignment is a JavaScript expression that allows to unpack of values from arrays, or properties from objects.
console.log("********************************************");
console.log("Array Destructuring");
console.log("********************************************");
const a = [10,20,30,40];
console.log("Example 1 ");
const [x,y,z,w]=a;
console.log(x);
console.log(y);
console.log(z);
console.log(w);

console.log("\nExample 2 ");
const [p,q, , r] = a;
console.log(p);
console.log(q);
console.log(r);
console.log("\nExample 3 ");
const [s, t] = a;
console.log(s);
console.log(t);
 console.log("\n******* Example with Rest Operator ********");
 let [fst, , ...last] = ["a", "b", "c", "d"];

console.log(fst);
console.log(last);

console.log("\n******* Example of Swapping ********");
let g = 10, h  = 20;
[g,h]=[h,g];
console.log(g);
console.log(h);

console.log("\n******* Example of Function Return ********");
function NameList(){
    return ['a','b','c','d']
}
let [frt,snd]=NameList();
console.log(frt);
console.log(snd);

console.log("********************************************");
console.log("Object Destructuring");
console.log("********************************************");
let marks = {x:21,y:-34,z:47};
const {j,k,l,n} = marks;
console.log(j);
console.log(k);
console.log(l);
console.log(n);
console.log("\n******* Simple Object destructuring ********");
// ({fg,gh}) = {ty:10,yu:20};
// console.log(fg);
// console.log(gh);

({xl, yl, ...restof} = {xl: 10, yl: 20, ml: 30, nl: 40});
console.log(xl); // 10
console.log(yl); // 20
console.log(restof); // {m: 30, n: 40}