# Strategy

## Description

The strategy pattern is a behavioral design pattern that enables selecting an algorithm at runtime. Instead of implementing a single algorithm directly, code receives run-time instructions as to which in a family of algorithms to use. It promotes the use of multiple algorithms interchangeably and enhances the flexibility and maintainability of the code.

## Example Scenario

A shipping cost calculator for an e-commerce application. Shipping costs can vary based on factors like package weight, shipping method, and destination. Using the strategy pattern, we can easily switch between different shipping cost calculation algorithms without modifying the core logic.

1. Define an interface for the shipping cost calculation strategy
2. Implement concrete strategies for each shipping cost calculation algorithm
3. Define a context class that accepts a shipping cost calculation strategy through the constructor
4. Use the context class to calculate shipping costs