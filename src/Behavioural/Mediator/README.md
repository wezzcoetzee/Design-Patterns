# Mediator

## Definition

The Mediator pattern is a behavioral design pattern that promotes loose coupling between objects by allowing them to communicate with each other only through a mediator object.

## Example Scenario

We have a flight reservation system that consists of various components, including a flight search engine, a passenger information module, a payment gateway, and an email notification service. Each of these components needs to communicate with each other to complete the booking process. In such a scenario, we can use the Mediator pattern to reduce the coupling between these components and improve the overall system design.

Here's how the Mediator pattern can be implemented in this scenario:

1. Define the mediator interface that declares methods for communication between components.
2. Create the concrete mediator class that implements the mediator interface.
3. Define the base component class that holds a reference to the mediator.
4. Implement the specific components that extend the base component.
5. Now you can use the mediator in your main program to handle communication between components.