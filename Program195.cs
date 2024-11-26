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
        node temp = null;
        temp = First;

        while(temp != null)
        {
            Console.Write("|"+temp.data+"|->");
            temp = temp.next;
        }
        Console.Write("null\n");
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

    public int SearchLastOcc(int iNo)
    {
        node temp = null;
        temp = First;
        int iCnt = 1;
        int iPos = -1;

        while(temp != null)
        {
            if(temp.data == iNo)
            {
                iPos = iCnt;
            }
            iCnt++;
            temp = temp.next;
        }
        return iPos;
    }
}

class Program195
{
    static void Main(string[] Argv)
    {
        SinglyLL obj = new SinglyLL();
        int iRet = 0;

        obj.InsertFirst(101);
        obj.InsertFirst(11);
        obj.InsertFirst(101);
        obj.InsertFirst(51);
        obj.InsertFirst(11);

        obj.Display();
        iRet = obj.Count();
        Console.WriteLine("Last occurance is : "+iRet);

        iRet = obj.SearchLastOcc(101);
        Console.WriteLine("Last occurance is : "+iRet);
    }
}