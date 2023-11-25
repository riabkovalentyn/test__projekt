using System;
using System.Collections.Generic;

public interface ITool{
    void Use();
}

public class Equipment{
    public int ID { get; }
    public string Description { get; }
    public Equipment( int id, string description){
        ID = id;
        Description = description;
    }
}

public abstract class Employee{
    public string FirstName{ get; }
    public string LastName{ get; }
    public string JobDescription{ get; }

    protected Employee(string firstName, string lastName, string jobDescription){
        FirstName = firstName;
        LastName = lastName; 
        JobDescription = jobDescription;
    }

    public abstract void Work( );

}

    public class ITEmployee : Employee{ 
         private readonly List<ITool>Tools; 
         public ITEmployee(string firstName, string lastName, string jobDescription) : base( firstName, lastName, jobDescription){
            Tools = new List<ITool>();
         }
        public void AddTool(ITool tool){
            Tools.Add(tool);
        }
        public override void Work(){
            Console.WriteLine("Work in IT Company...");
            foreach (var tool in Tools){
                tool.Use();
            }
            
        }
    }
        public class Notebook : ITool{
            public void Use(){
                Console.WriteLine("Using PC...");
            }
        }
        public class Phone : ITool{
            public void Use(){
                Console.WriteLine("Using Phone");
            }
        }
