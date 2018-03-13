var execSync = require('child_process').execSync;
var path = require('path');
var fs = require('fs');
var outputFile = path.normalize('./package.json');
var currentPackage = JSON.parse(fs.readFileSync('./package.json', 'utf8'));

console.log(currentPackage.version);    
let versions = currentPackage.version.Split('.');


fs.writeFileSync(outputFile);
console.log('Succesfully updated ' + outputFile);

var pkg = "{ 'name': '@etermax/chameleon','version': '1.0.0','author': 'ismaelserrada','dependencies': {'@etermax/etermax-ci': '2.1.1','@etermax/nfluent': '1.0.0','@etermax/unity-rx': 'latest'},'devDependencies': {'@etermax/upm-editor-plugin': 'latest'},'files': ['Assets/Package','CHANGELOG.md','.upm-config'],'license': 'UNLICENSED'}";
var version = json.parse(pkg).version;

var versions = version.split('.');
var major = Number(versions[0]);
major++;
versions[0] = major;
var output = versions.join('.');

console.log(output);