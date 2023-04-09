class studenta
{
    public string Name;
    public string Surname;
    public string Group;
    public int Point;
    public bool isgraduated;
    int yearofstudy = 3;

    public studenta(string name, string Surname, string group, int point)

    {
        this.Name = name;
        this.Surname = Surname;
        this.Group = group;
        this.Point = point;
        this.isgraduated = false;
    }
    public studenta(string name, string Surname)
    {
        this.Name = name;
        this.Surname = Surname;
    }

    public void getfullname()
    {

        Console.WriteLine($"{this.Name} {this.Surname}");

    }
    public void getfullinfo1()
    {
        Console.WriteLine($"{this.Name} {this.Surname} {this.Group} {this.Point}");
        if (yearofstudy > 4)
        {
            isgraduated = true;
            Console.WriteLine("mezun olub oturub evde deyir is yoxdu");

        }
        Console.WriteLine("mezun olmuyuf hele oxuyur akademik olajax");
        if (Point > 80)
        {
            Console.WriteLine("imtahan seni gozleyir.ugurlar");
        }
        else
        {
            Console.WriteLine("bextivi bir daha yoxla");
        }

    }
}