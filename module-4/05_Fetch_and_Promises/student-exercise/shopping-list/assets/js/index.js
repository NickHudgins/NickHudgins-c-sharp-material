let items = [];

//submitting this as is for now. Unable to focus 
//right now with the interview pressure.
//will complete during thanksgiving break.



function loadGrocery() {
  console.log("Load Grocery List...");

  fetch('package.json') 
    .then((response) => {
      return response.json();
    })
    .then((data) => {
      reviews = data;
      displayGroceries();
    })
    .catch((err) => console.error(err));
}

function displayGroceries() {
    console.log("Display Groceries...");
  
    if('content' in document.createElement('template')) {
      const container = document.querySelector(".shopping-list");
      items.forEach((item) => {
        const tmpl = document.getElementById('shopping-list').content.cloneNode(true);
        container.appendChild(tmpl);
      });
    } else {
      console.error('Your browser does not support templates');
    }
  }
