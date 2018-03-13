var execSync = require("child_process").execSync;
var path = require("path");
var fs = require("fs");
var outputFile = path.normalize("./package.json");
var currentPackage = JSON.parse(fs.readFileSync('./package.json', 'utf8');

console.log(currentPackage.version);    
currentPackage.version;

fs.writeFileSync(outputFile);
console.log("Succesfully updated " + outputFile);