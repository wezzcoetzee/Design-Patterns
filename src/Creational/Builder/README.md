# Builder

## Definition

The Builder pattern is a creational design pattern that allows for the step-by-step construction of complex objects using a specific sequence of actions. It's particularly useful when you need to create an object with many optional or required parameters, and you want to avoid the telescoping constructor anti-pattern.

## Example Scenario

Let's consider a real-world example of a Pizza ordering system. The Builder pattern is useful here because there are many possible combinations of ingredients and options when creating a Pizza object.

1. Define a Pizza class with a Builder nested class
2. Define a Builder constructor that takes in the required parameters for a Pizza object.
3. Define methods in the Builder class for each optional parameter of a Pizza object.
4. Define a build() method in the Builder class that returns a Pizza object.
5. Create a Pizza object using the Builder class.

In this example, the Builder pattern allows you to build a Pizza object step-by-step, specifying various ingredients and options. The inner PizzaBuilder class provides methods to set the properties of the Pizza object and a Build() method to create a new Pizza instance. The resulting code is easy to read and understand, which is an advantage when dealing with complex objects with many optional or required parameters.