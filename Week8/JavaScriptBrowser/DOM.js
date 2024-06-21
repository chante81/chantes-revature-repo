console.log(document)

const header = document.getElementById('header');
console.log(header);

const intro = document.getElementsByClassName('intro');
console.log(intro);

const paragraphs = document.getElementsByTagName('p');
console.log(paragraphs);

const content = document.querySelector('#content');
console.log(content);

const allParagraphs = document.querySelectorAll('p');
console.log(allParagraphs);

header.textContent = 'Hello World!';

header.style.color = '#8720c7'; // can use css color picker to find the color you want

header.classList.add('highlight');

const button = document.getElementById('myButton');
button.remove();

const newButton = document.createElement('button');
newButton.textContent = "New Button!";
document.body.appendChild(newButton);

const contentDiv = document.getElementById('content');

// Parent node
const parent = contentDiv.parentNode;
const parentElements = contentDiv.parentElement;
console.log(parent);
console.log(parentElements);

// Child nodes
const children = contentDiv.childNodes;
const childrenElements = contentDiv.children;
console.log(children);
console.log(childrenElements);

// for(let i = childrenElements.length - 1; i >= 0; i--){
//     childrenElements[i].remove();
// };

// while(contentDiv.firstChild){
//     contentDiv.removeChild(contentDiv.firstChild);
// }

const paragraph1 = childrenElements[0];
const parentParagraphNode = paragraph1.parentNode;


// First child
const firstChild = contentDiv.firstChild;

// Last child
const lastChild = contentDiv.lastChild;

// // Sibling nodes
// const nextSibling = contentDiv.nextSibling;
// const previousSibling = contentDiv.previousSibling;


// Select the button
const newButtonSelected = document.getElementsByTagName('button')[0];
console.log(newButtonSelected); // sanity checking 
// - make sure you are working with the element you want to work with

// Define a function to run when the button is clicked
function handleClick() {
    alert('Button was clicked!'); // creates pop up box
}

// Add an event listener to the button
newButtonSelected.addEventListener('click', handleClick);

// promises approach

fetch('https://pokeapi.co/api/v2/pokemon/1')
    .then(response => response.json())
    .then(data => {
        console.log(data);
    })
    .catch(error => console.error('Error', error));

// Using Async/Await for fetching data

async function fetchData(){
    try{
        let response = await fetch('https://pokeapi.co/api/v2/pokemon/1')
        // await above allows code to stop and let us create next steps to 
        // only happen when line 94 is complete
        let data = await response.json();
        console.log(data);
    }
    catch(error){
        console.error('Error', error);
    }
}

fetchData();