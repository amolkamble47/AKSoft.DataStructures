
    Console.Write("Enter Stack Size: ");
    var input = Console.ReadLine();

    var stk = new AKSoft.DataStructures.Stack.Stack<string>(Convert.ToInt32(input));
    bool exit = false;

    while(!exit) {
        try {
            Console.Write("Command: ");
            input = Console.ReadLine();
            var tokens = input?.Split(" ") ?? new string[] { "--", "" };
            switch(tokens[0]) {
                case "quit":
                case "bye":
                case "exit": exit = true; break;
                case "push": stk.Push((string)Convert.ChangeType(tokens[1], typeof(string))); break;
                case "pop": stk.Pop(); break;
                case "print": Print(stk); break;
            }
        } catch (Exception e) {
            Console.WriteLine(e.ToString());
        }
    }

    Console.WriteLine("Good Bye!");

    static void Print<T>(AKSoft.DataStructures.Stack.Stack<T> stk) {
        var arr = stk.Array;
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++) {
            if (i == stk.Pointer) {
                Console.Write("(!)");
            }
            Console.Write($"{arr[i]}");
            
            if (i < arr.Length - 1) {
                Console.Write(",");
            }
        }
        Console.Write($"]");
        Console.WriteLine();
    }
