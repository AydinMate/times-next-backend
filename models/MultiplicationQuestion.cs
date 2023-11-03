public class MultiplicationQuestion
{
    public int Multiplicand { get; set; }
    public int Multiplier { get; set; }
    public int Product { get; set; }
    public List<int>? Options { get; set; }


    public MultiplicationQuestion()
    {
       
    }

    public MultiplicationQuestion(int multiplicand, int multiplier, int product, List<int> options )
    {
        Multiplicand = multiplicand;
        Multiplier = multiplier;
        Product = product;
        Options = options;
    }
}