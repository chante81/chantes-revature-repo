import React from 'react'

function Events() {
  return (
    <>
        <input
        onClick={() => console.log("click")}
        type="button"
        value="click me"
        />
        <input 
        type="text"
        onChangeCapture={(event: any) => console.log(event.target.value)}
            />    
    </>
  )
}

export default Events