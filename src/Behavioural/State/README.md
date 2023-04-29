# State

## Definition

The State Pattern is a behavioral design pattern that allows an object to alter its behavior when its internal state changes. This pattern is particularly useful when an object's behavior depends on its state and must change at runtime. The main idea is to encapsulate state-specific behavior within separate classes and delegate the actual behavior to these state objects.

## Example Scenario

Let's consider a more complex example: an audio player that can be in different states like Playing, Paused, or Stopped.

1. Define a `State` interface that represents the common behavior of all states.
2. Create concrete state classes for each possible state of the audio player, implementing the `State` interface. 
3. Implement a `Context` class that holds a reference to a `State` object and delegates its behavior to the current state.