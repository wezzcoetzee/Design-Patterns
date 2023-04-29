# Decorator

## Definition

The Decorator pattern is a structural design pattern that allows you to add new functionality to an object without changing its existing structure. In C#, you can achieve this by creating a decorator class that wraps the original class and provides additional behavior.

## Example Scenario

the Decorator pattern in the context of a coffee shop, where various coffee types and add-ons are available.

1. Create an interface for the coffee components.
2. Create `Espresso` and `Cappuccino` classes that represents the base coffee.
3. Create `Milk` and `WhippedCream` decorators (classes) that implements the `ICoffee` interface (the addons to the coffee).
4. Create coffee orders with various combinations of coffee types and add-ons.