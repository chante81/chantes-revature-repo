import React from 'react'

interface Fruit {
    fruitId: number;
    name: string;
    price: number;
    isAvailable: boolean;
}


function Lists() {
let fruits: Fruit[] = [
    {fruitId: 1, name: "Apple", price: 2.00, isAvailable: true},
    {fruitId: 23223, name: "Banana", price: 2.00, isAvailable: true},
    {fruitId: 1583, name: "Pineapple", price: 5.00, isAvailable: false},
    {fruitId: 1994, name: "Tangerine", price: 2.00, isAvailable: true}
]

  return (
<>
    {
    fruits.map((obj) => {
        return (
            <div key = {obj.fruitId}>
                <h2>{obj.name}</h2>
                <p>{obj.price}</p>
                <p>{obj.isAvailable ? "Available" : "Not Available"}</p>
            </div>
        );
    })
    }
</>
  )
}

export default Lists