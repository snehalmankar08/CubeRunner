Cube Runner 3D (Unity)

"Cube Runner 3D" is an endless runner–style 3D game developed using "Unity" and "C#", where the player controls a cube that moves forward automatically and must avoid obstacles while collecting score.

Game Overview

The player controls a cube running along a path. The objective is to survive as long as possible by avoiding obstacles and maintaining smooth movement. The game features collision detection, scoring, camera follow mechanics, and game control logic.

Features

* 3D endless runner gameplay
* Smooth forward movement and camera follow
* Obstacle collision detection
* Score tracking system
* Modular and organized project structure
* Sound effects support

Technologies Used

* Unity Engine (3D)
* C#
* Unity Physics & Materials
* Prefabs for reusable objects

Project Structure

Assets/
├── Material/
├── Physics Material/
├── Prefabs/
├── Scenes/
├── Scripts/
│   ├── Sound Effects/
│   ├── FollowPlayerScript.cs
│   ├── FollowPlayerScript.cs.meta
│   ├── GameController.cs
│   ├── GameController.cs.meta
│   ├── PlayerCollision.cs
│   ├── PlayerCollision.cs.meta
│   ├── PlayerScript.cs
│   ├── PlayerScript.cs.meta
│   ├── Score.cs
│   └── Score.cs.meta

Script Responsibilities

* "PlayerScript.cs" – Handles player movement and controls
* "PlayerCollision.cs" – Detects collisions with obstacles
* "FollowPlayerScript.cs" – Makes the camera follow the player smoothly
* "GameController.cs" – Manages game state (start, game over, restart)
* "Score.cs" – Tracks and updates the player’s score

How to Run the Project

1. Clone or download this repository
2. Open "Unity Hub"
3. Click "Open Projec" and select the project folder
4. Open the main scene from the `Scenes` folder
5. Press "Play ▶️" to start the game

License

This project is created for learning and educational purposes.
You are free to modify and improve it.


