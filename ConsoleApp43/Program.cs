internal class Program
{
    public static void Main()
    {

        Om om1 = new Om();

        om1.varsta = 29;
        om1.inaltimeCM = 180;
        om1.nume = "Romeo Cosma";
        om1.Print();


        Om om2 = new Om();

        om2.varsta = 7;
        om2.inaltimeCM = 120;
        om2.nume = "Stefan";
        om2.Print();

        Om om3 = new Om();
        om3.nume = "Vecinul";
        om3.varsta = 65;
        om3.inaltimeCM = 190;
        om3.Print();
        om1.Print();

        European european = new European();
        european.nume = "un european";
        european.varsta = 70;
        european.Print();

        Roman roman = new Roman();
        roman.nume = "Vasile";
        roman.varsta = 30;
        roman.Print();
    }
}
public class Om
{
    public int varsta;
    public int inaltimeCM;
    public string nume;

    public void Print()
    {
        Console.WriteLine(string.Format("{0} are varsta {1} si inaltimea de {2} cm", nume, varsta, inaltimeCM));

    }
}

public class European : Om
{
    public string continent = "Europa";
}

public class Roman : European
{
    public string limba = "romana";
}