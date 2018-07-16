"use strict";

function printChessboard(n) {
    let string = "<div class=\"chessboard\">\n";
    for (let i = 0; i < n ; i++) {
        string += " <div>\n";
        let color = (i % 2 !== 0) ? "white" : "black";
        for (let j = 0; j < n ; j++) {
            string += `        <span class="${color}"></span>\n`
            color = (color === "black") ? "white" : "black";
        }
        string += " </div>\n";
    }
    string += "</div>";
    console.log(string);
}

printChessboard(10);