// Button Description - (Refer to Images/Buttons to see how these look)
// Normal Buttons are simple buttons which can switch on/off and have a hack description 
// TextInput Buttons have a TextField in it for custom user input, the output is string, can be parsed by modder to their wish. The input can be controlled via Regex, limited to certain length. 
// NumberBox Buttons have a + and - box which control a numerical value for custom user Input. the custom input is always a double value and can be converted by Modder 

// Adding Buttons - Class AddButtons

public class AddButtons{
    public static void Normal(string hackName, string hackDescription)
    {
        /* hackName - Text on the button
           hackDescription - Description of the hack user can access by long pressing button */
    }

    public static void TextInput(string hackName, string hackDescription, string defaultText, int inputLimit, string[] regexs, bool wordWrap, bool clipText)
    {
      /* hackName - Text on the button
         hackDescription - Description of the hack user can access by long pressing button
         defaultText - Text showed in InputField when it is empty
         inputLimit - the lenght of characters a user can input
         regexs - An Array of regexs used to control input of the InputField
                  the regexs should contain of whats not valid!
                  Example - "[^0-9]" --> This regex is used to make the InputField accept integers only. ^ means NOT, so anything thats not 0-9 will be deleted.
         wordWrap - should the text wrap if it exceeds the button?
         clipText - should the text move out of button in case its too long?
         NOTE - Best settings is wordWrap false and clipText true */
    }

    public static void NumberBox(string hackName, string hackDescription, double min, double max, double dfaultVal, double increaseValue, bool wordWrap, bool clipText)
    {
      /* hackName - Text on the button
         hackDescription - Description of the hack user can access by long pressing button
         min - the minimum value the NumberBox should hold
         max - the maximum value the NumberBox should hold
         dfaultVal - default/starting value of the NumberBox
         increaseValue - the numberical value by which the NumberBox should increase/decrease with each +,- click. Example - 10000, 100000 etc.
         wordWrap - should the NumberBox wrap if it exceeds the button?
         clipText - should the NumberBox move out of button in case its too long?
         NOTE - Best settings is wordWrap false and clipText true */

    }
}

// Getting Values from buttons - Class SwitchVals
public class SwitchVals{
    public static bool GetHackOn(int buttonIndex)
    {
        /* returns a boolean telling if the button is Switched On or Off
           buttonIndex - number of the button, same as the in the order it was declared
           Example Usage:
            if(TheArmKing.SwitchVals.GetHackOn(2)){
            // Your hack code here!
          }
        */
    }

    public static void SetHackState(int buttonIndex, bool on)
    {
        /* Turns a button on/off
           buttonIndex - number of the button, same as the in the order it was declared
           on - if you need to turn it on, pass it as true, or false if you want to turn the button off.
           Example Usage:
           TheArmKing.SwitchVals.SetHackState(2,true); - to turn on
           TheArmKing.SwitchVals.SetHackState(2,false); - to turn off
        */
    }

    public static void ToggleHackState(int buttonIndex)
    {
        /* Toggles the state of a button, if it was off, it will be turned on, if it was on it will be tunred off!
           buttonIndex - number of the button, same as the in the order it was declared
           Example Usage:
           TheArmKing.SwitchVals.ToggleHackState(2);
        */
    }

    public static string GetInputText(int buttonIndex)
    {
        /* Gets the value of the custom input field of a button as a string.
           buttonIndex - number of the button, same as the in the order it was declared
           Example Usage:
           string s = TheArmKing.SwitchVals.GetInputText(2);

           To Convert this to integer for example, you could do this:
           int num = 0;
           int.TryParse(TheArmKing.SwitchVals.GetInputText(2),out num); - if the string is a valid integer, the value will be copied to the integer 'num'
        */
    }
    public static double GetNumBoxValue(int buttonIndex)
    {
       /* Gets the value of a NumberBox of a button as a double.
          buttonIndex - number of the button, same as the in the order it was declared
          Example Usage:
          double d  = TheArmKing.SwitchVals.GetNumBoxValue(2);

          To convert it to int/float, you could do this:
          int i = (int)TheArmKing.SwitchVals.GetNumBoxValue(2);
          float f = (float)TheArmKing.SwitchVals.GetNumBoxValue(2);
       */
   }
}
