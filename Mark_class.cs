class Mark(string name1, int mark1)
{
    public string name = name1;
    public int mark = mark1;
    public static void ProstoTak()
    {
        Console.WriteLine("Ne znau kak primenit v zadanii");
    }
    public void Pr()
    {
        Console.WriteLine($"Name: {name}  Mark: {mark}");
    }
    public string Pb()
    {
        if (mark < 4) return "2";
        else if (mark < 6) return "3";
        else if (mark < 8) return "4";
        else return "5";
    }
    public void Zagl()
    {
        name = name.ToUpper();
    }
    public void Obnull()
    {
        mark = 0;
    }
    public int Len()
    {
        return name.Length;
    }
    public bool Nedopsa()
    {
        if (mark < 4) return false;
        else return true;
    }
    public void newName(string newName)
    {
        name = newName;
    }
    public static bool operator <=(Mark m1, Mark m2)
    {
        if (m1.mark <= m2.mark) return true;
        else return false;
    }
    public static bool operator >=(Mark m1, Mark m2)
    {
        if (m1.mark >= m2.mark) return true;
        else return false;
    }
}