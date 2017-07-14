//---------------------------------------------------------------------------------------------
// Torque Game Builder
// Copyright (C) GarageGames.com, Inc.
//---------------------------------------------------------------------------------------------

//---------------------------------------------------------------------------------------------
// initializeProject
// Perform game initialization here.
//---------------------------------------------------------------------------------------------
function initializeProject()
{
   // Load up the in game gui.
   exec("~/gui/TitleScreenGui.gui");
   exec("~/gui/mainScreen.gui");
   exec("~/gui/splashScreen.gui");
   exec("~/gui/EndGameGui.gui");
   exec("~/gui/CreditsGui.gui");

   // Exec game scripts.
   exec("./gameScripts/game.cs");
   
   //PWA
   exec("./gameScripts/scriptArray.cs");
   exec("./gameScripts/animation.cs");
   exec("./gameScripts/sounds.cs");
   exec("./gameScripts/input.cs");
   exec("./gameScripts/timer.cs");
   exec("./gameScripts/play.cs");
   
   // This is where the game starts. Right now, we are just starting the first level. You will
   // want to expand this to load up a splash screen followed by a main menu depending on the
   // specific needs of your game. Most likely, a menu button will start the actual game, which
   // is where startGame should be called from.
   //startGame( expandFilename($Game::DefaultScene) );   
   
   if(!$DEBUG)
   {
      loadSplash();
   }
   else
   {      
      startGame( expandFilename($Game::DefaultScene) );   
      showTitleScreen();
   }      
}

function loadSplash()
{
   canvas.setContent(splashScreen);
   schedule(100,0,checkSplash);
}

function checkSplash()
{
   if (splashScreen.done)
   {
      startGame( expandFilename($Game::DefaultScene) );
   }
   else
   {
      loadSplash();
   }
}

function showCredits()
{
   Canvas.setContent(CreditsGui);  
   schedule(100,0,checkCredits);
}

function checkCredits()
{
   if (CreditsGui.done)
   {
      Canvas.setContent(mainScreenGui);
      Canvas.pushDialog(TitleScreenGui);
   }
   else
   {
      showCredits();
   }
}

//---------------------------------------------------------------------------------------------
// shutdownProject
// Clean up your game objects here.
//---------------------------------------------------------------------------------------------
function shutdownProject()
{
   endGame();
}

//---------------------------------------------------------------------------------------------
// setupKeybinds
// Bind keys to actions here..
//---------------------------------------------------------------------------------------------
function setupKeybinds()
{
   new ActionMap(moveMap);
}
