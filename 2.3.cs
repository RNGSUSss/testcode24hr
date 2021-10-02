using System;
using System.Collections.Generic;

class PersonList
{
    private List<Person> personList;

    public PersonList()
    {
        this.personList = new List<Person>(); 
    }
    public void AddNewPerson(Person person)
    {
        this.personList.Add(person);
    }
    public void FetchlistPerson()
    {
        Console.WriteLine("List Person ");
        Console.WriteLine("____________");

        foreach (Person person in this.personList)
        {
            if (person is Student)
            {
                Console.WriteLine("Name : {0} \n Type Student", person.Getname());
            }
        }
    }
}
