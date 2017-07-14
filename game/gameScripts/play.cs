///////////////////
//   TODO LIST   //
///////////////////
// Refine images in end game GUI
// Refine Credits GUI
// Refine images in Title screen GUI
// Finalize win condition
// Clean up renders
// Create random patterns based on system time per round
// Wishlist - Add particle effect on mouse location at level victory
// Wishlist - Incorporate SQL backend to post scores

//Global variables
$VOLUME = 1;                         //Master volume level
$MAXGAMELENGTH = 100;                  //Number of rounds in game
$TIMEOUT = 3000;                       //Time limit in ms player has to respond

$DEBUG = false;                         //Disables enables console info and enables splash screen
$SOUND = true;                         //Toggle sounds effects
$ANIMATION = true;                     //Toggle the animations
$TIMER = true;                         //Toggle the timer

$CLICKS = 0;                           //Count user clicks 
$PLAYING = false;                      //Turns on the game
$BUSY = true;                          //Makes it Simon's turn (blocks player input)

$SIMONPATTERN = new_scriptArray("");   //Create array for Simon round sequences

///////////////////////////

function startSimon()
{  
   $ROUND = 1;
   
   Canvas.setContent(mainScreenGui);
    
   $PLAYING = true;                       //Turn the game on
   $BUSY = true;                          //This makes it Simon's turn 
   
   reset();
}

function reset()
{
   $PLAYSPEED = 375;                      //Time in ms between Simon flashes
   
   createSimonPattern($MAXGAMELENGTH);    //Create the game sequence
   
   $BUSY = true;                          //Make sure it's still Simon's turn
   
   showBaseImage();                       //Make the lights off image visible
   
   $ROUND = 1;
   
   if($DEBUG)
   {   
      echo("Reseting");      
   }

   //playSE("reset", $VOLUME); 
      
   playRound($ROUND);
}

function playRound(%roundNumber)
{
   setPlaySpeed();       
   
   $CLICKS = 0;
   
   if($DEBUG)
   {
      echo("Round ",$ROUND, " has begun.");
      echo("Current pattern: ");
      for(%i = 0; %i < $ROUND; %i++)
      {
         %tempPattern = $SIMONPATTERN.get(%i);
         echo(%tempPattern);
      }
      echo("Waiting for player input..."); 
   }
   
   $BUSY = true;
   
   playSimonAnimation(0);
}

function setPlaySpeed()
{
   $PLAYSPEED = $PLAYSPEED - 20;
   
   if($PLAYSPEED < 50)
   {
      $PLAYSPEED = 50;
   }
}

function createSimonPattern(%gameLength)
{
   for(%i = 0; %i < $MAXGAMELENGTH; %i++)
   {
      //TODO - seed randomization based on time?
      $SIMONPATTERN.append(getRandom(1,4)); 
   }
   
   if($DEBUG)
   { 
      echo("Simon pattern created.");
      //echo("Simon values [index value]:");
      //$SIMONPATTERN.dumpValues();
   }
}

function checkResponse(%clicked)
{   
   if($SIMONPATTERN.get($CLICKS - 1) != %clicked)
   {
      schedule(250, 0, "loseGame");
   }
   else if($CLICKS == $ROUND)
   {
      schedule(250, 0, "winRound");
   }      
}

function winRound()
{
   if($DEBUG)
   {
        echo("\n You won round ", $ROUND, "\n");
   }
   
   baseImage.setTimerOff();   
   
   if ($ROUND == $MAXGAMELENGTH) 
   {  
      winGame();
   }
   
   $ROUND++;
   
   playRound($ROUND);
}

function winGame()
{
     if($DEBUG)
     {
         echo("\n You won the game!!!");
     }
     
     baseImage.setTimeroff();
     Canvas.pushDialog(EndGameGui);
  
     //Wishlist - Post score to a server
}

function loseGame()
{
   playSE(lost,$VOLUME);
   baseImage.setTimerOff();
   
   if($DEBUG)
   {   
      echo("\nLoser\n");
   }
   
   //Prompt user to play again  
   Canvas.pushDialog(EndGameGui);
}