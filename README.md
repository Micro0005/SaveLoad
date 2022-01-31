# Usage
using SaveLoad;

//...

SaveLoad.SaveLoad example = new SaveLoad.SaveLoad(); //Make sure this is at the top

//...

example.SetValue(Directory, Key, Value);

example.GetValue(Directory, Key);

if (example.KeyExists(Directory, Key))
{
}
