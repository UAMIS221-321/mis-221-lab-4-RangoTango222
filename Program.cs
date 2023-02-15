//Main

Choice();

//Methods
static void Choice()
{
    Console.WriteLine("Type 1 to see a full triangle, Type 2 to see a partial triangle, and type 3 to exit.");
    string C = Console.ReadLine();
    if (C =="1")
    {GetFull();}
    if (C =="2")
    {GetPartial();}
    if (C != "1"||C !="2")
    {Console.WriteLine("System is shutting down.....");}
}

static void GetFull()
{
    Random rand = new Random();
    int number = rand.Next(3,10);
    int num = number;
    int a = 1;
    for(int i = 0; i<num;i++)
    {
        string step = new string('a',a);
        Console.WriteLine(step);
        a = a +1;
        
    }
}

static void GetPartial()
{
    Random rane = new Random();
    int numbe = rane.Next(3,10);
    int numb = numbe;
    int b = 1;
    for(int i = 0; i<numb;i++)
    {
        Random ran = new Random();
        int nu = ran.Next(0,2);
        if(nu == 1)
        {   
            string st = new string('a',b);
            Console.WriteLine(st);
        }
        else
        {Console.WriteLine(" ");}
        b = b +1;
    }
}