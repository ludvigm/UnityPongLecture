# UnityPongLecture

##Getting started
  1. Clone this repo to your computer.
  2. Open unity, do not create a new project but select "open project".
  3. Browse to the the repo you just cloned and open it.

You will now have a non-complete Pong game in front of you. The two "bricks" to the left and right are the players, and the circle in the middle is suprisingly enough the ball. If you have never played/seen a pong game before i recommend you look it up real quick before moving on.

Now to the fun part, completing the Pong game. First of all, there is some things that you should not worry about.
1. There are four invisible walls around the screen. We dont need to worry about them right now, just know that they make the ball bounce back onto the field.
2. The ball. Everything regarding the ball is complete except for one small thing that i will present shortly.


##The problems to solve
###The ball does not bounce.
  This issue could be solved in a number of ways. If you like a challenge you can modify the "BallControl" script to change direction on when colliding with walls. For the easy way; Create a "Physics2D Material". This material should be applied to the ball, remember that the material has two fields you can change, set these to values you find appropriate.
  
>! Spoiler in here

<spoiler>Hello</spoiler>

### Other
