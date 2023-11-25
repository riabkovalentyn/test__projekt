using System;
using  System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Program{
    public static void Main(){
        ITEmployee linuxGuy = new ITEmployee("Rico", "Marko", "LinuxEmployee");
        linuxGuy.AddTool(new Notebook());
        linuxGuy.AddTool(new Phone());
        linuxGuy.Work();
        try{
            string sqlQueriesFilePath = "#/queries.sql";
            string sqlQueries = File.ReadAllText(sqlQueriesFilePath);
            Console.WriteLine(sqlQueries);
        } // catch (Exception ex} {
       // Console.WriteLine("Error" + ex.Message) ;
     //}
        try{
        string jsonFilePath = "#/data.json";
        string jsonData = File.ReadAllText(jsonFilePath);
        dynamic data = JsonConvert.DeserializeObject(jsonData);
        Console.WriteLine(data);
        } catch (Exception ex} {
        Console.WriteLine("Error" + ex.Message) ;
     }
  }
}
