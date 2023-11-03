public class DivisionQuestion
{
    public int Dividend { get; set; }
    public int Divisor { get; set; }
    public int Quotient { get; set; }
    public List<int>? Options { get; set; }


    public DivisionQuestion()
    {
       
    }

    public DivisionQuestion(int dividend, int divisor, int quotient, List<int> options )
    {
        Dividend = dividend;
        Divisor = divisor;
        Quotient = quotient;
        Options = options;
    }
}