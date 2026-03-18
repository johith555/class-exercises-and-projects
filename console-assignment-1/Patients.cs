using System;

class Patients
{
    public int PatientId;
    public string PatientName;
    public int Age;

    // Default Constructor
    public Patients()
    {
        Console.WriteLine("Default Patient Constructor Called");
    }

    // Parameterized Constructor
    public Patients(int id, string name, int age)
    {
        PatientId = id;
        PatientName = name;
        Age = age;

        Console.WriteLine("Parameterized Patient Constructor Called");
    }

    public void Display()
    {
        Console.WriteLine($"Patient ID: {PatientId}");
        Console.WriteLine($"Patient Name: {PatientName}");
        Console.WriteLine($"Age: {Age}");
    }
}
