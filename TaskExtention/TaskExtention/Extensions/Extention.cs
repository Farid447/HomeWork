namespace TaskExtention.Extensions;

static class Extention
{
    public static bool IsOdd(this int num)
    {
        return num % 2 == 0;
    }

    public static bool IsEven(this int num)
    {
        return num % 2 == 0;
    }

    public static bool HasDigit(this string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 48 && str[i] < 58)
            {
                return true;
            }
        }
        return false;
    }

    public static bool CheckPassword(this string str)
    {
        if (str.Length < 8)
        {
            return false;
        }

        if (!str.HasDigit())
        {
            return false;
        }
        bool flag1 = false;
        bool flag2 = false;

        if(str.ToLower() == str)
        {
            return false;
        }

        if (str.ToUpper() == str)
        {
            return false;
        }

        return true;
    }

    public static string Capitalize(this string str)
    {
        str = str.ToLower();
        return (char)(str[0]-32)+str.Substring(1);
    }

}
