using System;

class IT : Employee{
    public IT(string name) : base(name, "IT"){}
}

class LinuxExpert : IT{
    public LinuxExpert(string name) : base(name){}
}
class DevOps : IT{
    public DevOps(string name) : base(name){}
}
class Developer : DevOps{
    public Developer(string name) : base(name){}
}

class Logistics : Employee{
    public Logistics(string name) : base(name, "Logistics"){}
}
class Manager : Employee{
    public Manager(string name) : base(name, "Manager"){}
}

