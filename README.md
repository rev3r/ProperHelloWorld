# Reason

Everyone starts learning how to code by writing simple *Hello World* program:
```C#
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}
```

But hey, I'm a professional developer, I can't write code like that!

I should use **layers**.

# Null checking

I know that this code doesn't check for potential `null` dereferences. But this would unnecessarily pollute source code.

Besides, I wrote it to be compatible with C# 8.0 *nullable reference types* feature (yes, that's my excuse).

# ToDo 

The only thing that bothers me, is that I reference `Infrastructure` from `ConsoleApp` (for DI purposes).

I'll fix it some day... Maybe...
