//Event Delegation in JavaScript
//Event Delegation is basically a pattern to handle events efficiently. Instead of adding an event listener to each and every similar element, we can add an event listener to a parent element and call an event on a particular target using the .target property of the event object.
const addCardBtn = document.querySelector('.card');
const container =  document.querySelector('.container');
let count = 1;
addCardBtn.addEventListener('click', () => {
    const newCard  = document.createElement('div');
    newCard.classList.add('card');
    newCard.innerText = count++;
    container.append(newCard);
});

const intervalId = setInterval(() => {
    if(count > 4){
        clearInterval(intervalId);
    }
    addCardBtn.click();
},1);

container.addEventListener('click' ,(e) => {
    if(e.target !== container){
        e.target.remove();
    }
});