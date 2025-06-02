console.log("*******************************************************");
console.log('***** Browser Object Model (BOM)******');
console.log("*******************************************************");
console.log("\n**** 1 Window Object ******\n");
window.addEventListener("click", myFunction);
function myFunction(){
    document.getElementById("demo").innerHTML = 'Hello World';
}
// The atob() method decodes base-64;
let text = "Hello World!";
let encoded = window.btoa(text);
let decoded = window.atob(encoded);

document.getElementById("demo").innerHTML = "Encoded: " + encoded + "<br>" + "Decoded: " + decoded;
console.dir(document);