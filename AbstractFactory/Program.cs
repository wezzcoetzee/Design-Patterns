using AbstractFactory;

var dogFactory = new DogFactory();
var dog = dogFactory.CreateAnimal();
Console.WriteLine(dog.Speak());

var catFactory = new CatFactory();
var cat = catFactory.CreateAnimal();
Console.WriteLine(cat.Speak());

Console.ReadLine();