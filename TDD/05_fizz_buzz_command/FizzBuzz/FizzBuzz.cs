namespace FizzBuzz
{
    public class FizzBuzz
    {
        public List<string> Calculate(int upperBound)
        {
            List<Command> commands = FizzBuzzCommandFactory.Build(upperBound);

            var result = new List<string>();
            foreach (var command in commands)
            {
                result.Add(command.execute());
            }

            return result;
        }
    }

    public class FizzBuzzCommandFactory
    {
        public static List<Command> Build(int upperBound)
        {
            var commands = new List<Command>();
            for (var i = 1; i <= upperBound; i++)
            {
                BuildCommand(commands, i);
            }

            return commands;
        }

        private static void BuildCommand(List<Command> commands, int i)
        {
            bool isFizzBuzz = i % 5 == 0 && i % 3 == 0;

            if (i % 7 == 0)
            {
                commands.Add(new PopCommand(i));
            }
            else if (isFizzBuzz)
            {
                commands.Add(new FizzBuzzCommand(i));
            }
            else if (i % 3 == 0)
            {
                commands.Add(new FizzCommand(i));
            }
            else if (i % 5 == 0)
            {
                commands.Add(new BuzzCommand(i));
            }
            else
            {
                commands.Add(new OrdinalCommand(i));
            }
        }
    }

    public abstract class Command
    {
        protected int value = 0;

        public Command(int value)
        {
            this.value = value;
        }

        abstract public string execute();
    }

    public class OrdinalCommand : Command
    {
        public OrdinalCommand(int value) : base(value) { }

        public override string execute()
        {
            return value.ToString();
        }
    }

    public class FizzCommand : Command
    {
        public FizzCommand(int value) : base(value) { }

        public override string execute()
        {
            return "Fizz";
        }
    }

    public class BuzzCommand : Command
    {
        public BuzzCommand(int value) : base(value) { }

        public override string execute()
        {
            return "Buzz";
        }
    }

    public class FizzBuzzCommand : Command
    {
        public FizzBuzzCommand(int value) : base(value) { }

        public override string execute()
        {
            return "FizzBuzz";
        }
    }

    public class PopCommand : Command
    {
        public PopCommand(int value) : base(value) { }

        public override string execute()
        {
            return "Pop";
        }
    }
}