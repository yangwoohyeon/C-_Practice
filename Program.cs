using System;
using System.Collections;
using System.Collections.Generic;

class Person{
    public string Name;

    public void Eat(){
        Console.WriteLine(Name + "(이)가 식사를 합니다.");
    }
}

class Program{
    public static void Main(string[] args){
        Person person = new Person();
        person.Name = "양우현";
        person.Eat();

        CleanRobot robot = new CleanRobot();
        robot.Move();
        robot.Clean();

        int[] array1 = new int[3];
        array1[0]=1;
        array1[1]=2;
        array1[2]=3;

        for(int i=0; i<array1.Length; i++){
            Console.WriteLine(array1[i]);
        }

        // ArrayList 예제
        ArrayList al = new ArrayList();
        al.Add(10);
        al.Add("Hello");

        foreach(var item in al){
            Console.WriteLine(item);
        }

        // Hashtable 예제
        Hashtable table = new Hashtable();

        table["id"] = 1;
        table["name"] = "우현";

        Console.WriteLine("ID: " + table["id"]);
        Console.WriteLine("Name: " + table["name"]);

        // Queue 예제
        Queue queue = new Queue();

        queue.Enqueue(1);
        queue.Enqueue("Hello");

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());

        // Stack 예제
        Stack stack = new Stack();

        stack.Push(1);
        stack.Push(2);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        Console.WriteLine();

        Dictionary<string, int> howOld = new Dictionary<string, int>();
        howOld["철수"] = 26;
        howOld["홍길동"] = 30;

        Console.WriteLine("철수의 나이: " + howOld["철수"]);
        Console.WriteLine("홍길동의 나이: " + howOld["홍길동"]);

        Console.WriteLine();

        

   }
}
