function buttonClass::onMouseDown(%this, %modifier, %pos, %clicks)
{
   $CLICKS++;    
    
   if($PLAYING == true && $BUSY== false)
   {   
      if(%pos.x < 0 && %pos.y < 0)
      {
         clickButton(1);
      }
      if(%pos.x > 0 && %pos.y < 0)
      {
         clickButton(2);
      }
      if(%pos.x < 0 && %pos.y > 0)
      {
         clickButton(3);
      }
      if(%pos.x > 0 && %pos.y > 0)
      {
         clickButton(4);
      }        
   }      
}

function buttonClass::onMouseUp(%this, %modifier, %pos, %clicks)
{    
   if($PLAYING)
   { 
      schedule(100,0,showBaseImage);
   }
   
   if($SOUND)
   {
      alxStop($se);   
   }
}

function clickButton(%color)
{
   resetTimer();
   
   %tempColor = %color;
   
   if($DEBUG)
   {
      echo("clickButton was executed for color: ",%tempColor);
   }
   
   if(%tempColor == 1) 
   { 
      playSE(green, $VOLUME);
   }
   else if(%tempColor == 2) 
   { 
      playSE(red, $VOLUME);
   }
   else if(%tempColor == 3) 
   { 
      playSE(yellow, $VOLUME);
   }
   else if(%tempColor == 4) 
   { 
      playSE(blue, $VOLUME);
   }
   
   playAnim(%tempColor);
  
   checkResponse(%tempColor);
}