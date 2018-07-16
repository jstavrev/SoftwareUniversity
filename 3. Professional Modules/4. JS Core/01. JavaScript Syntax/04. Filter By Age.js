"use strict";

function ageFilter(minAge, nameOne, ageOne, nameTwo, ageTwo) {
    let personOne = {name: nameOne, age: ageOne};
    let personTwo = {name: nameTwo, age: ageTwo};
    if (personOne.age >= minAge) {
        console.log(personOne);
    }
    if (personTwo.age >= minAge) {
        console.log(personTwo);
    }
}

ageFilter(15, "tosho", 9, "gosho", 16);