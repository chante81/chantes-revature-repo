import React from 'react'

function EventsDemo() {

    function clickEventTriggered(){
        console.log("Click button triggered");
    }

    function hoverEventTriggered(){
        console.log("Hover event triggered")
    }

    function inputChanged(event: any){
        //console.log("input has changed");
        console.log(event.target.value);
    }
  return (
    <div>
        <button onClick={clickEventTriggered}>Click Event</button>
        <button onMouseOver={hoverEventTriggered}>Hover Event</button>
        <input type="text" placeholder='Username' onChange={inputChanged}/>
    </div>
  )
}

export default EventsDemo