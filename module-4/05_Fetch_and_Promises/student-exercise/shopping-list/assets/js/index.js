let items = [];

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
        // tmpl.querySelector('img').setAttribute("src",review.avatar);
        // tmpl.querySelector('.username').innerText = review.username;
        // tmpl.querySelector('h2').innerText = review.title;
        // tmpl.querySelector('.published-date').innerText = review.publishedOn;
        // tmpl.querySelector('.user-review').innerText = review.review;
        container.appendChild(tmpl);
      });
    } else {
      console.error('Your browser does not support templates');
    }
  }
