/* You can control fontsizes if they are too big for the following - 
   Title
   Buttons - Name,Description
   InputField - the Text on the input field
   NumberBox - the text displayed by the number box
   Refer to Images/Buttons or Images/Others/LayoutExplanation for better understanding
*/
public class FontSettings { // These multipliers control text sizes
    public static float titleFontMultiplier = 1f;
    public static float buttonFontMultiplier = 1f;
    public static float descriptionFontMultiplier = 1f;
    public static float inputFieldFontMultiplier = 1f;
    public static float numberBoxFontMultiplier = 1f;
}

// Examples - 
TheArmKing.FontSettings.titleFontMultiplier = 0.9f // If i want to make it small, 0.9f is preferable
TheArmKing.buttonFontMultiplier = 1.1f // If i want to make it big, 1.1f is preferable
// If you don't declare them its alright! they are always set to 1f by default.
