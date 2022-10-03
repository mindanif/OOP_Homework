using System.Collections.Immutable;
using System.Security.Cryptography;

string anagram(string str1, string str2)
{
    foreach (char i in str1)
    {
        if (i != ' ' && i != '\n')
        {
            if (!(str2.Contains(i)))
            {
                return "no";
            }
            else
            {
                str2 = str2.Remove(str2.IndexOf(i), 1);
            }
            
        }

    }
    str2 = str2.Replace(" ", String.Empty);
    if (String.IsNullOrEmpty(str2))
    {
        return "yes";
    }
    return "no";
}

int[] seq(int[] arr)
{
    Array.Sort(arr);
    int[] max = {0, 0};
    int[] mid = { arr[0], 0 };
    
    foreach(int i in arr)
    {
        if (i == mid[0])
        {
            mid[1] = i;
            continue;
        }
        if (i == mid[1] + 1)
        {
            mid[1] = i;
            continue;
        }
        else if(i == mid[1])
        {
            continue;
        }
        

        
    }
    if (max[1] - max[0] < mid[1] - mid[0])
    {
        max[1] = mid[1];
        max[0] = mid[0];
    }
    return max;
}




string str = Console.ReadLine();
int[] nums = str
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .ToArray();

 int[] a =  seq(nums);
Console.WriteLine(a[0]);
Console.WriteLine(a[1]);

Console.ReadLine();
