import React from 'react';
import './App.css';
import ComponentOne from './components/ComponentOneFolder/ComponentOne';
import ComponentTwo from './components/ComponentTwoFolder/componentTwo';
import EventsDemo from './components/EventsDemo/EventsDemo';
import ListDemo from './components/ListDemo/ListDemo';
import ParentComponent from './components/Props/ParentComponent/ParentComponent';
import { Route, Routes } from 'react-router-dom';
import NavBar from './components/NavBar/NavBar';
import ExerciseOne from './components/ExerciseOne/ExerciseOne';
import Events from './components/Events/Events';
import Lists from './components/Lists/Lists';
import Hooks from './components/Hooks/Hooks';


function App(): React.JSX.Element {
  return (
    <div className="App">
      {/* <ComponentOne/>
      <ComponentTwo/>
      <EventsDemo/>
      <ListDemo/>
      <ParentComponent/>
      <ExerciseOne/>
      <Events/> 
      <Lists/>*/}
      <NavBar />

      <Routes>
        <Route path='/' element={<ComponentOne />}></Route>
        <Route path='/events' element={<EventsDemo />}></Route>
        <Route path='/lists' element={<ListDemo />}></Route>
        <Route path='/props' element={<ParentComponent />}></Route>
        <Route path='/hooks' element={<Hooks />}></Route>
      </Routes>
    </div>
  );
}

export default App;
