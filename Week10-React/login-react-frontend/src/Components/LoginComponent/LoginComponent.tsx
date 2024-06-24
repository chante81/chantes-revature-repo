import React, { useEffect, useState } from 'react'
import LoginFormComponent from './LoginFormComponent/LoginFormComponent';

export interface UserLoginInput {
    username: string;
    password: string;
}
// Below interface is based on backend API
// if returning fields essential to application, make sure to include here!
// make sure to match to JSON response
export interface User {
    userId: number;
    username: string;
    firstName: string;
    lastName: string;
    email: string;
    age: number;
    isAdmin: boolean;
}

function LoginComponent() {

    const [user, setUser] = useState<User | undefined>(undefined);

    const [loginInput, setLoginInput] = useState<UserLoginInput | undefined>(undefined);
    useEffect(() => {
               /*
        we are not communicating to an API in this example, but assume here is where you would do
        fetch / axios request to your backend API to login the user
        */

        if(loginInput?.username === 'user1' && loginInput.password === 'pass1'){
            console.log("logged in!");
            let loggedInUser : User = {
                userId: 1,
                username: 'user1',
                firstName: 'John',
                lastName: 'Doe',
                email: 'john.doe@email.com',
                age: 33,
                isAdmin: false     
            };
            setUser(loggedInUser);
        }else{
            console.log("Not logged in!");
            setUser(undefined);
        }
        
    }, [loginInput]);

  return (
    <div>
        <LoginFormComponent/>

        {
            // Best when you want to display for true and false scenarios
            // user ? <h1>Welcome, {user?.firstName}!</h1> : <h1>You are not logged in</h1>
            // Best when you only want to display when both are true
            user && <h1>Welcome, {user?.firstName}!</h1>
        }
    </div>
  )
}

export default LoginComponent