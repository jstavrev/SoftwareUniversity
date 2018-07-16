"use strict";

function binaryLogarithm(nums) {

    for (let x of nums) {
        console.log(Math.log2(x));
    }
}

binaryLogarithm([5, 15, 25, 1000, 2014, 1024]);