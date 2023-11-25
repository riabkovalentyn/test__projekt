using System;

public class Program{
    public static void Main(){
        ITEmployee linuxGuy = new ITEployee('Rico', 'Marko', 'LinuxEmployee');
        linuxGuy.AddTool(new newNotebook());
        linuxGuy.AddTool(new Phone());
        linuxGuy,Work();
    }
}