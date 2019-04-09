/* For Clean Code Samples with Images (no comments like these) refer to Samples
   Declaration is very simple, you don't have to worry about sizing. It really just consists of 
   3 Main Methods to be called - NECESSARY!
   4 Variables to specify - NECESSARY!
   Adding Buttons - Varies per mod!
   PC Support (Optional)
   FontSettings (Optional)
*/

// Other declarations
public static string gameTitle; // Title of the game you are hacking (for info popup at Start Screen)
public static string modder; // Your name for credits (for info popup at Start Screen, Bottom right corner of the screen at all times)
public static string mTitle; // Title or text that should be displayed in menu top (Also the part used to drag the menu)
public static Theme MenuTheme; // Default Theme of the menu you like. choose from -
public enum Theme
{
    Red,
    Blue,
    Purple,
    Pink,
    Green,
    Orange,
    Yellow,
    Black,
    Brown,
    Grey,
    White,
}; // All the pictures are attached in Images/MenuThemes

// Button declarations - refer to Documents/ButtonInfo.cs

// Main Code Declaration!
void OnGUI(){ // Code to put in OnGUI() method, make one if its not there
  TheArmKing.MainScript.DrawMenu();
}

void Update(){ // Code to put in Update() method, make one if its not there
  TheArmKing.MainScript.UpdateFunc();
}

void Start(){ // Code to put in Start() method, make one if its not there
    TheArmKing.MainScript.PreInit(); // Pre-Initialization Function! SHOULD BE PLACED FIRST!
    TheArmKing.gameTitle = "YourGameName"; // Other Declaration
    TheArmKing.modder = "YourName";
    TheArmKing.mTitle = "PLATINMODS.COM";
    TheArmKing.MenuTheme = TheArmKing.Theme.Blue; // Default Theme
    TheArmKing.AddButtons.Normal("NormalButton1", "ButtonDescription"); // Button Declaration - Refer to ButtonInfo.cs
    TheArmKing.AddButtons.TextInput("TextInput1", "ButtonDescription", "DefaultText", 5, null, false, true); // String Text-Input with 5 character limit
    TheArmKing.AddButtons.NumberBox("NumBox1", "ButtonDescription", 0f, 1000, 100, 100, false, true); // Numbox that increase by 100, with Minimum 0, Maximum 1000 and default 100
    TheArmKing.AddButtons.NumberBox("Numbox2", "ButtonDescription", 0f, 2000000, 200000, 100000, false, true); // Numbox that increase by 100,000 with Minimum 0, Maximum 2,000,000 and default 200,000
    TheArmKing.AddButtons.TextInput("TextInput2", "ButtonDescription", "Default Text", 7, new string[] { "[^0-9]" }, false, true); // String Text-Input with 7 character limit that only accepts integers
    TheArmKing.AddButtons.Normal("NormalButton2", "ButtonDescription");
    base.StartCoroutine(TheArmKing.MainScript.LoadFonts()); // Loading Fonts Function! SHOULD BE PLACED SECOND LAST!
    TheArmKing.MainScript.MainInit(); // Main Initialization Function! SHOULD BE PLACED LAST!
}

// Clean Code
void OnGUI(){
  TheArmKing.MainScript.DrawMenu();
}

void Update(){
  TheArmKing.MainScript.UpdateFunc();
}

void Start(){ 
    TheArmKing.MainScript.PreInit(); 
    TheArmKing.gameTitle = "YourGameName"; 
    TheArmKing.modder = "YourName";
    TheArmKing.mTitle = "PLATINMODS.COM";
    TheArmKing.MenuTheme = TheArmKing.Theme.Blue; 
    TheArmKing.AddButtons.Normal("NormalButton1", "ButtonDescription"); 
    TheArmKing.AddButtons.TextInput("TextInput1", "ButtonDescription", "DefaultText", 5, null, false, true); 
    TheArmKing.AddButtons.NumberBox("NumBox1", "ButtonDescription", 0f, 1000, 100, 100, false, true); 
    TheArmKing.AddButtons.NumberBox("Numbox2", "ButtonDescription", 0f, 2000000, 200000, 100000, false, true); 
    TheArmKing.AddButtons.TextInput("TextInput2", "ButtonDescription", "Default Text", 7, new string[] { "[^0-9]" }, false, true); 
    TheArmKing.AddButtons.Normal("NormalButton2", "ButtonDescription");
    base.StartCoroutine(TheArmKing.MainScript.LoadFonts()); 
    TheArmKing.MainScript.MainInit(); 
}

// For Testing
void OnGUI(){
  TheArmKing.MainScript.TestClass(this.GetType().Name);
}
