import React, { useState } from 'react'
import { UserLoginInput } from '../LoginComponent';
import { User } from '../LoginComponent';

function LoginFormComponent(props: any) {
    // const userInput : UserLoginInput = {username: "", password: ""};
    const [userInput, setUserInput] = useState<UserLoginInput>({username: "", password: ""});

    function usernameInputChangeHandler(event: any){
        // console.log(event.target.value)
        userInput.username=event.target.value;
        setUserInput({...userInput, username: event.target.value});
    }

    function passwordInputChangeHandler(event: any){
        // console.log(event.target.value)
        setUserInput({...userInput, password: event.target.value});
    }
    function submitClickHandler(){
        console.log(userInput);
        props.setLogininput(userInput);
 
    }
    return (
        <div>
            <input onChange={usernameInputChangeHandler} type='text' placeholder='username'></input>
            <br />
            <input onChange={passwordInputChangeHandler} type='password' placeholder='password'></input>
            <br />
            <input onClick={submitClickHandler} type='button' value='Submit'></input>
        </div>
    )
}

export default LoginFormComponent