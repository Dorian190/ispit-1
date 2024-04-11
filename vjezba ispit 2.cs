using System;

public class Sport
{
    private string Naziv;
    private bool IgraLiSeLoptom;
    private byte BrojIgraca;

   
    public Sport(string naziv)
    {
        Naziv = naziv;
        IgraLiSeLoptom = true; 
        BrojIgraca = 22; 
    }

    public Sport(string naziv, bool igraLiSeLoptom)
    {
        Naziv = naziv;
        IgraLiSeLoptom = igraLiSeLoptom;
        BrojIgraca = 14; 
    }

    public Sport(string naziv, bool igraLiSeLoptom, byte brojIgraca)
    {
        Naziv = naziv;
        IgraLiSeLoptom = igraLiSeLoptom;
        BrojIgraca = brojIgraca;
    }

    
    public void IspisiInformacije()
    {
        Console.WriteLine($"Naziv: {Naziv}, Igra li se loptom: {IgraLiSeLoptom}, Broj igrača: {BrojIgraca}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Sport nogomet = new Sport("Nogomet");
        Sport vaterpolo = new Sport("Vaterpolo", true);
        Sport curling = new Sport("Curling", false, 8);

        
        Console.WriteLine("Informacije o sportovima:");
        nogomet.IspisiInformacije();
        vaterpolo.IspisiInformacije();
        curling.IspisiInformacije();

        
        Console.ReadLine();
    }
}
