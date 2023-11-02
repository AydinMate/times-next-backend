public class Multiplication
{
    public static MultiplicationQuestion GetRandomMultiplication() {
        MultiplicationQuestion question = new MultiplicationQuestion();

        Random random = new Random();

        question.FirstNumber = random.Next(1, 13);
        question.SecondNumber = random.Next(1, 13);


        List<int> options = new List<int>();
        question.Answer = question.FirstNumber * question.SecondNumber;
        options.Add(question.Answer);

        for (int i = 0; i < 3; i++)
        {
            int factor;
            int firstOrSecond = random.Next(0, 2);

            if (firstOrSecond == 0)
            {
                factor = question.FirstNumber; 
            }
            else
            {
                factor = question.SecondNumber;
            }

            int randomNumber;
            bool isDuplicate;
            int multipliedNumber;

            do
            {
                randomNumber = random.Next(1, 13); 
                multipliedNumber = randomNumber * factor;
                isDuplicate = options.Contains(multipliedNumber);
            } while (isDuplicate);

            
            options.Add(multipliedNumber);
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