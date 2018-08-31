fetch('http://localhost:62268/api/Movies')
  .then(function(response) {
    return response.json();
  })
  .then(function(myJson) {
    var body = document.getElementById('MovieTableBody')
    body.innerHTML = " ";
    _.each(myJson, function(Movie){
        body.innerHTML += `
        <tr>
        <td>${Movie.Title}</td>
        <td>${Movie.Category}</td>
        <td>${Movie.Description}</td>
      </tr>
        `
    })
    console.log(JSON.stringify(myJson));
  });
