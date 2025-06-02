class Circle{
    #radius; // private fields
    constructor(value){
        this.#radius = value; // calling setter
    }
    get area(){
        return Math.PI * Math.pow(this.#radius,2);
    }
    set radius(value){
        if(typeof value === 'number' && value > 0){
            this.#radius = value;
        }else{
            throw 'the radius must be a positive number';
        }
    }
    get radius (){
        return this.#radius;
    }
}
let circle = new Circle(10);
console.log(circle.area);
//console.log(circle.#radius);
console.log(circle.radius);