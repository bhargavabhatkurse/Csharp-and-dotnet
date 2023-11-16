// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Student {
    // int rollno;
    // string? name;

    public int rollno { get; set; }
    public string? name { get; set; }
}


public class Program{
    static void Main() {
    string name = "Bhargava";
    Console.WriteLine("Hello, World! {0}",name);
    Console.WriteLine("Hello, World! " + name);


    var std1 = new Student();
    std1.rollno = 9;
    std1.name = name;

    Console.WriteLine("Hi " + std1.name);

    Console.WriteLine('\n');
    var studentlist = new List<Student>();

    studentlist.Add(std1);

    studentlist.Add(new Student() {rollno = 12,name= "Bhatkurse"});

    foreach (var item in studentlist)
    {
        Console.WriteLine("hello " + item.name);
    }

    studentlist.RemoveAt(0);    //removes at an index

    foreach (var item in studentlist)
    {
        Console.WriteLine("after deletion:\n hello " + item.name);
    }


    var result = studentlist.Where(s => s.rollno == 12).FirstOrDefault();
    Console.WriteLine("matched result =  " + result?.name);
    }
}


class Todo {

    public string? message;
    public bool getVerified;


};