# Queue 

## I. Introduction 

![Queue Image](images/line.jpeg)

In the daily life, standing and waiting in the line is part of our life. In the above example, queue is an essential step of dealing with this situation. Who comes first then will be served first. In the real world, queue makes everyone equal, it is a fair step. 

## II. Common Usage of Queue

Queues are commonly used in places where overcapacity occurs. If there is no overcapacity, then there is no need for queue.

In the life, you will see queue almost every where. Such as restaurants, grocery stores, shopping mall, and etc. 

## III. Common Queue Operation and Efficiency

Include the correct the program

```csharp
using System.Collections;
```

A queue in C# is defined as dynamic list. 

```csharp
Queue queue = new Queue();
```

## Enqueue:

Enqueue simply means we are inserting data in the queue, in C# can be done like below: 

```csharp
queue.Enqueue(1);
```

The efficiency of enqueue is O(1).

## Dequeue: 

Dequeue is a way to exit the queue. The most common way is to pop the first element of the queue. And it can be done.

```csharp
queue.Dequeue();
```

The efficiency of Dequeue is O(1).

## Find the size of the queue:

We could also find the size of the queue.

```csharp
queue.Count;
```

The efficiency of finding the size of the queue is O(1).

## Check if the queue is empty:

We could also check to see if the size of the queue is empty.

```csharp
if(queue.Count == 0)
```

The efficiency of checking if the queue is empty is O(1).

## IV. Example: Queue to a music playlist

In the following example, we already have some songs line up in the playlist. Through queue, we could add and remove the songs in our playlist.

### Queue Requirements

1. Allow songs to be added in the playlist
2. Always play the songs in the first queue
3. Remove the mis added songs for previous two
4. Check if the playlist is empty

```csharp
using System;
using System.Collections;
  
public class MyApp {
    static public void Main()
    {
  
        // Create a queue
        // Using Queue class
        Queue queue = new Queue();
  
        queue.Enqueue("Song A"); 
        Console.WriteLine(queue); // Song A
        queue.Enqueue("Song B"); 
        Console.WriteLine(queue); // Song A, Song B
        queue.Enqueue("Song C"); 
        Console.WriteLine(queue); // Song A, Song B, Song C
        queue.Dequeue(); 
        Console.WriteLine(queue); // Song B, Song C
        queue.Dequeue(); 
        Console.WriteLine(queue); // Song C
  
        if(queue.Count == 0)
        {
            Console.WriteLine("The playlist is empty")
        }
    }
}
```

## V. Problem to solve

Write a program to manage the customer service call cener for Super Market in your area. There are often more people to call in than Customer center's staff. 

### Requirements:

1. Your queue must handle adding a new waiting spot for the hot line.
2. The queue must be ordered according to the entrance time to the hot line.
3. Allow the people in the calling center see how many people are in the queue.
4. Check for a speific person is in the queue or not


### Starting code:

```csharp
using System;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Create a queue
        // Using Queue class
  
        // Adding a new waiting spot in queue
        // Using Enqueue() method
        // Their names are John, Kai, Lily, Grace, Mike

        // Removing the last person in the queue
  
        // Checking if John is
        // present in the Queue or not

        // Check the size of the queue

        }
    }
}
```
[check for solution](Program.cs) It starts from Line 11

[Go back to the welcome page](welcome.md)