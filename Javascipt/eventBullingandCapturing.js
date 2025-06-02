//Event Bubbling in JavaScript
// Event bulling in Javascrip is a mechanism where an event triggered on  a child element propagates upward through its ancestors in the DOM. it allows parent elements to respond to events triggered by their child elements.


//How to Stop Event Bubbling?
// to stop event bubbling, you can use the event e.stopPropagation() method in the event handler. this prevents the event from propagation to parent elements, so only the target element's event listener is trigged.
// document.querySelector('.green').addEventListener('click', (e) => {
//     e.stopPropagation();
//     console.log("Green box Event listner");
// });
// document.querySelector('.pink').addEventListener('click', (e) => {
//     e.stopPropagation();
//     console.log("Pink box Event listner");
// });
// document.querySelector('.blue').addEventListener('click', (e) => {
//     e.stopPropagation();
//     console.log("Blue box Event listner");
// });
// document.addEventListener('click', (e) => {
//     e.stopPropagation();
//     console.log("Document Event listner");
// });
// document.body.addEventListener('click', (e) => {
//     e.stopPropagation();
//     console.log("Body Event listner");
// });
// window.addEventListener('click', (e) => {
//     e.stopPropagation();
//     console.log("Window Event listner");
// });
//Event Capturing in JavaScript
//The event starts at the root of the DOM and propagates downward to the target element.
document.querySelector('.green').addEventListener('click', (e) => {
    //e.stopPropagation();
    console.log("Green box Event listner");
},true);//{capture:true, once:true}
document.querySelector('.pink').addEventListener('click', (e) => {
    //e.stopPropagation();
    console.log("Pink box Event listner");
},true);//{capture:true, once:true}
document.querySelector('.blue').addEventListener('click', (e) => {
    //e.stopPropagation();
    console.log("Blue box Event listner");
},true);//{capture:true, once:true}
document.addEventListener('click', (e) => {
    //e.stopPropagation();
    console.log("Document Event listner");
},true);//{capture:true, once:true}
document.body.addEventListener('click', (e) => {
    //e.stopPropagation();
    console.log("Body Event listner");
},true);//{capture:true, once:true}
window.addEventListener('click', (e) => {
    //e.stopPropagation();
    console.log("Window Event listner");
},true);