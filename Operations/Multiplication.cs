public class Multiplication
{
    public static BasicArithmetic GetRandomMultiplication() {
        BasicArithmetic question = new BasicArithmetic();

        question.Operation = "&#215;";

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

    public static BasicArithmetic GetRandomNegativeMultiplication() {
        BasicArithmetic question = new BasicArithmetic();

        question.Operation = "&#215;";

        Random random = new Random();

        do
        {
            question.FirstNumber = random.Next(-12, 13);
        } while (question.FirstNumber == 0);

        do
        {
            question.SecondNumber = random.Next(-12, 13);
        } while (question.SecondNumber == 0);



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
                randomNumber = random.Next(-12, 13); 
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