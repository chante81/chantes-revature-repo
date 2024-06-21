class Animal {
    private name: string;

    constructor(name: string) {
        this.name = name;
    }

    public move(distance: number): void {
        console.log(`${this.name} moved ${distance} meters.`);
    }
}

class Dog extends Animal {
    constructor(name: string) {
        super(name);
    }

    public bark(): void {
        console.log('Woof! Woof!');
    }
}

const dog = new Dog('Buddy');
dog.bark(); // Output: Woof! Woof!
dog.move(10); // Output: Buddy moved 10 meters.

// Casting
let someValue: any = "this is a string";
let strLength: number = (someValue as string).length;

console.log(strLength); // Output: 16

// Literal Types
// Lets you specify exact values a variable can be

type Direction = "north" | "south" | "east" | "west";

let move: Direction;
move = "north"; // OK
// move = "up"; // Error: Type '"up"' is not assignable to type 'Direction'

// Type Guards
// Type guards allow you to narrow down the type within a conditional block.

function isNumber(value: any): value is number {
    return typeof value === "number";
}

function printValue(value: string | number) {
    if (isNumber(value)) {
        console.log(value.toFixed(2)); // TypeScript knows `value` is a number here
    } else {
        console.log(value.toUpperCase()); // TypeScript knows `value` is a string here
    }
}