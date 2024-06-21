/*
    Functions in TS are similar to JS
    we have the ability now to have typed parameters and return types

*/

// regular fuction
function addNumbers(x: number, y: number): number {
    return x + y;
}

let sum: number = addNumbers(3, 5);
console.log(sum);

// Arrow Functions Syntax
// provide a more concise syntax

const multiplyNumbers = (x: number, y: number) : number => {
    return x * y;
}

let product: number = multiplyNumbers(2, 5);
console.log(product);

// Anonymous functions
// functions w/o a name often used as arguments to other functions
// you can pass a function as a parameter

setTimeout(function(){
    console.log("this is an anonymous function")
}, 1000);

setTimeout(() => {
    console.log("this is an arrow anonymous function")
}, 1000);

// Function overloading
// TS supports function overloading allowing mutliple function signatures for a single function body

function concatenate(x: string, y: string): string;
function concatenate(x: number, y: number): number;
function concatenate(x:any, y: any) : any{
    return x + y;
}

let stringResult = concatenate("hello", "world"); // hello world
let numberResult = concatenate(12, 5); // 17

// Optional and Default Parameters
// Optional parameters are specified with a ? 

function greetPerson(name: string, greeting?: string): string {
    if(greeting){
        return`${greeting}, ${name}`;
    }
    else{
        return `Hello there, ${name}`;
    }
}

// Default parameters provide a way to give a default value if nothing is given

function greetDefault(name: string, greeting: string = "Hello"): string {
    return `${greeting}, ${name}`;
}

// Rest Parameter
// uses this operator to define ...
// Useful for React. This allows a function to accept an indefinite number of arguments as an array

function summing(name: string, ...numbers: number[]): string {
    let total = numbers.reduce((total, num) => total + num, 0);
    return `${name}, your total is ${total}`;
}

console.log(summing("Mike", 3, 4, 5, 6, 7, 8, 10));