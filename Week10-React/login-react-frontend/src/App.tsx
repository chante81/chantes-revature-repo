import React from 'react';
import LoginComponent from './Components/LoginComponent/LoginComponent';
import { Route, Routes } from 'react-router-dom';

function App() {
  return (
    <div className="App">
      <Routes>
      <Route path ="/" element={<LoginComponent/>}/>
      </Routes>
    </div>
  );
}

export default App;
