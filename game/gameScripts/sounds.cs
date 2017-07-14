// sound effects

// http://en.wikipedia.org/wiki/Simon_(game)
// http://www.phy.mtu.edu/~suits/notefreqs.html
// Tones were generated using NCH Tone Generator
// Simon's tones were designed to always be harmonic, no matter what order they were played in, and consisted of:
//* A3 220.00 Hz (red, upper right);
//* A4 440.00 (green, upper left, an octave higher than the upper right);
//* D3 146.83 (blue, lower right, a perfect fourth higher than the upper right);
//* G3 196.00 (yellow, lower left, a perfect fourth higher than the lower right).

new AudioDescription(SE)
{
   volume   = 1.0;
   isLooping = false;
   isStreaming = false;
   is3D     = false;
   type     = $GuiAudioType;
};

function getAudio(%name, %type)
{
   if (isObject(%name))
      return;
   
   new AudioProfile(%name)
   {
      filename = "~/data/audio/" @ %name @ ".wav";
      description = %type;
      preload = false;
   };
}

function playSE(%sound, %volume)
{
   // get profile for sound effect
   getAudio(%sound, "SE");    
   
   if($SOUND)
   {
      // play sound
      SE.volume = %volume;
      $se = alxPlay(%sound);
   }
   
   if($DEBUG)
   {
      echo("Audio for: " @ %sound @ " played.");
   }
}