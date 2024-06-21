console.log("Hello, World!");

let name = "John";      // string
let age = 30;           // number
let isStudent = false;  // boolean
let car = null;         // null
let address;            // undefined
let uniqueID = Symbol(); // symbol used to create unique things w/same values
let largeNumber = 123456789012345678901234567890n; // bigint

console.log(age);

age = "hello";

console.log(name);
console.log(age);
console.log(address);

// object
let person = {          
    name: "John",
    age: 30
};
console.log(person);
greet();
// array - can have multiple data types, not limited to all strings, nums, etc.
let hobbies = ["reading", "gaming", 12345, null]; 

console.log(hobbies);

// function
function greet() {      
    console.log("Hello");
}
greet(); // invoking/calling the function

console.log("6" + 6); // becomes 66 string, not 12 
console.log("5" - 2); // becomes 3, '-' is not used w/strings
console.log("5" * "2"); // will also be treated as numbers, bc '*' cannot be used w/strings
console.log("five" * 2); // NaN (Not a Number)

// typeof

console.log(typeof 5); // returns type
console.log(typeof person); 
console.log(typeof NaN); // is a number

console.log(name2); // returns undefined - worst behavior! lol 
// with var, the variable is available, but not initiated.
// Makes errors hard to track. Use let and const instead
var name2 = "let";

{
    let name = "Greg";
    console.log(name);
    const secondname = "Mike";
    console.log(secondname);
}
console.log(name);

let fruits = ["apple", "banana", "orange"];

// access the values of the array with indexes
console.log(fruits[0]);

//if you want to add an element to the end of the array
// push
fruits.push("grape");
console.log(fruits);

fruits.pop();
console.log(fruits);

// For Loops

for(let i = 0; i< fruits.length; i++){
    console.log(fruits[i])
}

for (const element of fruits){
    console.log(element)
}

for(const key in person) // most often used for objects - returns key, not object
    {
        console.log(key)
        console.log(person[key])
    }

    function greetPerson(name){
        return "hello, " + name;
    }

    console.log(greetPerson("Mike"));

    //function expressions

    let greetPersonExpression = function(name){
        return "Hello, " + name;
    }
    console.log(greetPersonExpression("Jim"));

    class Person{
        constructor(name, age){
            this.name = name;
            this.age = age;
        }

        greet() {
            console.log("Hello, my name is " + this.name);
        }
    }

const mary = new Person("Mary", 40);
mary.greet();
console.log(mary);

// this keyword
/*
    this refers t othe current context in which a function is executed
    Its value depends on how a function is called
*/


// Arrow functions
// function expression
let add = function(param1, param2){
    return param1 + param2;
};
// can be reduced down to this arrow function. Below will implicitly return the value on the right side
add = (param1, param2) => param1 + param2;

console.log(add(1,2));

const Mike = {
    name: "Mike",
    greet: () => {
        console.log("Hello, my name is " + Mike.name);
    }
};
Mike.greet();