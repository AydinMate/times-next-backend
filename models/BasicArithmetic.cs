public class BasicArithmetic
{
    public string? Operation { get; set; }
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public int Answer { get; set; }
    public List<int>? Options { get; set; }


    public BasicArithmetic()
    {

    }

    public BasicArithmetic(string operation, int firstNumber, int secondNumber, int answer, List<int> options)
    {
        Operation = operation;
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
        Answer = answer;
        Options = options;
    }
}