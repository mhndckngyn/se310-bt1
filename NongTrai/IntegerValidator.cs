namespace NongTrai;

public class IntegerValidator
{
    public static bool ValidatePositive(string input, out int num)
    {
        num = -1;
        var isInteger = int.TryParse(input, out var intNumber);
        if (!isInteger || intNumber < 0)
        {
            return false;
        }

        num = intNumber;
        return true;
    }
}