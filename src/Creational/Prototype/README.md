# Prototype

## Description

The Prototype pattern is a creational design pattern that allows you to create new objects by cloning an existing object, known as the prototype. This can be useful when the object creation process is expensive or complex.

## Example Scenario

Let's consider a real-world example using a graphic editor application that allows users to create and manipulate shapes.

Imagine we have a shape library with predefined shapes. Instead of creating a new shape from scratch every time a user wants to add a new one to the canvas, we can use the Prototype pattern to clone a shape from the library and add it to the canvas.

1. Define a Shape interface/abstract class with a Clone() method.
2. Define concrete classes that implement the Shape interface/abstract class.
3. Create a Shape Library (ShapeCache) class that stores the concrete classes in a Dictionary/Hashtable.