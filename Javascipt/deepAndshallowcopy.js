//Shallow Copy
//A shallow copy occurs when you copy the reference of an object to a new variable. In this process, only the top-level properties are copied, while nested objects or arrays still reference the original memory location. This means that if you change the nested properties in one object, those changes will reflect in the other because they share the same memory reference

console.log("\n---------------------------------------------");
console.log('******** Shallow Copy ***********');
console.log('---------------------------------------------')
let employee = {
    eid: 'E102',
    enam: 'Jack',
    eaddress:'  New York',
    salary: 50000
}
console.log("Employe => ",employee);
let newEmployee = employee; // Shallow copy
console.log("New Employe => ",newEmployee);
console.log("\n---------------- After modification ------------------");
newEmployee.enam = 'Beck';
console.log("Employe => " , employee);
console.log("New Employee => ",newEmployee);
console.log("\n---------------- Solve Shollow Copy ------------------");
const newEmployee2 = {...employee};
newEmployee2.enam='Deepu';
console.log("Employe => " , employee);
console.log("New Employee => ",newEmployee2);

console.log("\n---------------------------------------------");
console.log('******** Deep Copy ***********');
console.log('---------------------------------------------')
//A deep copy, on the other hand, creates a completely independent copy of the object, including all nested objects or arrays.
let employee2 = {
    eid:'E102',
    ename:'Rahul',
    eaddress:'Delhi',
    salary: 60000
}
let newEmployee3 = JSON.parse(JSON.stringify(employee2));
console.log("Employee => ",employee2);
console.log("New Employee => ",newEmployee3);
console.log("\n---------------- After modification ------------------");
newEmployee3.ename='Suraj';
newEmployee3.salary=800000;
console.log("Employee => ",employee2);
console.log("New Employee => ",newEmployee3);
