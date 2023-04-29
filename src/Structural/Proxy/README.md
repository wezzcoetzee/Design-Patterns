# Proxy

## Definition

The Proxy pattern is a structural design pattern that involves a class representing the functionality of another class. The Proxy pattern is particularly useful when you need to control access to an object or when you want to add some extra functionality to an existing object without changing the original class.

## Example Scenario

Illustrating a situation where a video streaming service needs to control access to its content

1. IVideo: The common interface for both the RealVideo and ProxyVideo classes.
   csharp.
2. RealVideo: The class that represents the actual video content.
3. ProxyVideo: The proxy class that controls access to the RealVideo class.

The ProxyVideo class controls access to the RealVideo class based on an authorization flag. If the user is authorized, the ProxyVideo class creates an instance of the RealVideo class and plays the video. Otherwise, it denies access to the video content.