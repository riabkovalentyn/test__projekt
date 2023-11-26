using System;
using System.Collections.Generic;


class Company{
    public string Name {get; set;}
    public Lint<Employee> Employees {get; set;}
    public Company( string name){
        Name = name;
        Employees = new List<Employee>();
    }
    public void AddEmployee(Employee employee){
        Employee.Add(employee);
    }
    foreach(Employee emloyee in Employees){
        Console.WriteLine($"Name: {employee.Name} | Position: {employee.Position}");
        }
        if (employee.EquipmentList.Count > 0){
            Console.WriteLine("Issued equipment:");
            foreach(Equipment equipment in employee.EquipmentList){
                Console.WriteLine($" - {equipment.Description}");
            }
        }
        else{
            Console.WriteLine("Issued unequipment");
        }
        Console.WriteLine();
    
    }
    public void AssingEquipment(Employee employee, Equipment equipment){
        employee.AddEquipment(equipment);
    }

}