public class Division
{
    public static DivisionQuestion GetRandomDivision()
    {
        DivisionQuestion question = new DivisionQuestion();

        Random random = new Random();

        question.Quotient = random.Next(1, 13);
        question.Divisor = random.Next(1, 13);


        List<int> options = new List<int>();
        question.Dividend = question.Quotient * question.Divisor;
        options.Add(question.Quotient);

        for (int i = 0; i < 3; i++)
        {


            int randomOption;
            bool invalidNumber;
            int factor;

            do
            {
                if (question.Divisor > 3)
                {
                    factor = random.Next(0, question.Divisor);
                }
                else
                {
                    factor = random.Next(0, 4);
                }

                int operation = random.Next(0, 2);

                if (operation == 0)
                {
                    factor = factor * -1 * question.Divisor;
                    if (factor + question.Dividend <= 0)
                    {
                        factor = factor * -1;
                    }
                }
                else
                {
                    factor = factor * question.Divisor;
                }
                randomOption = (question.Dividend + factor) / question.Divisor;
                invalidNumber = options.Contains(randomOption);
                if (randomOption > 12)
                {
                    invalidNumber = true;
                }
            } while (invalidNumber);


            options.Add(randomOption);
        }


        // Fisher-Yates Shuffle
        for (int i = options.Count - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            int temp = options[i];
            options[i] = options[j];
            options[j] = temp;
        }

        question.Options = options;

        return question;
    }
}