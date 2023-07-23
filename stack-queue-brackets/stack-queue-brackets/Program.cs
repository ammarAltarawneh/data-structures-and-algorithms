namespace stack_queue_brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidateBrackets("{ } ()kk){ }"));
            Console.WriteLine(ValidateBrackets("{ ( ) } { ["));
            Console.WriteLine(ValidateBrackets("{( [] )}"));
        }

        public static bool ValidateBrackets(string input)
        {

            char[] inputs = input.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == '(' || inputs[i] == '{' || inputs[i] == '[')
                {
                    stack.Push(inputs[i]);
                }
                if (inputs[i] == ')' || inputs[i] == '}' || inputs[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else if (!isMatching(stack.Pop(), inputs[i]))
                    {
                        return false;
                    }
                }
            }
            if (!(stack.Count == 0))
                return false;
            return true;
        }
        public static bool isMatching(char char1, char char2)
        {
            if (char1 == '(' && char2 == ')')
                return true;
            else if (char1 == '{' && char2 == '}')
                return true;
            else if (char1 == '[' && char2 == ']')
                return true;
            else
                return false;
        }
    }
}