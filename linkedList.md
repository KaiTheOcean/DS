# Linked List

## Structure

Have you ever riden a train before? This is how linked list works! 

![](images/train.jpeg)

A train has a beginning and an end, we call them head and tail in our linked list. Each cabin is attached to another cabin (Unless it's the head or the tail), we will call the cabin to the left prev and the cabin to the right next. This is how we connect our linked list! 

The first thing we do is to use the correct program 

```csharp
using System.Collections.Generic;
```

Then we create Linked_list

```csharp
string [] names = {"A","B","C"};
LinkedList <string> names_list = new LinkedList <string>(names);
// A-B-C
```

### Add node in the begining of linked list

```csharp
names_list.AddFirst("First"); // First-A-B-C
```

### Add node in the end of the linked list

```csharp
names_list.AddLast("D"); // First-A-B-C-D
```

### Add node after a node

```csharp
names_list.AddAfter("D", "E"); //First-A-B-C-D-E
```

### Add node before a node

```csharp
names_list.AddBefore("A", "Second"); //First-Second-A-B-C-D-E
```

### Remove first node in the linked list

```csharp
names_list.RemoveFirst(); // Second-A-B-C-D-E
```

### Remove last node in the linked list

```csharp
names_list.RemoveLast(); // Second-A-B-C-D
```

### Check the size of the linked list

```csharp
names_list.Count(); // 5
```

### Linked List Operation & Efficiency

| Operation   | Performance |
|-------------|-------------|
| AddFirst    | O(1)        |
| AddLast     | O(1)        |
| AddAfter    | O(n)        |
| RemoveFirst | O(1)        |
| RemoveLast  | O(1)        |   
| Count       | O(1)        | 

### Example 

Here is the real life example when a teacher collect homework and she wants to make them in order of whoever sumbit first will place on the top and second will be in the second position. And now we know Joseph has already submited. 

```csharp
using System;
using System.Collections.Generic;
  
public class MyApp {
    static public void Main()
    {
  
        // Create a linked list
        string [] names = {"Joseph"};
        LinkedList <string> students = new LinkedList <string>(names);
  
        students.AddLast("Xing"); 
        Console.WriteLine(students); // Joseph, Xing
        students.AddLast("Aaron"); 
        Console.WriteLine(students); // Joseph, Xing, Aaron
        students.AddLast("Todd"); 
        Console.WriteLine(students); // Joseph, Xing, Aaron, Todd

        // And now she will start grading the homework
        students.RemoveFirst(); 
        Console.WriteLine(students); // Xing, Aaron, Todd
        students.RemoveFirst(); 
        Console.WriteLine(students); // Aaron, Todd
  
        if(students.Count == 0)
        {
            Console.WriteLine("All homework has been graded");
        }
        else
        {
            Console.WriteLine("You still have homework to grade");
        }
    }
}
```

### Problem to solve 
Write A program for customers in the shopping mall

1. Customer can enter the linked list (Add to the tail of the linked list)
2. If the customer has a golden pass, then he can directly go in front of the linked list.
3. A customer decide to leave the queue.
4. A mananger is able to see all the customers.
5. There is already 2 people in the linked list

```csharp
using System;
using System.Collections.Generic;
  
public class MyApp {
    static public void Main()
    {
  
        // Create a linked list
        string [] names = {"C1", "C2"};
        LinkedList <string> customers = new LinkedList <string>(names);

        // Add C3, C4, C5 in the linked list
        // C1, C2, C3, C4, C5

        // C7 has a golden pass so she gets paid first
        // C7, C1, C2, C3, C4, C5

        // C5 is leaving the linked list, because he forgot something
        // C7, C1, C2, C3, C4

        // A mananger wants to see how many poeple are in teh line
        // 5
    }
}
```
[check for solution](Program.cs) It starts from Line 45

[Go back to the welcome page](welcome.md)