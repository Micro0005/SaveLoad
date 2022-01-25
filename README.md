SaveLoad is a .NET library for C# that allows users to save and load values. Like save files in video games. Note that this library is for .NET 4.8.

[USAGE]

using SaveLoad;

//...

SaveLoad.SaveLoad example = new SaveLoad.SaveLoad(); //Make sure this is at the top

//...

example.SetValue(Directory, Key, Value);
example.GetValue(Directory, Key);
example.KeyExists(Directory, Key);
