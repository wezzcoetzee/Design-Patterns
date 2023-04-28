# Factory Method

## Description

The Factory Method pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object that will be created. This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.

## Example Scenario

Consider an application that deals with different types of transport vehicles, such as cars and trucks. Each type of vehicle has a specific way of calculating the cost for using it. We can use the Factory Method pattern to create the appropriate vehicle objects and handle the cost calculation based on the type of vehicle.

1. Define a Vehicle interface with a CalculateCost() method.
2. Define the Car and Truck classes that implements the Vehicle interface.
3. Define a VehicleFactory class with a CreateVehicle() method that returns a Vehicle object.

This example demonstrates the use of the Factory Method pattern to create the appropriate vehicle objects based on user input. The `VehicleFactory` class has a static method `GetFactory` that returns the correct factory subclass based on the input, which then creates the corresponding vehicle object.