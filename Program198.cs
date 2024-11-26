using System;

class node
{
    public node next;
    public int data;

    public node(int iNo)
    {
        next = null;
        data = iNo;
    }
}

class SinglyLL
{
    public node First;
    public int iCnt;

    public SinglyLL()
    {
        First = null;
        iCnt = 0;
    }

    public void Display()
    {
        node temp = First;

        if(temp == null)
        {
            Console.WriteLine("The LL is empty");
            return;
        }
        while(temp != null)
        {
            Console.Write("|"+temp.data+"|->");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }

    public int Count()
    {
        return iCnt;
    }

    public void InsertFirst(int iNo)
    {
        node newn = new node(iNo);

        if(First == null)
        {
            First = newn;
        }
        else
        {
            newn.next = First;
            First = newn;
        }

        iCnt++;
    }

    public int Min()
    {
        int iMin = 0;
        int iMax = 0;

        node temp = First;

        while(temp != null)
        {
            iMin = temp.data;

            if(iMax > iMin)
            {
                iMin = iMax;
            }
            temp = temp.next;
        }
        return iMin;
    }   
}

class Program197
{
    static void Main(String[] argv)
    {
        SinglyLL obj = new SinglyLL();
        int iRet = 0;

        obj.InsertFirst(11);
        obj. InsertFirst(101);
        obj.InsertFirst(201);
        obj.InsertFirst(111);
        obj.InsertFirst(51);

        obj.Display();
        iRet = obj.Count();
        Console.WriteLine("The node couont is :"+iRet);

        iRet = obj.Min();
        Console.WriteLine("The min number is : "+iRet);
    }
}