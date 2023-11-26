using System;
using System.Collections.Generic;

 class Equipment{
    public int ID { get; set; }
    public string Description { get; set; }
    public Equipment( string id, string description){
        ID = id;
        Description = description;
    }
}

 abstract class Employee{
    public string Name{ get; set; }
    public string Position{ get; set:}
    public List<Equipment> EquipmentList{ get; set; } 

    protected Employee( string Name, string Position){
       Name = name;
        Position = position;
        EquipmentList = new List<Equipment>();
    }

    public void AddEquipment(Equipment equipment){
    EquipmentList.Add(equipment);

}

  
