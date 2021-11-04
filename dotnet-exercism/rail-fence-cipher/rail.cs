using System;

public class RailFenceCipher
{
    public int Rails;

    public RailFenceCipher(int rails)
    {
        Rails = rails;
    }

    public string Encode(string input)
    {
        bool ok = true;
        string str = "";
        int z = 0;
        char[,] code = new char[Rails, input.Length];
        char[] array = input.ToCharArray();
        for (int i = 0; i < Rails; i++)
            for (int j = 0; j < input.Length; j++)
                code[i, j] = '.';
        for (int i = 0; i < Rails - 1; i++)
            for (int j = 0; j < input.Length; j++)
            {
                if (ok)

                {
                    code[i, j] = array[z];
                    z++;
                    i++;
                }
                else
                {
                    code[i, j] = array[z];
                    z++;
                    i--;
                }
                if (i == 0)
                    ok = true;
                if (i == Rails - 1)
                    ok = false;
            }
        foreach (var x in code)
            if (x != '.')
                str += x;
        return str;
    }

    public string Decode(string input)
    {
        bool ok = true;
        string str = "";
        int z = 0, i;

        char[,] code = new char[Rails, input.Length];
        char[] array = input.ToCharArray();


        for (i = 0; i < Rails; i++)
            for (int j = 0; j < input.Length; j++)
                code[i, j] = '.';


        i = 0;
        for (int j = 0; j < input.Length; j++)
        {
            if (ok)

            {
                code[i, j] = '?';

                i++;
            }
            else
            {
                code[i, j] = '?';
                i--;
            }
            if (i == 0)
                ok = true;
            else if (i == Rails - 1)
                ok = false;

        }
        for (i = 0; i < Rails; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < input.Length; j++)
                Console.Write($"{code[i, j]}");
        }


        for (i = 0; i < Rails; i++)
            for (int j = 0; j < input.Length; j++)
                if (code[i, j] == '?')
                {
                    code[i, j] = array[z];
                    z++;
                }
        ok = true;
        i = 0;
        for (int j = 0; j < input.Length; j++)
        {
            if (ok)

            {
                str += code[i, j];

                i++;
            }
            else
            {
                str += code[i, j];
                i--;
            }
            if (i == 0)
                ok = true;
            if (i == Rails - 1)
                ok = false;
            if (str.Length == input.Length)
                break;
        }
        for (i = 0; i < Rails; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < input.Length; j++)
                Console.Write($"{code[i, j]}");
        }
        return str;
    }
}