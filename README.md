# Blocks Survival

A 2D survival game built in Unity where the player fights off increasingly 
difficult enemy waves. Built solo over 6 weeks as a final school project.

<img width="1245" height="692" alt="Unity_ScXAmB9LaC" src="https://github.com/user-attachments/assets/5a8053c9-fd28-43c1-b899-7bfe6b51ea77" />

## Gameplay
Survive as long as possible against endless enemy waves. Each wave gets 
progressively harder, the spawn rates increase and stronger enemies appear.


## Features
- Wave-based enemy spawning that scales in difficulty over time
- Weighted spawn system that randomly selects enemy types by assigned 
  weight values.
- The player shoots arrows to defend themselves against the enemies.

## How the Spawn System Works
Each enemy type is assigned a weight value. The game randomizes which enemies that spawn by taking the weight
of the enemies and comparing it to the remaining "credits". As the wave number increases, 
the higher max weight which makes more enemies spawn and higher chance of more tough enemies.
The enemies spawn in randomized locations around the player to prevent predictability of where the enemies come from.
As the waves get higher, the faster enemies spawn.
All of this combined gives a more randomized feel so the game doesn't feel as repetetive yet still not too different.


## Built With
- Unity (6000.2.8f1)
- C#

## What I Learned
This was my first time designing a system that needed to feel both random and balanced. The biggest challenge was tuning the enemy values so difficulty scaled smoothly rather than spiking, I went through several iterations before it felt right. I also learned that spawning enemies in predictable locations broke immersion immediately which is something I find important. This pushed me toward the randomized spawn radius approach. If I were to rebuild this game today I would add more content like, skills to give the player more tools to get further in the game. The most important thing was that I enjoyed working on it.



## How to Run
1. Clone the repository
2. Open in Unity (6000.2.8f1)
3. In the main menu press play.
