namespace FizzBuzz
{
    public class FizzBuzz
    {
        public List<string> Calculate(int upperBound)
        {
            var result = new List<string>();

            for (var i = 1; i <= upperBound; i++)
            {
                var value = "";

                if (i % 3 == 0)
                {
                    value = "Fizz";
                }
                if (i % 5 == 0)
                {
                    value += "Buzz";
                }

                value = value.Length != 0 ? value : i.ToString();
                result.Add(value);
            }

            return result;
        }
    }
}