namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inteteractive debug by clicking in the gutter
            // <--- step through the code to inspect
            Console.WriteLine("Hello, World!");

            // Comment
            /* 
              Multiline Comment
              `SHIFT+CTRL+B` to build in Visual Stuido
            */


            /* Types

            # Value Types (primitives)

            - bool
            - byte
            - char
            - decimal
            - double
            - float
            - int
            - long


            # Reference Types

            - object
            - string
            - dynamic


            # Empty

            - null
            */


            // Implicit vs Explicit typing

            var i = 10; // Implicitly typed.
            int x = 10; // Explicitly typed.

            Console.WriteLine("i=" + i + ", x=" + x);


            // Conditionals (if) 

            var isTrue = false;
            if (isTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            // Arrays, Lists, & Dictionaries

            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            List<string> optionList = new List<string>
            { "AdditionalCardPersonAdressType", /* rest of elements */ };

            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}};


            // Loops

            foreach (KeyValuePair<string, string> kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }


            // Declarations & Classes

            var helloWorld = new HelloWorld();
            helloWorld.name = "DEV3L";

            Console.WriteLine(helloWorld.greeting());
        }

        class HelloWorld
        {
            private string message = "Hello, World!";

            public string name = "TDD in C Sharp";

            public string greeting()
            {
                return name + "\n" + message;
            }
        }
    }
}
