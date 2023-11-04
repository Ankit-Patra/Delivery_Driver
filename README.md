# Delivery Driver Game Readme

## Overview

This readme file provides an overview of the "Delivery Driver" game created in Unity 2022.3.

## Game Description

In the "Delivery Driver" game, players take on the role of a delivery driver tasked with delivering packages in a simple neighborhood. The core mechanics of the game involve driving a car, picking up packages, and delivering them to specific locations while avoiding obstacles.

### Game Elements

- **Player's Car:** The main character is a delivery car that the player controls.
- **Obstacles:** Various obstacles in the neighborhood, which the player must avoid.
- **Package:** Packages that need to be picked up by the player.
- **Customer:** Delivery spots where packages must be delivered.
- **Speed Up:** Boosts that increase the car's speed.
- **Slow Down:** Obstacles that decrease the car's speed.

### Player Experience

The game is designed to be relaxing, and the core mechanic involves driving over pickups. The objective is to find and deliver all the packages to win the game.

## Game Development Steps

The game was developed in Unity 2021.1, and the following steps were taken to create it:

1. **Start Your Project:**
   - Created a new 2D project in Unity.
   - Added a capsule sprite to represent the player's car.
   - Created a C# script called "Driver" for controlling the car.
   - Renamed the capsule sprite to give the car a unique name.

2. **Introduction to Methods:**
   - **What Are Methods?** Methods (also called functions) in Unity execute blocks of code to make the game perform actions.
   - **Creating And Calling:** Introduced the concepts of creating and calling methods in Unity.

3. **Using `Transform.Translate()`**
   - **Make Our Car Move:** Demonstrated the use of `transform.Translate()` to move the car.
   - **Make Our Car Move Forward:** Explained how to use `transform.Translate()` in the `Update()` method to make the car move forward.

4. **Introducing Variables**
   - **Variables Are Like Boxes:** Variables help store, manipulate, and refer to information in the game.
   - **Some Common Types Of Variables:** Introduced common variable types like `int`, `float`, `double`, `bool`, and `string`.
   - **Create A Variable:** Guided to create a variable called `moveSpeed` to control the car's speed.

5. **Using `SerializeField`**
   - **Serialize Your `steerSpeed`:** Demonstrated the use of `[SerializeField]` to expose the `steerSpeed` variable in the Unity Inspector.

6. **Using `Input.GetAxis()`**
   - **Unity Input System:** Introduced the Unity Input System for player input.
   - **Add the Vertical Axis For Moving:** Explained how to use the Vertical Axis to enable driving the car forward and backward.

7. **Using `Time.deltaTime`**
   - **Using Time.deltaTime:** Explained the use of `Time.deltaTime` to make the game frame rate independent.

8. **Colliders & Rigidbodies**
   - Introduced the use of colliders and rigidbodies for handling collisions in Unity.

9. **Using `OnCollisionEnter2D`**
   - **Print Something To Console:** Demonstrated the use of `Debug.Log()` to print messages when collisions occur.

10. **Using `OnTriggerEnter2D`**
    - **Print When We Trigger Something:** Explained how to use `OnTriggerEnter2D()` and `Debug.Log()` to print messages when triggers are activated.

11. **Add Assets To Project**
   - **Sprites Are Made Of Pixels:** Explained the concept of asset resolution and pixels per unit.
   - **Unity Units:** Clarified that 1 Unity Unit represents an arbitrary unit of measurement.
   - **Pixels Per Unit:** Discussed the importance of pixels per unit for image assets.
   - **Set Up Your Assets:** Guided on how to set up assets in the scene for proper sizing.

12. **Basic Level Layout**
    - **Build A Simple Neighborhood:** Demonstrated creating a simple game environment with roads, houses, and trees.

13. **Simple Follow Camera**
    - **Creating A "Reference":** Explained the need to create references for accessing and manipulating objects beyond the car's transform.

14. **If Statements & Tags**
    - **If Statements:** Introduced if statements for making decisions based on conditions.
    - **Why Use Tags?:** Explained the use of tags to categorize game objects.
    - **Set Up Our Delivery Location:** Guided on creating a "customer" object, assigning a "Customer" tag, and printing messages on interactions.

15. **How To Use Bools**
    - **What Is A Bool?:** Introduced boolean variables (bool) for controlling game logic.

16. **How To Destroy Objects**
    - **Destroying Game Objects:** Explained the use of `Destroy()` to remove objects from the scene.
    - **Destroy Packages After 1 Second:** Guided on using `Destroy()` to remove packages after a specified delay.

17. **How To Use GetComponent**
    - **Change Our Car's Color:** Demonstrated how to change the car's color using `GetComponent` to access the Sprite Renderer's color property.

18. **Boosts & Bumps**
    - **A Bigger Challenge:** Presented a challenge to implement a boost and bump system that affects the car's speed when triggered or collided with.

These methods provide a step-by-step guide to developing various aspects of the "Delivery Driver" game in Unity, from basic movement to more complex features like collisions and power-ups.

## Running the Game

To run the game, open the Unity project and load the "Delivery Driver" scene. Play the game to experience the delivery driver's journey in the neighborhood, picking up and delivering packages while avoiding obstacles.