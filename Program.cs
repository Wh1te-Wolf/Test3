namespace Test3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var chars = new[] { 'A', 'B', 'C' };
            var sequences = StringPermutations.GetAllSequences(chars);

            foreach (var sequence in sequences)
            {
                Console.WriteLine(sequence);
            }
        }
    }
}
