# Bridge

## Definition

The Bridge pattern is a structural design pattern that decouples an abstraction from its implementation, so that the two can vary independently. It's particularly useful when you have complex hierarchies or when you want to avoid tight coupling between components.

## Example Scenario

Using the concept of a messaging app that supports different types of messages (text, image, video) and various message delivery mechanisms (email, SMS, push notifications).

1. Define a MessageSender interface class with a SendMessage() method.
2. Define concrete classes that implement the MessageSender interface class.
3. Create an abstract Message class that has a MessageSender member variable.
4. Create concrete Message classes that inherit from the Message class.