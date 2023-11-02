public class MultiplicationQuestion
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public int Answer { get; set; }
    public List<int>? Options { get; set; }


    public MultiplicationQuestion()
    {
       
    }

    public MultiplicationQuestion(int firstNumber, int secondNumber, int answer, List<int> options )
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
        Answer = answer;
        Options = options;
    }
}