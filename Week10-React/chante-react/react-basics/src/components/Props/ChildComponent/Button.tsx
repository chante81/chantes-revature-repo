import React from 'react'

function Button(props:{bgColor: string, isRound?: boolean}) {
    console.log(props);
  return (
    <button style={{
        backgroundColor: props.bgColor,
        color: "white",
        border: "none",
        borderRadius: props.isRound ? "100px" : "0px", //ternary operator condition ? true_statement : false_statement
        padding: "8px",
        fontSize: "20px"
    }}>Click Me</button>
  )
}

export default Button