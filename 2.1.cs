using System;

class Person
{
    protected string username;
    protected string password;

    public Person(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
    public string Getname()
    {
        return this.username;
    }
}
