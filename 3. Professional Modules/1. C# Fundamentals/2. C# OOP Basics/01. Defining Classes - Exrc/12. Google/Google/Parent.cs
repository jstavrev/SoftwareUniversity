using System;
using System.Collections.Generic;
using System.Text;


class Parent
{
    private string parentName;
    private string parentBirthday;

    public Parent(string parentName, string parentBirthday)
    {
        this.ParentName = parentName;
        this.ParentBirthday = parentBirthday;
    }

    public string ParentBirthday
    {
        get { return parentBirthday; }
        set { parentBirthday = value; }
    }

    public string ParentName
    {
        get { return parentName; }
        set { parentName = value; }
    }
}

