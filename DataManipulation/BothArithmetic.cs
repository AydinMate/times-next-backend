public class BothArithmetics
{
    public static BasicArithmetic GetRandomArithmetic() {
        BasicArithmetic question = new BasicArithmetic();

        Random random = new Random();

        
        int firstOrSecond = random.Next(0, 2);

        if (firstOrSecond == 0)
        {
            question = Multiplication.GetRandomMultiplication();
        }
        else
        {
            question = Division.GetRandomDivision();
        }

          
        return question;
    } 

    public static BasicArithmetic GetRandomNegativeArithmetic() {
        BasicArithmetic question = new BasicArithmetic();

        Random random = new Random();

        
        int firstOrSecond = random.Next(0, 2);

        if (firstOrSecond == 0)
        {
            question = Multiplication.GetRandomNegativeMultiplication();
        }
        else
        {
            question = Division.GetRandomNegativeDivision();
        }

          
        return question;
    } 
}