using System;
using System.Collections.Generic;
using System.Text;


public class Family
{
    private List<Person> familyList = new List<Person>();

    public List<Person> FamilyList
    {
        get { return familyList; }
        set { familyList = value; }
    }

    public Family()
    {
        familyList = new List<Person>();
    }

    public void AddMember(Person member)
    {
        familyList.Add(member);
    }

    public Person GetOldestMember()
    {
        Person oldestGuy = new Person();
        int oldest = int.MinValue;
        int currentAge = 0;
        for (int i = 0; i < familyList.Count; i++)
        {
            currentAge = familyList[i].Age;
            if (currentAge > oldest)
            {
                oldestGuy = familyList[i];
                oldest = currentAge;
            }
        }
        return oldestGuy;
    }
}

