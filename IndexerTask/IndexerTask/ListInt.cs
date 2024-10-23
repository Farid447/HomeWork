using System;

namespace IndexerTask;

internal class ListInt
{
    private int[] nums = new int[0];
    public int this[int index]
    {
        get { return nums[index]; }
        set
        {
            if (index < nums.Length && index >= 0) nums[index] = value;
            else Console.WriteLine("Out of range");
        }
    }

    public void Add(int num)
    {
        Array.Resize(ref nums, nums.Length + 1);
        nums[nums.Length - 1] = num;
    }

    public void Add(params int[] numbers)
    {
        Array.Resize(ref nums, nums.Length + numbers.Length);
        for (int i = 0; i < numbers.Length; i++)
        {

            nums[nums.Length + i] = numbers[i];
        }
    }

    public bool Contains(int num)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == num)
                return true;
        }
        return false;
    }

    public int Pop()
    {
        if (nums.Length == 0)
        {
            Console.WriteLine("array bosdur");
            return -1;
        }

        int lastnum = nums[nums.Length - 1];
        Array.Resize(ref nums, nums.Length - 1);
        return lastnum;
    }

    public int Sum()
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    public int IndexOf(int num)
    {
        for(int i=0; i<nums.Length; i++)
        {
            if (nums[i] == num)
            {
                return i;
            }
        }
        Console.WriteLine("eded yoxdur");
        return -1;

    }

    public int LastIndexOf(int num)
    {
        for (int i = nums.Length-1; i >=0 ; i--)
        {
            if (nums[i] == num)
            {
                return i;
            }
        }
        Console.WriteLine("eded yoxdur");
        return -1;
    }

    public void Insert(int num, int index)
    {
        Array.Resize(ref nums, nums.Length + 1);
        for(int i  = nums.Length-2; i >= index; i--)
        {
            nums[i+1]= nums[i];
        }
        nums[index] = num;
    }

    public float Average()
    {
        float sum = 0;
        foreach (float i in nums) { 
            sum+= i;
        }
        return sum/nums.Length;
    }

    public override string ToString()
    {
        string str = "";
        for (int i = 0; i < nums.Length; i++)
            str += (nums[i] + " ");

        return str;
    }
}