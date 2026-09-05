public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = position
            .Zip(speed, (p , s) => (position : p, speed : s))
            .OrderByDescending(x => x.position)
            .ToList();

        var stack = new Stack<double>();
        for(int i = 0; i < cars.Count; i++)
        {
            double current = (double)(target - cars[i].position) / cars[i].speed;
            stack.Push(current);

            if(stack.Count >= 2)
            {
                double last = stack.ElementAt(1);

                if(last >= current){
                    stack.Pop();
                }
            }
        }

        return stack.Count();
    }
}