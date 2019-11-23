let display;
let previous = null;
let operator = null;
let operatorClicked = false;

/**
 * Calculates the operation and updates the display.
 */
function performOperation() {
  let result;
  const current = parseNumber(display.value);
  previous = parseNumber(previous);

  switch (operator) {
    case '+':
      result = previous + current;
      break;
    case '-':
      result = previous - current;
      break;
    case '*':
      result = previous * current;
      break;
    case '/':
      result = previous / current;
      break;
  }

  display.value = result;
  operator = null;
}

/**
 * Parses the display value into a number (float or int).
 * @param {String} num 
 */
function parseNumber(num) {
  return num.includes('.') ? parseFloat(num) : parseInt(num);
}

/**
 * Capture the previous value and the clicked operator
 * so that an operation can be performed.
 */
function clickOperator() {
  operator = event.target.value;
  previous = display.value;
  operatorClicked = true;
}

/**
 * Captures a number click and updates the display value.
 * @param {Event} event 
 */
function clickNumber(event) {
  const val = event.target.value;

  if (operatorClicked) {
    display.value = val;
    operatorClicked = false;
  } else {
    display.value == 0 ? display.value = val : display.value += val;
  }
}

/**
 * Resets the display value.
 */
function clear() {
  display.value = 0;
}

function numListener() {
  const nums = document.querySelectorAll('.number');
  const dec = document.querySelectorAll('.decimal');

  dec[0].addEventListener('click', event => {
    clickNumber(event);
  })

  for (let i = 0; i < nums.length; i++) {
    const numButton = nums[i];
    numButton.addEventListener('click', event => {
      clickNumber(event);
    });
  }
}

function clearButton() {
  const useClearBtn = document.querySelector('.all-clear');
  useClearBtn.addEventListener('click', () => {
    clear();
  });
}

function allOperators() {
  const operator = document.querySelectorAll('.operator');

  for (let i = 0; i < operator.length; i++) {
    operator[i].addEventListener('click', event => {
      clickOperator(event);
    });
  }
}

function equalsListener() {
  const equals = document.querySelector('.equal-sign');
  equals.addEventListener('click', event => {
    performOperation(event);
  });
}

// add event listener for when the DOM is loaded
document.addEventListener('DOMContentLoaded', () => {

  // set the variable called display equal to the display element
  // HINT: use its id #display to get a reference to it
  display = document.querySelector('#display');

  // get a reference to all of the numbers
  // loop over each of the numbers
  // add a click event listener to each number to call the function clickNumber
  numListener();

  // get a reference to the decimal point button
  // add a click event listener to call the function clickNumber
  // the decimal point is part of the number so append it

  // get a reference to the all clear button
  // add a click event listener to call the function clear  
  clearButton();

  // get a reference to all of the operators;
  // loop over each of the operators
  // add a click event listener to each operator to call the function clickOperator
  allOperators();

  // add click event listener for the equal sign
  // should call the function performOperation
  equalsListener();
});

