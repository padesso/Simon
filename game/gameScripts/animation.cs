//Show the animation
function playIntroAnim()
{ 
   Canvas.popDialog(EndGameGui);
   Canvas.popDialog(TitleScreenGui);
   
   $PLAYING = false;
   
   if($ANIMATION)
   {
      if($DEBUG)
      {
         echo("Playing intro animation.");
      }
      
      IntroAnimation.enabled = true;
      IntroAnimation.setFrameChangeCallback(true);      
      IntroAnimation.setAnimationFrame(0);
      IntroAnimation.setVisible(true);
      IntroAnimation.playAnimation(linkImageAnimation, false, 0, false);
   }
   
   if(!$ANIMATION)
   {
      startSimon();
   }
}

function t2dAnimatedSprite::onFrameChange(%this)
{
   //Find current frame being played and fire sound
   %introPattern = linkImageAnimation.animationFrames;    
   %frameTemp = IntroAnimation.getAnimationFrame();
   %tempWord = getWord(%introPattern,%frameTemp);
   
   if(%tempWord == 1) 
   { 
      playSE(green, $VOLUME);
   }
   else if(%tempWord == 2) 
   { 
      playSE(red, $VOLUME);
   }
   else if(%tempWord == 3) 
   { 
      playSE(yellow, $VOLUME);
   }
   else if(%tempWord == 4) 
   { 
      playSE(blue, $VOLUME);
   }
}

function t2dAnimatedSprite::onAnimationEnd(%this)
{
   startSimon();
}

//Show lights out image
function showBaseImage()
{   
   introAnimation.setVisible(false);
   RedPress.setVisible(false);
   yellowPress.setVisible(false);
   BluePress.setVisible(false);
   GreenPress.setVisible(false);   
   baseImage.setVisible(true);
}

//Triggers for the lights
function playAnim(%color)
{
   %tempColor = %color;
   
   if($ANIMATION)
   {
      if(%tempColor == 1) //Green
      {
         RedPress.setVisible(false);
         yellowPress.setVisible(false);
         BluePress.setVisible(false);
         GreenPress.setVisible(true);
      }
      else if(%tempColor == 2) //Red
      {
         yellowPress.setVisible(false);
         BluePress.setVisible(false);
         GreenPress.setVisible(false); 
         RedPress.setVisible(true);
      }
      else if(%tempColor == 3) //Yellow
      {
         RedPress.setVisible(false);
         BluePress.setVisible(false);
         GreenPress.setVisible(false);
         yellowPress.setVisible(true);       
      }
      else if(%tempColor == 4) //Blue
      {
         RedPress.setVisible(false);
         yellowPress.setVisible(false);
         GreenPress.setVisible(false); 
         BluePress.setVisible(true);
      }    
      
      schedule($PLAYSPEED, 0, showBaseImage); 
   }
}

function playSimonAnimation(%start)
{   
   $BUSY = true;
   
   %index = %start;
   
   if(%index >= $ROUND)
   {
      schedule($PLAYSPEED, 0, showBaseImage);
      $BUSY = false;
      
      resetTimer();
      
      return;
   }
   else
   {
      %temp = $simonPattern.get(%index);
      
      schedule($PLAYSPEED, 0, playAnim, %temp);
      
      if(%temp == 1) 
      { 
         schedule($PLAYSPEED, 0, playSE, green, $VOLUME);
      }
      else if(%temp == 2) 
      { 
         schedule($PLAYSPEED, 0, playSE, red, $VOLUME);
      }
      else if(%temp == 3) 
      { 
         schedule($PLAYSPEED, 0, playSE, yellow, $VOLUME);
      }
      else if(%temp == 4) 
      { 
         schedule($PLAYSPEED, 0, playSE, blue, $VOLUME);
      }   
   
      %index++;
      
      schedule($PLAYSPEED * 2, 0, playSimonAnimation, %index);      
   }
}
