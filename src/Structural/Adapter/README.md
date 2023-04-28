# Adapter

## Description

The Adapter Pattern is a structural design pattern that allows two incompatible interfaces to work together. It converts the interface of a class into another interface that the client expects. This pattern is useful when you want to use an existing class or interface, but its interface does not match the one you need.

## Example Scenario

The Adapter Pattern is when you need to integrate an external library or API into your application, but the library or API's interface does not match the one your application expects.

Imagine you are developing an e-commerce application that processes payments from various payment gateways like PayPal, Stripe, and others. Your application has a common interface for processing payments, but each payment gateway has its own API with different method names and signatures.

1. Define a PaymentProcessor interface class with a ProcessPayment() method.
2. Define concrete classes that implement the PaymentProcessor interface class.
3. Create an Adapter class that implements the PaymentProcessor interface class and wraps the external library or API.
4. Create a PaymentProcessorFactory class that returns the appropriate PaymentProcessor concrete class based on the payment gateway type.
5. 