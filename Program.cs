using System;
class Student{
    public string Name {get; set;}
    public int Id {get; set;}
    public int Marks {get; set;}

    public Student(string name, int id, int marks){
        Name = name;
        Id = id;
        Marks = marks;
    }

    public Student(Student s){
        Name = s.Name;
        Id = s.Id;
        Marks = s.Marks;
    }

    public string GetGrade(){
        if(Marks>=85) return "A";
        else if(Marks>=75) return "B";
        else if(Marks>=65) return "C";
        return "D";
    }

    public virtual void Main(){
        Console.WriteLine($"Name: {Name}, Id: {Id}, Marks: {Marks}, Grade: {GetGrade()}");
    }
}


class Program{
    static void Main(){
        Student s1 = new Student("Kishan Ved", 22110122, 99);
        Console.WriteLine("Details of object s1:");
        s1.Main();

        Student s2 = new Student(s1);
        Console.WriteLine("Details of object s2:");
        s2.Main();
    }
}