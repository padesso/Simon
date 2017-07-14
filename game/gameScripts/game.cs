//---------------------------------------------------------------------------------------------
// Torque Game Builder
// Copyright (C) GarageGames.com, Inc.
//---------------------------------------------------------------------------------------------

//---------------------------------------------------------------------------------------------
// startGame
// All game logic should be set up here. This will be called by the level builder when you
// select "Run Game" or by the startup process of your game to load the first level.
//---------------------------------------------------------------------------------------------
function startGame(%level)
{     
   Canvas.setContent(mainScreenGui);
   Canvas.setCursor(DefaultCursor);
   
   new ActionMap(moveMap);   
   moveMap.push();
   
   $enableDirectInput = true;
   activateDirectInput();
   //enableJoystick();
   
   sceneWindow2D.loadLevel(%level); 
   
   //disable the intro animation to prevent a false start in the onAnimationEnd callback
   IntroAnimation.enabled = false;
   showTitleScreen();
}

//---------------------------------------------------------------------------------------------
// endGame
// Game cleanup should be done here.
//---------------------------------------------------------------------------------------------

function showTitleScreen()
{
   Canvas.popDialog(EndGameGui);
   Canvas.setContent(mainScreenGui);
   Canvas.pushDialog(TitleScreenGui);  
}   
   
function endGame()
{
   sceneWindow2D.endLevel();
   moveMap.pop();
   moveMap.delete();
}