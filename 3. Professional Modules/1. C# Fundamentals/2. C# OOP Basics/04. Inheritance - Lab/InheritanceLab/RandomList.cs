using System;
using System.Collections.Generic;
using System.Text;


public class RandomList : List<string>
{
    public string RandomString(RandomList randomList)
    {
        Random randomNum = new Random();
        int aRandomPos = randomNum.Next(randomList.Count);
        string randomString = randomList[aRandomPos];
        return randomString;
    }
}

