let isDone: boolean = false;
let age: number = 26;
let firstName: string = 'John';
let u: undefined = undefined;
let n: null = null;

// you cannot reassign a value to something that doesn't match its declared datatype

// isDone = "Hello";  // does not work because isDone is a boolean  to run script: npx tsc [fileName]
// can still run transpiler and get js and js file will work, but defeats the purpose of ts

// Arrays
// syntax
// the typing now allows us to have type safety in our arrays
// type[] or Array<type> 

let numberList: number[] = [1, 2, 3];
let genericNumberList: Array<number> = [1, 2, 3];

// Tuple
// lets you define an array with fixed types and length

let tupleExample: [string, number]; // only allows 2 values, one being a string and the other being a number

tupleExample = ["hello", 10];
// tupleExample = [10, "Hello"]; // will not work due to error

// Enums
// allows you to define a set of named constant
// numerical enum. Basically you can think of this as a predefined array where the indexes are actually values

enum Color {
    Red,
    Green,
    Blue
}

enum StatusCodes {
    Ok = 200,
    Created = 201,
    NotFound = 404
}

let colorExample: Color = Color.Green;
console.log(colorExample);

// string enums
// you must define every single value - no defaults

enum CardinalDirections {
    North = "North",
    East = "East",
    South = "South",
    West = "West"
}

let direction: CardinalDirections = CardinalDirections.North;
console.log(direction);

// Any
// any type lets you opt-out of type checking. Allows loose typing like JavaScript

let notSure: any = 5;
notSure = "Hello";
notSure = false;

// void 
// the void type is used for functions that do not return a value

function sayHello() : void {
    console.log("Hello!")
}

// never
// never represents values that never occur
// It is used for functions that always throw an error or never return

function error(message: string): never {
    throw new Error(message);
}