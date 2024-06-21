import React from 'react'

function ListDemo() {
    let people = [
        {
            firstName: "John",
            lastName: "Doe"
        },
        {
            firstName: "Jane",
            lastName: "Doe"
        },
        {
            firstName: "Mick",
            lastName: "Doe"
        },
    ];



    return (
        // The <> fragment tag lets you not have to use <div> as the parent and 
        // have a bunch of nested divs in your page. Helps organize your code and helps 
        // screen readers understand what htey are looking at specifically, 
        // not a bunch of nested divs
        <>
            {
                /*
                To display each item in an array to the DOM, we use the map function
                The map function tranforms each item in an array in a specific way that
                you can define
                */

                people.map((obj, index) => {
                    return (
                        <div key={index}>
                            <h1>{obj.firstName}</h1>
                            <h3>{obj.lastName}</h3>
                        </div>
                    );
                })

            }
        </>
    )
}

export default ListDemo