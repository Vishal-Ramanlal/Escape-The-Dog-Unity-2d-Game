# RamanlalVishal_EscapeTheDOG_P2

Readme.md in the root of the repo – Brief description outlining the architecture of the game code.  Including

### Where the main game loop is and where inputs are handled.
#### Controls
    W,S,A,D or Arrow Keys

#### Game Loop
Located in the MainCharacterScript.cs and RestartScript (Restarts the game)

### The game flow as what the player does to move forward in the game.

#### Objectives
    Survive as long as possible and Gain points.
    Collect chest items to boost points by 1000
    Dont die. If a dog catches the player the game is over. 
    Attempt to get High scores
### Links to any libraries or asset origin.
None

### A description of the most technically challenging/interesting part of the prototype.

The prototype concept was originally pitched as a fire tag game. Where players would run around and tag each other. Upon a little more planning the concept was changed to a single player game where AI would chase the player around and attempt to tag them indicating the game has concluded. 
The game included features such as:
* The ability to dash
* The ability to pick up abilities
* Deploy Abilities. 
* Map player modifiers:
    * Lava floors( ai can move freely in but damages and slows player)
    * Water floors (opposite of lava floors)
    * Speed Ramps

Unfortunately by the time the prototype was due none of the features were implemented. The reason for this was due to the games basic and core elements took a long time to develop. One reason for this was the unfamiliarity with the Unity engine and game development. 

The final prototype features includes: 
* Top down 2d perspective map.
* Player being able to move N,E,S,W.
* Player Collisions with Map boundaries
* Player Triggering chest.
* Chest Dropping bonus when triggered
* Bonus Item Grants 1000 points
* AI basic follow mechanics 
    * Does Not have A*/Pathfinding which is a problem as A* usually gets stuck behind walls.
* Player and AI animations
* Score UI and scripts
* Death screen and restart option
* Follow Camera with parameter bounds (does not clip of map)
* Player Dies when the AI and player collide. 
* Object Layering perspective (player runs behind house player disappears off screen)

Most challenging part was scripting as i was still getting familiar with the structure and inheritance between objects and classes. Otherwise most online tutorials were intuitive. 

One Problem that i was trying to solve was the pathfinding however with the 2d methodology that we chose to practice it did prove to be quite a struggle. Most 3D pathfinding tools can auto generate paths for Ai, and this is done by using objects to act as obstacles. In 2d using the painter tool i couldn't figure out how to identify certain tiles as objects and the rest are fine. Therefore i was unable to implement the feature.
