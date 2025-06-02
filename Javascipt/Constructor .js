// A constructor in JavaScript is a special function used to create and initialize objects. It sets up object properties and is typically invoked using the new keyword.
//In JavaScript, constructors can be defined in two main ways

 // 1 Function Constructor Method
 function Car(make,model,year){
    this.make = make;
    this.model = model;
    this.year = year;
    this.getCarInfo = function(){
        return `${this.year} ${this.make} ${this.model}`;
    }
 }
 console.log('********* // 1 Function Constructor Method ********');
 const myCar = new Car('Toyato','Camry',2023);
 console.log(myCar.getCarInfo());

 // 2 Class Construtor Method
 class Cardetails {
    constructor(make,model,year) {
        this.make = make;
        this.model = model;
        this.year = year
    }
    getCarInfo(){
        return `${this.year} ${this.make} ${this.model}`;
    }
 }
 console.log('********* // 2 Class Construtor Method ********');
 let myCar2 = new Cardetails('HOnda','Civic',2022);
 console.log(myCar2.getCarInfo());

 // new keyword in JavaScript
 console.log('\n*********** new keyword in JavaScript**********')
 function prints(name,age){
    this.name = name
    this.age = age
 }
 const result = new prints('Deepu',25);
 console.log(result);
 // object from a class
 class Person {
    constructor (name,age){
        this.name = name
        this.age = age
    }
 }
 const result1 = new Person('Ankit',26);
 console.log(result1);

 // Object.create() function in JavaScript
 console.log('\n**********// Object.create() function in JavaScript **********');
 const obj = {
    name: 'Aditya',
    age: 22
 }
 const obj1 = Object.create(obj);
 obj1.class = '10th';
 console.log(obj1.name);

 // Object Factory Functions
 //A factory function is a regular function that returns a new object, making it a simple and reusable way to create multiple instances without using new.
 console.log('\n************ Object Factory Functions ************');
 function createPerson(name,age){
    return {
        name: name,
        age: age,
        greet: function(){
            console.log(`Hello, my name is ${this.name}`);
        }
    };
 }
 const person1 = createPerson('Himanshu',24);
 const person2 = createPerson('Vikash',23);
 person1.greet();
 person2.greet();
 // Constructor with method on prototypes
 console.log('\n************ Constructor with method on prototypes **********');
 function PersonF(name,age){
    this.name = name;
    this.age;
 }
 PersonF.prototype.geet = function (){
    console.log(`Hello my name is ${this.name} and I am ${this.age} Years old.`);
 }
 const person3 = new PersonF('ddddd',30);
 const person4 = new PersonF('Amar',35);
 person3.geet();
 person4.geet();

 //Constructor with inheritance
 console.log('\n************** Constructor with inheritance ***********');
 class one{
    constructor(name)
    {
        this.name = name
    }
    greet()
    {
        return `Hello ${this.name}`
    }
 }
 class two extends one {
    constructor(name,age)
    {
        super(name)
        this.age = age
    }
    greet1(){
        return `Your age is ${this.age}`
    }
 }
 const person5 = new one('Pranjal');
 const person6 = new two('Pranav',21);
 console.log(person6.greet());