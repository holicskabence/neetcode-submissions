public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        for(int i = 0; i < tokens.Length; i++){
            string current = tokens[i];

            if(!current.Contains("+") && !current.Contains("-") && !current.Contains("*") && !current.Contains("/"))
            {
                stack.Push(int.Parse(current));
            }
            else
            {
                int result = 0;
                 while(stack.Count > 0){
                    int top = stack.Pop();

                    switch(current){
                        case "+":
                            result += top;
                        break;
                        case "-":
                            result -= top;
                        break;
                        case "*":
                            result = Math.Max(result, 1);
                            result *= top;
                        break;
                        case "/":
                            result = Math.Max(result, 1);
                            result /= top;
                        break;
                    }
                }

                stack.Push(result);
            }
        }

        return stack.Pop();
    }
}
