let pageTitle = 'My Shopping List';
let groceries= ['milk', 'cookies', 'bread', 'apples', 'lunch meat', 'cheese', 'potatoes', 'carrots', 'hamburger', 'cereal'];
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const setTitle = document.getElementById("title");
  setTitle.innerHTML = pageTitle;
}


/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const main = document.getElementById('groceries');

  groceries.forEach((groceries) => {
    const container = document.createElement('li');
    container.innerText = groceries;
    container.setAttribute("class", "groceries");
    main.insertAdjacentElement("beforeend", container);
  });
}


/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  const completed = document.querySelectorAll("li.groceries");
  completed.forEach((item) => {
    item.classList.add("completed");
  });
}

setPageTitle();

displayGroceries() 

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
