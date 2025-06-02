
const user = {
    firstname: 'Deepu',
    lastname: 'Dhuriya',
    age: 26,
    getAgeYear : function(){
        return new Date().getFullYear() - user.age;
    }
}

function getAgeYear(age){
    return new Date().getFullYear() - age;
}
console.log(getAgeYear(2));
console.log(user);

console.log('Use by function')
function createUser(firstname,lastname,age){
    const user = {
        firstname,
        lastname,
        age,
        getAgeYear () {
            return new Date().getFullYear() - user.age;
        }
    }
    return user;
}
const user1 = createUser('Deepu','Dhuriya',26);
const user2 = createUser('Aditya','Rajput',24);
console.log(user1);
console.log(user2);