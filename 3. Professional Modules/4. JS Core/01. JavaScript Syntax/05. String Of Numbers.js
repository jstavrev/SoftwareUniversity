"use strict";

function stringNumbers(input) {
    let n = parseInt(input);
    let str = "";
    for (let i = 1; i <= n ; i++) {
        str += i;
    }
    console.log(str)
}

stringNumbers(5);