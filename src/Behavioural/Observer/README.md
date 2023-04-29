# Observer

## Definition

The Observer Pattern is a behavioral design pattern that allows objects to be notified when the state of another object changes. It promotes a loose coupling between the subject (the object being observed) and the observers (the objects that are notified of the changes). In C#, you can implement the Observer Pattern using interfaces and events.

## Example Scenario

A simple stock market application that notifies investors when the price of a stock changes.

1. Define the interfaces for the subject and the observer.
2. Implement the subject (Stock).
3. Implement the observers (StockPriceDisplay and StockPriceAlert).
4. Use the Observer Pattern.