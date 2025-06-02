//javaScript object seal() Method
// The seal method does not allowe adding new property to an object
// but it allow modify object exitsting property
// it does not allowe delete property to an object
console.log("\n------------------------------------");
console.log("javaScript object seal() Method");
console.log("------------------------------------");
const obj1 = {property1: 'initial data'};
const obj2 = Object.seal(obj1);
obj2.property1 = 'initial data2';
delete obj2.property1;
console.log(obj2);
//javaScript object freeze() Method
// the freeze method does not allowe adding new propeerty,delete or modify
console.log("\n------------------------------------");
console.log("javaScript object freeze() Method");
console.log("------------------------------------");
const obj3 = Object.freeze(obj1);
obj3.property2 = 'aaaaa';
obj3.property1 ='bbb';
delete obj3.property1;
console.log(obj3);
