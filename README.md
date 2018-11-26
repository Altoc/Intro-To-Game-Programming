# Intro To Game Programming
My work for Intro to Game Programming, Kent State, Fall 2018. 
Index:
Assignment 2: 
  Building on the environment you set up in Assignment 1:
  1. Make the all blocks in the game static objects with your choice of colors and textures.
  2. Remove the sphere.
  3. Modify the blocks as necessary to set up a Nav Mesh that will not include any of the blocks or the
  other static objects of the environment.
  4. Add the player object and its complete animations from the Survival Shooter tutorial, as developed
  through phase 6, Player Health, to the game as the player.
  5. Add Zombunny and its complete animations to the environment and as in Survival Shooter phase 4
  make the Zombunny move at the start toward the player.
  6. Modify the actions of the Zombunny so that it will alternately move toward the player or move away
  from the player when the spacebar is pressed.
  7. Add a billboard hovering just above the Zombunny that always faces the camera that is red when the
  Zombunny is pursuing the player and blue when it is fleeing from the player.

Assignment 3:
  Building on the environment you set up in Assignment 2 and on the assigned tutorial make this game
  behave and look like PacMan:
  1. Make a PacMan-like maze of walls for the game objects to move in. Set up a Nav Mesh to permit the
  enemies to navigate to through it. Make an escape path that allows the player to escape to the opposite
  side of the board. Generate another array of positions that covers the entire maze to spawn enemies,
  power-ups, and health pickups.
  2. Add health and power-up objects. The health and power-up objects should appear at random times
  and at random, unoccupied points from the spawn position array and remain at those positions until
  “picked up” by the player. The health pickups should double the health of the player up to at most
  100%. The power-ups make all enemies flee from the player for a time dependent on the a public
  variable of the enemy and make the health deduction for any enemy hit by the laser during that time
  also dependent on the public variable of the enemy.
  4. Add the Zombear and Hellphant enemies and program billboards over their heads as in Assigment 2
  5. Add the scoring system and game over screen from the tutorial to the game.
  
Assignment 4:
  In this assignment you will create the beginnings of a Unity Pac-Man game. If you've not played
  Pac-Man before go to http://www.webpacman.com/ to see how it is played and how the characters are
  animated. Use sprite sheets found by googling “pac man sprite sheets” to produce
   1. Animations of the Pac-Man character.
   a) Pac-Man death animation.
   b) Pac-Man eating animation.
   c) Pac-Man idle.
   2. Animations for the 4 ghosts.
   a) Animations after Pac-Man power up.
   b) Animation back to regular ghosts at the end of the power up time.
   c) Animation when ghost is eaten.
   3. Add left,right,up, down arrow key controls to the Pac-Man character movements.
   4. Add collider boxes to the Pac-Man character and to the ghosts that generate the animations in
  the Pac-Man game.
   5. Place each of the four ghosts, four power up dots, and the Pac-Man character on a empty game
  board (i.e. no maze).
   6. When the game starts the ghosts should be animate but not moving. Use this setup to test the
  animations and collision logic.
   a) If the Pac-Man eats a dot, the ghosts should be edible and then transition back to Pac-Man
  killers.
   b) If the Pac-Man attacks a ghost when it is a Pac-Man killer the Pac-Man should go into its
  death animation.
   c) The Pac-Man should only animate eating when it is moving.
  See http://docs.unity3d.com/Manual/SpriteEditor.html for details on editing the Pac-Man sprite sheet to
  produce an animation.
  
Assignment 5:
  Building on the animations and collision responses develop for the PacMan game developed in
  Assignment 4, add the following to make a realistic simulation of a PacMan game:
  • A maze similar to the standard PacMan game
  • Evenly space dots that cover the board for the PacMan to eat scoring X point per dot. When all
  the dots are eaten the game is over and the total score should be displayed on the screen.
  • Add randomly placed and occurring power ups for the PacMan
  • When the PacMan eats a power up, he can eat the PacMan for Y seconds and score Z points for
  the first ghost eaten in each power up event, Z points for the first ghost eaten in each power up
  event, 2*Z points for the second ghost eaten in each power up event, 4*Z points for the third
  ghost eaten in each power up event, 8*Z points for the fourth ghost eaten in each power up
  event.
  • When not in a power up event, the ghosts should try to catch and kill the PacMan. When in a
  power up event the ghosts should flee from the PacMan.
  • The PacMan should have W lives which when used up end the game. All eaten dots should
  remain eaten until the game restarts.
  • The values of W,X,Y and Z should be public variables in scripts attached to the PacMan.
  Note that it is not necessary to animate fine details of the PacMan game like the directions the eyes
  looks or animating the eyes after the ghost is eaten. The AI algorithms for the movement and attacking
  behavior of the ghosts will be the most important part of grade of the assignment. The next most
  important feature is scoring. Of course it is assumed that the PacMan moves properly and cannot move
  through walls. This is a two module assignment. Do as much as you can for this Module 6 and
  complete the assignment for module 7. The total project will be worth 100 points and the score divided
  evenly between the two assignments.
  
Assignment 6:
  Building on the animations and collision responses develop for the PacMan game developed in
  Assignment 4 and Assignment 5, add the following to make a realistic simulation of a PacMan game:
  • A maze similar to the standard PacMan game
  • Evenly space dots that cover the board for the PacMan to eat scoring X point per dot. When all
  the dots are eaten the game is over and the total score should be displayed on the screen.
  • Add randomly placed and occurring power ups for the PacMan
  • When the PacMan eats a power up, he can eat the PacMan for Y seconds and score Z points for
  the first ghost eaten in each power up event, Z points for the first ghost eaten in each power up
  event, 2*Z points for the second ghost eaten in each power up event, 4*Z points for the third
  ghost eaten in each power up event, 8*Z points for the fourth ghost eaten in each power up
  event.
  • When not in a power up event, the ghosts should try to catch and kill the PacMan. When in a
  power up event the ghosts should flee from the PacMan.
  • The PacMan should have W lives which when used up end the game. All eaten dots should
  remain eaten until the game restarts.
  • The values of W,X,Y and Z should be public variables in scripts attached to the PacMan.
  Note that it is not necessary to animate fine details of the PacMan game like the directions the eyes
  looks or animating the eyes after the ghost is eaten. The AI algorithms for the movement and attacking
  behavior of the ghosts will be the most important part of grade of the assignment. The next most
  important feature is scoring. Of course it is assumed that the PacMan moves properly and cannot move
  through walls. This is a two module assignment. Do as much as you can for this Module 6 and
  complete the assignment for module 7. The total project will be worth 100 points and the score divided
  evenly between the two assignments.
