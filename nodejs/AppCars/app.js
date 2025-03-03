class Car 
{
    static _lastId = 0;

    constructor(_brand, _modelName, _year) {
        this.id = ++Car._lastId;
        this.brand = _brand;
        this.model = _modelName;
        this.year = _year;
    }

    toString() {
        return this.id + ': ' + this.brand + ' ' + this.model + ' (' + this.year + ').';
    }
}


const cars = [
  new Car('Chevrolet ', 'Chevelle Malibu', 1970),
  new Car('Ford ', 'Torino 500', 1971),
  new Car('Volvo ', '264GL', 1978),
  new Car('Honda ', 'Civic', 1982),
  new Car('Toyota  ', 'Celica GT', 1982)
];


const express = require("express");
const app = express();
const port = 3000;


// GET http://localhost:3000/
app.get('/', (req, res) => {

  let result = JSON.stringify([
    { url: '/cars', description: 'List of Cars' },
    { url: '/car/:id', description: 'Single car' }
  ]);

  res.setHeader('Content-Type', 'application/json');
  res.send(result);
});


// GET http://localhost:3000/cars
app.get('/cars', (req, res) => {
  res.setHeader('Content-Type', 'application/json');
  res.send(JSON.stringify(cars));
});


// GET http://localhost:3000/car/:id
// ex: // GET http://localhost:3000/car/3 -> show the car with ID 3
app.get('/car/:id', (req, res) => {

  let result = cars.find(x => x.id === parseInt(req.params.id))

  if(result === undefined) {
    result = { error: 'Unable to find this car.'}
  }

  res.setHeader('Content-Type', 'application/json');
  res.send(result);
});


// Start server
app.listen(port, () => {
  console.log(`App is listening on port ${port}`);
});
