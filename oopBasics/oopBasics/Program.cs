﻿using System;

public class Person {

    public string Name;
    public void Introduce(string to) => global::System.Console.WriteLine("Hi, {0}. I am {1}.", to, Name);

    public static Person Parse(string str) {
        var person = new Person();
        person.Name = str;
        return person;
    }
    class Program {
        public static void Main(string[] args){
            var person = Person.Parse("Janez");
            person.Introduce("Ziga");

        }
    }
}