# UnityPongLecture

##Getting started
  1. Clone this repo to your computer.
  2. Open unity, do not create a new project but select "open project".
  3. Browse to the the repo you just cloned and open it.

You will now have a non-complete Pong game in front of you. The two "bricks" to the left and right are the players, and the circle in the middle is suprisingly enough the ball. If you have never played/seen a pong game before i recommend you look it up real quick before moving on.

Now to the fun part, completing the Pong game. First of all, there is some things that you should not worry about changing.
1. There are four invisible walls around the screen. We dont need to worry about them right now, just know that they make the ball bounce back onto the field.
2. The ball. Everything regarding the ball is complete except for one small thing that i will present shortly.
3. The GameSetup script. It simply places the walls and players according to the size of your Game window at the start of the game.
With this said, feel free to inspect every part of the game and try to understand it!

##The problems to solve

First of all run the game and try to see what works and what doesnt. The end product we are looking for is to have two players, one moving by W+S and the other by upArrow+downArrow. We want the ball to be bouncing off players, and the top and bottom wall. The left and right walls should be "goals" and upon the ball touching one of them the opposite player should be given a score. Thats it! I will write some guidelines below to help you out.

### The ball does not bounce.
  This issue could be solved in a number of ways. If you like a challenge you can modify the "BallControl" script to change direction of the ball when colliding with walls. For the easy way; Create a "Physics2D Material". This material should be applied to the ball, remember that the material has two fields you can change, set these to values you find appropriate.
  
### Player2 cant move.
As you may have noticed player1 moves by the arrows, but W and S does not move player 2. Inspect the player2 game object and compare it to player1. 
Note: Public variables in a script is modifiable straight from the unity inspector.

### Keeping Scores
Another thing you probably noticed is the two Zero's in the top side of the game screen. They are obviously for keeping score, but when the ball collides with the left/right wall it just bounces off and scores are not modified.
To make the walls react to the ball touching them, you could use either a trigger or a collider. In this case we will make use of the trigger. Take a look at the leftWall and rightWall objects, as you can see there is a script attached to them, "SideWalls". Open up the script and take a look.

For the OnTriggerEnter2D method to ever be called the object needs to be a trigger, this is easily modifiable when inspecting the objects.

If you have successfully made the trigger work the ball should dissapear when colliding with the left or right wall and be placed in the middle again. Also the console will print something to help you know when the trigger method is called. However, the score counters on the screen does not seem to be incrementing. Inspect the code related to scoring and try to solve this.
Hint: check what calls are made in the onTrigger method.


That was all! I hope you enjoyed the tutorial. If you want ask Ludvig any questions you may have about the code or unity. Thank you for participating.
