"use strict";

function CalcSumVat(input) {
    let sum = 0;
    for (let i = 0; i < input.length; i++) {
        sum += input[i];
    }
    console.log(sum);
    console.log(sum * 0.2);
    console.log(sum + sum * 0.2);
}

CalcSumVat([5, 5, 5, 5, 15, 11, 22, 33]);