using System;

class Student : Person
{
    private string studentID;
    
    public Student(string username, string password, string studentID): 
        base(username, password)
    {
        this.studentID = studentID;
    }
}
