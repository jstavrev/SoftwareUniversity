"use strict";

function fruitVegetables(input) {
    switch (input) {
        case "banana":
        case "apple":
        case "kiwi":
        case "cherry":
        case "lemon":
        case "grapes":
        case "peach" :
            console.log("fruit"); break;
        case "tomato":
        case "cucumber":
        case "pepper":
        case "onion":
        case "garlic":
        case "parsley":
            console.log("vegetable"); break;
        default:
            console.log("unknown"); break;
    }
}

fruitVegetables("banana");
fruitVegetables("onion");
fruitVegetables("dasdas");