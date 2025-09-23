using System.Text.RegularExpressions;

namespace src;

public class Validator
{

    public Validator()
    {
        
    }

    public bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^(?=.{1,254}$)(?=.{1,64}@)[A-Za-z0-9._%+\-]+@[A-Za-z0-9.\-]+\.[A-Za-z]{2,}$", RegexOptions.IgnoreCase);
    }

    public bool IsValidNumber(string phoneNumber)
    {
        if (Regex.IsMatch(phoneNumber, @"^[1-9]{1}[0-9]{2}[0-9]{3}[0-9]{4}$"))
        {
            return true;
        }
        
        if (Regex.IsMatch(phoneNumber, @"^[1-9]{1}[0-9]{2}-[0-9]{3}-[0-9]{4}$"))
        {
            return true;
        }

        return false;
    }
    
}