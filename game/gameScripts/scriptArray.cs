////////////////////////////////////////////////////
//
// scriptArray.cs
//
// a script-only implementation of one-dimensional arrays which keep track of their members
// this is a very primitive array: the keys must be contiguous integers, starting at 0.
// o. elenzil 20080218
//
// usage:
//
// creation:
// %array = new_ScriptArray("");
// new_ScriptArray(someName);
//
// adding elements:
// %array.append(something);
// %array.set(index, something);
//
// retrieving elements:
// %array.get(%index);
//
// retrieving number of elements in the array:
// %array.size();
//
// dumping everything in the array:
// %array.dumpValues();


function new_ScriptArray(%name)
{
   %obj = new ScriptObject("ScriptArray");
   %obj.numElements = 0;
   %obj.setName(%name);
   return %obj;
}

function ScriptArray::append(%this, %value)
{
   %this.array[%this.numElements] = %value;
   %this.numElements++;
}

function ScriptArray::get(%this, %index)
{
   if (%index < 0 || %index >= %this.numElements)
   {
      error("ScriptArray::get()" SPC "- Subscript out of range:" SPC %index);
      return "";
   }
   
   return %this.array[%index];
}

function ScriptArray::set(%this, %index, %value)
{
   // note this allows you to go beyond the end of the array by one.
   if (%index > %this.numElements)
   {
      error("ScriptArray::set()" SPC "- Subscript out of range:" SPC %index SPC "value:" SPC %value);
      return;
   }

   if (%index == %this.numElements)   
      %this.append(%value);
   else
      %this.array[%index] = %value;
}

function ScriptArray::size(%this)
{
   return %this.numElements;
}

function ScriptArray::dumpValues(%this)
{
   for (%n = 0; %n < %this.numElements; %n++)
   {
      echo(%n SPC %this.get(%n));
   }
}

//PWA
function ScriptArray::isEqualTo(%this, %b)
{
   if (%this.numElements == %b.numElements)
   {
      for (%n = 0; %n < %this.numElements; %n++)
      {
         if(%this.get(%n) != %b.get(%n))
         {
            echo("Arrays are not equal. ", %this, " , ", %b);
            return false;
         }
      }   
      return true;
   }
   return false;
}
