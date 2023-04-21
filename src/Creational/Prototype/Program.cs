using Prototype;

var shapeLibrary = new ShapeLibrary();

// Add predefined shapes to the library
shapeLibrary.AddShape("Small Circle", new Circle(5));
shapeLibrary.AddShape("Large Circle", new Circle(10));
shapeLibrary.AddShape("Small Rectangle", new Rectangle(5, 10));
shapeLibrary.AddShape("Large Rectangle", new Rectangle(10, 20));

// Use the Prototype pattern to clone shapes from the library
var smallCircle = shapeLibrary.GetShape("Small Circle");
var largeCircle = shapeLibrary.GetShape("Large Circle");
var smallRectangle = shapeLibrary.GetShape("Small Rectangle");
var largeRectangle = shapeLibrary.GetShape("Large Rectangle");

// Draw the shapes
smallCircle.Draw();
largeCircle.Draw();
smallRectangle.Draw();
largeRectangle.Draw();

Console.ReadLine();