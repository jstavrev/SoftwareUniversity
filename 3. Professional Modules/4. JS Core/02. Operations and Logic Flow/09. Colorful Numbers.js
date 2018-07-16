"use strict";

function colorfulNumbers(n) {
    let string = "<ul>\n"
    for (let i = 1; i <= n ; i++) {
        if (i % 2 === 0) {
            string += `<li><span style='color:blue'>${i}</span></li>\n`;
        } else {
            string += `<li><span style='color:green'>${i}</span></li>\n`;
        }
    }
    string += "</ul>"
    console.log(string);
}

colorfulNumbers(10);