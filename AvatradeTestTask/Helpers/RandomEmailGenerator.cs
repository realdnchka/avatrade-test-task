using System.Text;

namespace AvatradeTestTask.Helpers;

public class RandomEmailGenerator
{
    public string Generate()
    {
        StringBuilder sb = new();
        Random random = new();

        char ch;

        for (int i = 0; i < 10; i++)
        {
            int rnd = random.Next(25);
            ch = Convert.ToChar(rnd + 97);
            sb.Append(ch);
        }

        return sb.Append("@test.test").ToString();
    }
}