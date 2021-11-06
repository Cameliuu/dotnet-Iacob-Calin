using System;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {

        int i = 0;
        string res = "";
        bool ok = String.IsNullOrEmpty(input);

        if (!ok)
        {
            char aux = input[0];
            foreach (var character in input + 1)
                if (character == aux)
                    i++;
                else
                {
                    if (i > 1) res += $"{i}{aux}";
                    else res += aux;
                    aux = character;
                    i = 1;
                }
        }
        return res;
    }

    public static string Decode(string input)
    {
        string res = "";
        int i = 0;
        bool ok = true;
        foreach (var character in input)
        {

            if (character > 48 && character < 58)
            {
                if (ok) i = 10 - (58 - character);

                if (!ok)
                    i = i * 10 + 10 - (58 - character);

                Console.WriteLine(i);
                ok = false;
            }
            else
                if (i > 0 && !ok)
            {
                while (i > 0)
                {
                    res += character;
                    i--;
                }
                ok = true;
            }

            else
                res += character;
        }
        return res;
    }
}
