// JavaScipt LocalStorage
//JavaScript localStorage is a feature that lets you store data in your browser using key-value pairs. The data stays saved even after you close the browser, so it can be used again when you open it later. This helps keep track of things like user preferences or state across different sessions.

// Saving data as key/value pair
localStorage.setItem("name","Deepu Dhuriya");
localStorage.setItem("color","green");
//updataing data
localStorage.setItem("name","Ram Dhuriya");
localStorage.setItem("color","blue");

// get the  data by key
let name = localStorage.getItem('name');
console.log("This is : ",name);
let color = localStorage.getItem('color');
console.log("Value of color is : ",color);

let Key1 = localStorage.key(1);
let items = localStorage.length;
console.log("total number of items is ", items);
localStorage.removeItem('color');
items = localStorage.length;

console.log('After removal,total number of items is ', items);
//localStorage.clear();
console.log("after clearing all items, total items:" ,localStorage.length);

// Storing and Retrieving an Object
let user = {
    naem: 'Deepu',
    age: 30
};
localStorage.setItem('user', JSON.stringify(user));

// Retrieve and parse the object
let stosedUser= JSON.parse(localStorage.getItem('user'));
console.log(stosedUser.naem);
console.log(stosedUser.age);


