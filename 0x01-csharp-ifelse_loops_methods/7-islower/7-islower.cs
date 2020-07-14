public class Character
{
    public static bool IsLower(char c)
    {
        if ((int)c >= (int)'a' && ((int)c <= (int)'z'))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}