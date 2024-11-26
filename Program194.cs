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

    public void InsertFirst(int iNo)
    {
        node newn = null;
        newn = new node(iNo);

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

    public int Count()
    {
        return iCnt;
    }

    public void Display()
    {
        node temp = null;
        temp = First;

        while(First != null)
        {
            Console.Write("|"+temp.data+"|->");
            temp = temp.next;
        }
    }
    public int SearchFirstOcc(int iNo)
    {
        node temp = null;
        temp = First;
        int iPos = 0;

        while(temp != null)
        {
            if(temp.data == iNo)
            {
                return iPos;
            }
            iPos++;
            temp = temp.next;
        }
        return -1;
    }
}

class Program194
{
    static void Main(string[] Argv)
    {
        SinglyLL obj = new SinglyLL();

        int iRet = 0;

        obj.InsertFirst(70);
        obj.InsertFirst(60);
        obj.InsertFirst(50);
        obj.InsertFirst(40);
        obj.InsertFirst(30);
        obj.InsertFirst(20);
        obj.InsertFirst(10);
        
        obj.Display();
        iRet = obj.Count();
        Console.WriteLine("The Node count is : "+iRet);

        iRet = obj.SearchFirstOcc(30);
        Console.WriteLine("First occurance is : "+iRet);
    }
}