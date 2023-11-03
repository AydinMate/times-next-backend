public class Division
{
    public static BasicArithmetic GetRandomDivision()
    {
        BasicArithmetic question = new BasicArithmetic();

        question.Operation = "&divide;";

        Random random = new Random();

        question.Answer = random.Next(1, 13);
        question.SecondNumber = random.Next(1, 13);


        List<int> options = new List<int>();
        question.FirstNumber = question.Answer * question.SecondNumber;
        options.Add(question.Answer);

        for (int i = 0; i < 3; i++)
        {


            int randomOption;
            bool invalidNumber;
            int factor;

            do
            {
                if (question.SecondNumber > 3)
                {
                    factor = random.Next(0, question.SecondNumber);
                }
                else
                {
                    factor = random.Next(0, 4);
                }

                int operation = random.Next(0, 2);

                if (operation == 0)
                {
                    factor = factor * -1 * question.SecondNumber;
                    if (factor + question.FirstNumber <= 0)
                    {
                        factor = factor * -1;
                    }
                }
                else
                {
                    factor = factor * question.SecondNumber;
                }
                randomOption = (question.FirstNumber + factor) / question.SecondNumber;
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

    public static BasicArithmetic GetRandomNegativeDivision()
    {
        BasicArithmetic question = new BasicArithmetic();

        question.Operation = "&divide;";


        Random random = new Random();

        do
        {
            question.Answer = random.Next(-12, 13);
        } while (question.Answer == 0);

        do
        {
            question.SecondNumber = random.Next(-12, 13);
        } while (question.SecondNumber == 0);



        List<int> options = new List<int>();
        question.FirstNumber = question.Answer * question.SecondNumber;
        options.Add(question.Answer);

        for (int i = 0; i < 3; i++)
        {


            int randomOption;
            bool invalidNumber;
            int factor;

            do
            {
                if (question.SecondNumber > 3)
                {
                    factor = random.Next(0, question.SecondNumber);
                }
                else
                {
                    factor = random.Next(0, 4);
                }

                int operation = random.Next(0, 2);

                if (operation == 0)
                {
                    factor = factor * -1 * question.SecondNumber;

                }
                else
                {
                    factor = factor * question.SecondNumber;
                }
                randomOption = (question.FirstNumber + factor) / question.SecondNumber;
                invalidNumber = options.Contains(randomOption);
                if (randomOption > 12 | randomOption == 0 | randomOption < -12)
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