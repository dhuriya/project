const checkBoxList = document.querySelectorAll('.custom-checkbox');
const inputField = document.querySelectorAll('.goal-input');
const errorLabel = document.querySelectorAll('.error-label');
const progressBar = document.querySelector('.progress-bar');
const progressLevel = document.querySelector('.progress-label');
const progressValue = document.querySelector('.progress-value');
const allQuotes = [
    'Raise the bar by comleting your goals!',
    'Well begun is half done!',
    'Just a step away keep going!',
    'Whoa! You just completed all the goals, time for chill :D'
];



const allGoals = JSON.parse(localStorage.getItem('allGoals')) || {
    first: {
        name: '',
        completed: false
    },
    second: {
        name: '',
        completed: false
    },
    third: {
        name: '',
        completed: false
    }
};
let completedGoalsCoount = Object.values(allGoals).filter((goal) => goal.completed).length;
progressLevel.innerText = allQuotes[completedGoalsCoount];
progressValue.style.width = `${completedGoalsCoount / 3 * 100}%`;
progressValue.firstElementChild.innerText = `${completedGoalsCoount}/3 completed`;
checkBoxList.forEach((checkbox) => {
    checkbox.addEventListener('click', (e) => {
        const allGoalsAdded =[...inputField].every(function(params) {
            return params.value;
        })

        if(allGoalsAdded){
            checkbox.parentElement.classList.toggle('completed');            
            const inputId = checkbox.nextElementSibling.id;
            allGoals[inputId].completed = !allGoals[inputId].completed;
            completedGoalsCoount = Object.values(allGoals).filter((goal) => goal.completed).length;
            progressValue.style.width = `${completedGoalsCoount / 3 * 100}%`;
            progressValue.firstElementChild.innerText = `${completedGoalsCoount}/3 completed`;
            progressLevel.innerText = allQuotes[completedGoalsCoount];
            //console.log(inputId);
            //console.log(allGoals);
            localStorage.setItem('allGoals' , JSON.stringify(allGoals));
        }else {
           progressBar.classList.add('show-error');
        }        
    });
});

inputField.forEach((input) => {

    //console.log(allGoals[input.id]);
    input.value = allGoals[input.id].name;

    if(allGoals[input.id].completed){
        input.parentElement.classList.add('completed');
    }

    input.addEventListener('focus', () => {
        progressBar.classList.remove('show-error');
    });
    input.addEventListener('input', (e) => {

        if(allGoals[input.id].completed){
            input.value = allGoals[input.id].name;
            return;
        }

        // allGoals[input.id] ={
        //     name:  input.value,
        //     completed: false
        // };
        allGoals[input.id].name = input.value;
        //console.log(e.target.id);
        //console.log(allGoals);
        localStorage.setItem('allGoals' , JSON.stringify(allGoals));
    })
});