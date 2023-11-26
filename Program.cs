using System;
using  System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Program{
    public static void Main(){
        Equipment office = new Equipment("001", "Office");
        Equipment Notebook = new Equipment("002","NoteBook");
        Equipment Phone = new Equipment("003","Phone");   

        LinuxExpert john = new LinuxExpert("John");
        Developer kristian = new Developer("Kristian");
        Logistics mike = new Logistics("Mike");
        Accountant emma = new Accountant("Emma");
        Manager tom = new Manager("Tom");
        Company company = new Company("XYZ Company");
        company.AddEmployee(john);
        company.AddEmployee(sarah);
        company.AddEmployee(mike);
        company.AddEmployee(emma);
        company.AddEmployee(tom);

        company.AssignEquipment(john, office);
        company.AssignEquipment(sarah, notebook);
        company.AssignEquipment(mike, phone);

        company.ListEmployeesWithEquipment();
     }
  }
}
