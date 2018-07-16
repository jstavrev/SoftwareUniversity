"use strict";

function findOddEven(n) {
    if ( n % 1 !== 0) {
        console.log("invalid")
    } else {
        if (n % 2 === 0) {
            console.log("even")
        } else {
            console.log("odd");
        }
    }
}

findOddEven(5);
findOddEven(4);
findOddEven(2.5);