using System.Collections.Generic;
using System.Linq;



public class Family
{
    private List<Person> persons;

    public Family()
    {
        this.persons = new List<Person>();
    }

    public void AddMember(Person member)
    {
        persons.Add(member);
    }

    public Person GetOldestMember()
    {
        return persons.OrderByDescending(p => p.Age).First();

    }

    public List<Person> GetPollMembers()
    {
        List<Person> pollMembers = this.persons.Where(p => p.Age > 30).OrderBy(f=>f.Name).ToList();
        return pollMembers;
    }
}

