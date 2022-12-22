# Assignment

Create a markless AR application that will allow the user to drop a 3D sphere model that would bounce off the real world horizontal surface

## Requirements
 - Unity 2020.3.42f1
 - AR Foundation 4.1.13
 - ARKit/ARCore XR Plugin 4.1.13

## Scene 1: Drop a 3D sphere that bounces on the horizontal plane 
 - Move the phone around to scan the surrounding for flat surfaces to generate the AR horizontal plane
 - Once the plane is generated, a target indicator will appear on the plane
 - By aiming the target indicator at the desired generated AR plane and tapping on the screen, a 3D sphere will be created and dropped on the position of the target indicator
 - While the 3D sphere is being dropped, the material color of the generated AR plane will then be changed to clear color to give the user a feel of the 3D sphere bouncing on the real world surface
 
![](https://github.com/zettw/Assignment-ER/blob/main/Media/1.GIF)

 - Move the phone to shift the target indicator around the plane and tap the screen to create more 3D sphere
 
 ![](https://github.com/zettw/Assignment-ER/blob/main/Media/7.GIF)

## Scene 2: Mini Game - Marble Soccer
 - Based the 3D sphere dropping concept from scene 1, extra features were added to create a mini game 
 - By aiming the target indicator on the desired AR generated plane and tapping on the screen, a soccer ball, goal post & goal keeper will be created on the plane
 - After the necessary 3D models has been loaded on the generated AR plane, the plane indicator then changed to a crosshair for shooting colored marbles
 - At the start of the game, 10 marbles will be assigned to the user
 - The top left of the screen shows the list of marbles in their order and colors (red, green & blue)
 - The white triangle pointer tells the user the current color of the marble to be shot out
 
![](https://github.com/zettw/Assignment-ER/blob/main/Media/2.GIF)

 - Aim the crosshair on the soccer and tap the on the screen, a marble will be shot out from the center of the screen
 - When being shot at, the soccer ball color will be changed and copy the color of the marble that hits it
  - The goal keeper will move left and right constantly
  - When the marble hits the soccer ball, both the marble and soccer ball will be destroyed after 1.5 seconds 
  - A new soccer ball is then loaded and randomly dropped at a position near the goal post
  
![](https://github.com/zettw/Assignment-ER/blob/main/Media/3.GIF)

 - The color of the goal post will change randomly (red, green & blue) every second
 - Objective of the game is to get the same colored soccer ball into the same colored goal post 
 - Mismatch soccer ball and goal post color minus a point from the score
 
![](https://github.com/zettw/Assignment-ER/blob/main/Media/4.GIF)

 - Matching soccer ball and goal post color adds a point to the score
 
![](https://github.com/zettw/Assignment-ER/blob/main/Media/5.GIF)

 - Tap on the "Retry" button to regenerate the random colored marbles and set the score back to zero
 
![](https://github.com/zettw/Assignment-ER/blob/main/Media/6.GIF)

 - The size of the 3D model scales according to the size of the selected AR plane
 
 ![](https://github.com/zettw/Assignmen-ER/blob/main/Media/8.GIF)




