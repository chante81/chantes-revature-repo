var isDone = false;
var age = 26;
var firstName = 'John';
var u = undefined;
var n = null;
// you cannot reassign a value to something that doesn't match its declared datatype
// isDone = "Hello";  // does not work because isDone is a boolean  to run script: npx tsc [fileName]
// can still run transpiler and get js and js file will work, but defeats the purpose of ts
// Arrays
// syntax
// the typing now allows us to have type safety in our arrays
// type[] or Array<type> 
var numberList = [1, 2, 3];
var genericNumberList = [1, 2, 3];
// Tuple
// lets you define an array with fixed types and length
var tupleExample; // only allows 2 values, one being a string and the other being a number
tupleExample = ["hello", 10];
// tupleExample = [10, "Hello"]; // will not work due to error
// Enums
// allows you to define a set of named constant
// numerical enum. Basically you can think of this as a predefined array where the indexes are actually values
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 2] = "Blue";
})(Color || (Color = {}));
var StatusCodes;
(function (StatusCodes) {
    StatusCodes[StatusCodes["Ok"] = 200] = "Ok";
    StatusCodes[StatusCodes["Created"] = 201] = "Created";
    StatusCodes[StatusCodes["NotFound"] = 404] = "NotFound";
})(StatusCodes || (StatusCodes = {}));
var colorExample = Color.Green;
console.log(colorExample);
// string enums
// you must define every single value - no defaults
var CardinalDirections;
(function (CardinalDirections) {
    CardinalDirections["North"] = "North";
    CardinalDirections["East"] = "East";
    CardinalDirections["South"] = "South";
    CardinalDirections["West"] = "West";
})(CardinalDirections || (CardinalDirections = {}));
var direction = CardinalDirections.North;
console.log(direction);
// Any
// any type lets you opt-out of type checking. Allows loose typing like JavaScript
var notSure = 5;
notSure = "Hello";
notSure = false;
// void 
// the void type is used for functions that do not return a value
function sayHello() {
    console.log("Hello!");
}
