namespace Bowling
{
    public class Bowling
    {
        public int DoRoll(string rolls) {
            var frames = rolls.Split(" ");
            var frame = frames[0];

            if (frame != "--") {
                int one = frame.Substring(0, 1) != "-" ? int.Parse(frame.Substring(0, 1)) : 0;
                int two = frame.Substring(1) != "-" ? int.Parse(frame.Substring(1)) : 0;
                return one + two;
            }
            
            var singleRoll = rolls.Replace("-", "").Trim();
            
            if (singleRoll.Length == 0) {
                return 0;
            }

            return int.Parse(singleRoll);
        }
    }
}