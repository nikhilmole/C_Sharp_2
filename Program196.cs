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

    public void Display()
    {
        node temp = First;
        
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

    public int Addition()
    {
        node temp = First;
        int iAdd = 0;
        while(temp != null)
        {
            iAdd = iAdd + temp.data;
            temp = temp.next;
        }
        return iAdd;
    }
}

class Program196
{
    static void Main(String[] Argv)
    {
        SinglyLL obj = new SinglyLL();

        int iRet = 0;

        obj.InsertFirst(5);
        obj.InsertFirst(4);
        obj.InsertFirst(3);
        obj.InsertFirst(2);
        obj.InsertFirst(1);

        obj.Display();
        iRet = obj.Count();
        Console.WriteLine("The node count is : "+iRet);

        iRet = obj.Addition();
        Console.WriteLine("The node Addition is : "+iRet);
    }
}