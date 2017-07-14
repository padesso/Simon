function resetTimer()
{
   if($TIMER)
   {
      baseImage.setTimerOn($TIMEOUT);  
   }
}

function t2dSceneObject::onTimer(%this)
{
   if($DEBUG)
   {
      echo("Time's up!!!");  
   }
   
   loseGame();
}
   