using System.Collections;

namespace Best_First_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input for algorithm: a binary search tree with node values
            // NEED TO INPUT THIS

            Console.WriteLine($"-------------------- Initializations --------------------\n");

            Queue<char> unvisitedNodes = new Queue<char>();  
            unvisitedNodes.Enqueue('A');  // start with just the root node
            Console.Write("Visited nodes queue contains: ");
            Print(unvisitedNodes);

            Queue<char> visitedNodes = new Queue<char>();
            Console.Write("Unvisited nodes queue contains: ");
            Print(visitedNodes);

            // the goal is to reach node J or node L
            char goal1 = 'J';
            char goal2 = 'L';
            Console.WriteLine($"Goal nodes: {goal1} and {goal2}\n");

            int count = 1;  // to count the number of iterations performed

            while (unvisitedNodes.Count > 0)
            {
                // visiting the first node in unvisitedNodes

                // check to see if the first node in unvisitedNodes is a goal node
                if (unvisitedNodes.First() == goal1 || unvisitedNodes.First() == goal2)
                {
                    Console.WriteLine("Goal node found!");
                    break;  // accomplished goal
                }

                // add the children of the node we're visiting to unvisitedNodes
                unvisitedNodes.Enqueue(INSERT CHILDREN FROM TREE);  // NEED HELP

                // move the node we're currently visiting to visitedNodes
                visitedNodes.Enqueue(unvisitedNodes.First());
                unvisitedNodes.Dequeue();

                // sort unvisitedNodes from so the smallest value is at the beginning of the queue
                // NEED HELP SINCE MY QUEUE ONLY HOLDS NODE LABELS; NEED IT TO HOLD BOTH LABELS AND VALUES

                Console.WriteLine($"-------------------- End of Iteration Number {count} --------------------\n");
                Console.WriteLine($"RESULTS FROM ITERATION {count}: \n");

                break;  // REMOVE WHEN DONE CODING
            }

        }

        public static void Print(IEnumerable inputQueue)
        {
            foreach (var item in inputQueue)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }
    }
}