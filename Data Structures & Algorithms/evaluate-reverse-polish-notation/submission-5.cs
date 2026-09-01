public class Solution {
    public int EvalRPN(string[] tokens) {
        var numbers = new Stack<int>();
        for(int i = 0; i < tokens.Length; i++)
        {
            string current = tokens[i];

            if(int.TryParse(current, out int number))
            {
                numbers.Push(number);
            }
            else
            {
                int right = numbers.Pop();
                int left = numbers.Pop();

                switch(current){
                    case "+":
                        numbers.Push(left + right);
                        break;
                    case "-":
                        numbers.Push(left - right);
                        break;
                    case "*":
                        numbers.Push(left * right);
                        break;
                    case "/":
                        if(right == 0)
                        {
                            numbers.Push(0);
                        }
                        else
                        {
                            numbers.Push(left / right);
                        }
                        break;
                }
            }
        }

        return numbers.Pop();
    }
}
