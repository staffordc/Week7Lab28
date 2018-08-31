var myMovieJson = [];
fetch('http://localhost:62268/api/Movies')
  .then(function(response) {
    return response.json();
  })
  .then(function(myJson) {
    myMovieJson=myJson
    $('.ui.dropdown')
    .dropdown({
      onChange: function (val) {
          console.log(val);
    var body = document.getElementById('MovieTableBody')
    body.innerHTML = " ";
    var filteredMovies = _.filter(myMovieJson, {'Category': val})
    _.each(filteredMovies, function(Movie){
        body.innerHTML += `
        <tr>
        <td>${Movie.Title}</td>
        <td>${Movie.Category}</td>
        <td>${Movie.Description}</td>
      </tr>
        `
    })
      },
      values: _
      .chain(myJson).uniqBy('Category')
      .map(function(Movie){
          return {name:Movie.Category, value:Movie.Category, text:Movie.Category}
      }).value() 
      
    })
  ;
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
