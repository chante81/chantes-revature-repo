import React from 'react';
import './App.css';
import ComponentOne from './Components/ComponentOne/ComponentOne';

function App() : React.JSX.Element {
  return (
    <div className="App">
      <ComponentOne/>
      <ComponentOne/>
      <ComponentOne/>
      <ComponentOne/>
      <ComponentOne/>
    </div>
  );
}


// Class version of Component - cannot have both class and function components at the same time
// class App extends React.Component {
//   render() : React.ReactNode {
//     return (
//       <div className="App">
//         <h1>Hello!</h1>
//       </div>
//     )
//   }
// }

export default App;