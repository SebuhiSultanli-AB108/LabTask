namespace Extension.Models;

public static class ExtensionClass
{
    public static bool IsOdd(this int num)
    {
        if (num % 2 == 0) return false;
        else return true;
    }

    public static bool IsEven(this int num)
    {
        if (num % 2 == 1) return false;
        else return true;
    }

    public static bool HasDigit(this string text)
    {
        string digits = "1234567890";
        foreach (char c in text)
        {
            if (digits.Contains(c)) return true;
        }
        return false;
    }

    public static bool CheckPassword(this string password)
    {
        bool hasLower = false;
        bool hasUpper = false;
        if (password.HasDigit())
        {
            foreach (char c in password)
            {
                if (c <= 90 && c >= 65) hasUpper = true;
                if (c <= 122 && c >= 97) hasLower = true;
                if (hasLower && hasUpper) return true;
            }
        }
        return false;
    }

    public static string Capitalize(this string text)
    {
        string newText = string.Empty;
        foreach (char character in text)
        {
            char c = character;
            if (c <= 122 && c >= 97) c -= (char)32;
            newText += c;
        }
        return newText;
    }
}
