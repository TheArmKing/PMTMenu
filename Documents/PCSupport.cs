/* The menu is made in Unity so it should work on PC Games (Windows/Linux/Mac)
    There is partial support, if the menu is run on PC, then an arrow appears next to buttons (refer to Menu Layout)
    the arrow helps in navgiation, you can set Keys for Opening/Closing the menu, moving up/down the menu and selecting hacks
    Keycodes can also be used to control +,- buttons of a NumberBox
    Each variable is an array, so you can use key combos, like Alt + Backspace to open menu
    if you only want to use 1 key, use the method TheArmKing.PCSupport.singleKey(keyCode);
    Refer to https://docs.unity3d.com/ScriptReference/KeyCode.html for all KeyCodes
*/
public class PCSupport {
	public static KeyCode[] PlusKey; // Keycode to Add
	public static KeyCode[] MinusKey; // Keycode to Subtract
	public static KeyCode[] OpenKey; // Keycode to Open/Close Menu
	public static KeyCode[] UpKey; // Keycode to Move up
	public static KeyCode[] DownKey; // Keycode to Move down
	public static KeyCode[] SelectKey; // Keycode to select hack
}

// Examples - 
TheArmKing.PCSupport.PlusKey = TheArmKing.PCSupport.singleKey(KeyCode.Plus);
TheArmKing.PCSupport.MinusKey = TheArmKing.PCSupport.singleKey(KeyCode.Minus);
TheArmKing.PCSupport.OpenKey = new KeyCode[] { KeyCode.LeftAlt, KeyCode.Backspace };
TheArmKing.PCSupport.UpKey = TheArmKing.PCSupport.singleKey(KeyCode.UpArrow);
TheArmKing.PCSupport.DownKey = TheArmKing.PCSupport.singleKey(KeyCode.DownArrow);
TheArmKing.PCSupport.UpKey = TheArmKing.PCSupport.singleKey(KeyCode.UpArrow);
TheArmKing.PCSupport.SelectKey = TheArmKing.PCSupport.singleKey(KeyCode.Return);


/* ASSET BUNDLES - DIFFERENT LOCATION FOR PC!
Not sure about Windows, but make a new Folder called 'StreamingAssets' in Resources/Data, Paste the AssetBundles folder in it
*/