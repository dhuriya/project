//Simulating a click in JavaScript means triggering a click event on an HTML element using code, rather than requiring manual user interaction. This technique is useful for automating actions like clicking buttons, links, or other interactive elements, enhancing web functionality, and triggering hidden or background processes.


const addCardBtn = document.querySelector('.card');
const container =  document.querySelector('.container');
let count = 2;
addCardBtn.addEventListener('click', () => {
    const newCard  = document.createElement('div');
    newCard.classList.add('card');
    newCard.innerText = count++;
    container.append(newCard);
});

const intervalId = setInterval(() => {
    if(count > 3){
        clearInterval(intervalId);
    }
    addCardBtn.click();
},1000);