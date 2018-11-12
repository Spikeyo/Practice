//*************************************************************
//
// Solution for the RotationalCipher exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System;
using System.Linq;

public static class RotationalCipher
{
    public static string RotateString(string text, int shiftKey)
    {
        if (text == null) throw new ArgumentNullException();

        var encryptedChars = text.Select(x => RotateChar(x, shiftKey));
        
        return new string(encryptedChars.ToArray());
    }
   
    public static char RotateChar(char target, int shiftKey)
    {
        //Can't use char.IsUpper/IsLower/IsLetter because it includes special letters
        //If target is upper case letter
        if (target >= 65 && target <= 90)
            return (char) ((target + shiftKey - 65) % 26 + 65);
        //If target is lower case letter
        if (target >= 97 && target <= 122)
            return (char) ((target + shiftKey - 97) % 26 + 97); 
        return target;
    }
}