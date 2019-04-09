/* For making Unity Menus, we always look for active classes to place our menus in.
   To make it easy, there is a method which adds a button on screen, if it displays with the Class Name, it means that class is active
   Due to functioning of the main Menu, there was a need for 2 DLLs, one for Old Games and one for Newer ones.
   Games with less UnityEngine dlls, and the size of UnityEngine.dll is big, then its old. Games with lots of Unity DLLs of small sizes and a UnityEngine.CoreModule.dll are usually new.
   Refer to the YT Video 
*/

public static void TestClass(string ClassName)
{
    /* Call this in an OnGUI() function to test if a class is active
    ClassName - name of class for easy identification. this.GetType().Name can be passed to it if you don't wanna type full class name
    Example Usage:
    TheArmKing.MainScript.TestClass(this.GetType().Name);
    TheArmKing.MainScript.TestClass("Whatever You Want");
    */
}


/* You should know how to use DnSpy for this.
   You can look at how to use the menu by reading ButtonInfo.cs and CodeDeclaration.cs files
   For DnSpy to be able to compile the code, you need to add a reference to the DLL, use the reference DLL for this
   A brief explanation of each of the Unity Methods we use:
   Start() - is used to run code once, good for Declaration.
   OnGUI() - Unity's special method which runs multiple times per frame and is used to draw menus. We use this for Drawing Menu and testing active classes
   Update() - method which runs once per frame - used for animations like menu popping up etc. Also used for partial PC Support
*/

IMPORTANT!!
/* How to Actually apply and use the menu
   For Testing - use the TestClass() function, add reference to PMTMenu to compile DLL.
   Then take reference DLL and place it in the Managed Folder, rebuild APK and test.

   For Applying Menu - Put the Declaration code in the active class, refer to CodeDeclaration.cs, ButtonInfo.cs and Samples for examples.
   Add reference to PMTMenu, save and compile DLL in DnSpy.
   Games with UnityEngine.CoreModule.dll are usually new. You'll have to try both DLLs
   Copy the AssetBundles folder to the /assets folder in the decompiled APK, this contains our fonts, menu wont show up without this.
   Finally, rebuild APK and Enjoy!
*/
