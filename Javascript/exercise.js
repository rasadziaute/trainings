//1. Accept 10 numbers and display even ones

const readline = require('readline')

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
    prompt: ':'
})

let input = [];
let inputCount = 0;
let number;

function isNumeric(n) {
    return !isNaN(parseFloat(n)) && isFinite(n)
}


(function giveNumber() {
    if (inputCount >= 10) {
        console.log(`Numbers: ${input.join(', ')}`)
        rl.close()
    } else {
        rl.question(`Give me a number: `, (answer) => {
            number = parseInt(answer)
            if (isNumeric(number)) {
                if (number % 2 == 0)
                    {input.push(answer)
                }
                inputCount = inputCount + 1;
                console.log(inputCount)
            }
            else {
                console.log("That's not a number");
            }
            giveNumber()
        })
    }
}());


// 3. Display rectangle of 3 columns

const readline = require('readline')

const r1 = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
    prompt: ':'
})

function isNumeric(n) {
    return !isNaN(parseFloat(n)) && isFinite(n)
}

let number;

(function displayNumber() {
    r1.question("Give me a number: ", (answer) => {
        number = parseInt(answer)
        if (isNumeric(number)) {
            for (let i = 0; i < 5; i++)
            {
                if (i==0 || i==4){
                    console.log(`${number} ${number} ${number}`);
                }
                else{
                    console.log(`${number} ${number}`);
                }
            } 
        }
    r1.close();
    })
}
());

//4. Program to accept the character from the user and check if the entered character is Vowel or not

const readline = require('readline')

const r1 = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
    prompt: ':'
})

let vowels = ['a', 'e', 'i', 'o', 'u'];

r1.question('A character please: ', (input) => {
    if(vowels.includes(input.toLowerCase())){
        console.log(`${input} is a vowel`);
    }
    else{
        console.log(`${input} is not a vowel`);
    }
    r1.close();
})

// 5. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene. 

const readline = require('readline')

const r1 = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
    prompt: ':'
})

let triangle;

r1.question('Enter 3 numbers for triangle sides: ', (input) => {
    triangle = input.split(',');
    if (triangle[0] === triangle[1] && triangle[0] === triangle[2]) {
        console.log('equilaterial');
    }
    else if (triangle[0] === triangle[1] || triangle[0] === triangle[2] || triangle[1] === triangle[2]) {
        console.log('isosceles');
    }
    else {
        console.log('scalene');
    }
    r1.close();
})








