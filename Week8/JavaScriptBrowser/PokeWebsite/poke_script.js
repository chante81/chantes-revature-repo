const searchContainer = document.querySelector("#search-container");
const displayContainer = document.querySelector("#display-container");

const inputNumber = searchContainer.children[0];
const searchButton = searchContainer.children[1];

console.log(inputNumber);
console.log(searchButton);

// need async function to communicate with the poke api
// function that takes in search input

function getSearchNumber() {
    let pokeId = inputNumber.value;
    getPokemon(pokeId);
}

searchButton.addEventListener('click', getSearchNumber);

// async function to talk to the api
async function getPokemon(pokeId) {
    const URL = "https://pokeapi.co/api/v2/pokemon/" + pokeId;
    try {
        let response = await fetch(URL);
        let data = await response.json();
        console.log(data);
        console.log(data.name);
        console.log(data.sprites.front_default);
        displayPokemon(data.name, data.sprites.front_default);
    } catch (error) {
        console.log(error);
    }
}

function displayPokemon(name, imgUrl){
    while(displayContainer.firstChild){
        displayContainer.removeChild(displayContainer.firstChild);
    }
    let pokeName = document.createElement("h3");
    pokeName.textContent = name;

    let pokeImage = document.createElement("img");
    pokeImage.src = imgUrl;

    displayContainer.appendChild(pokeName);
    displayContainer.appendChild(pokeImage);
}