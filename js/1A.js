const line = readline();
const parts = line.split(" ").map(Number);

var n = parts[0];
var m = parts[1];
var a = parts[2];

var tilesN = Math.floor((n + a - 1) / a);
var tilesM = Math.floor((m + a - 1) / a);

print(tilesN * tilesM);
