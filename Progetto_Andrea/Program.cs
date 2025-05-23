using System;

public class Dipendente
{
    //attributi privati
    private string nome;
    private int eta;

    //proprietà pubbliche
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public int Eta
    {
        get { return eta; }
        set
        {
            if (value >= 18)
            {
                eta = value;
            }
            else
            {
                Console.WriteLine("Età non consentita");
            }
        }
    }

    //costruttore
    public Dipendente(string _nome, int _eta)
    {
        Nome = _nome;
        Eta = _eta;
    }
    public virtual void EseguiCompito()
    {
        Console.WriteLine("Compito generico del dipendente.");
    }
}

//classe derivata 
public class Meccanico : Dipendente
{
    //attributi privati
    private string specializzazione;

    //proprietà pubbliche
    public string Specializzazione
    {
        get { return specializzazione; }
        set { specializzazione = value; }
    }

    //costruttore
    public Meccanico(string _nome, int _eta, string _specializzazione) : base(_nome, _eta)
    {
        Specializzazione = _specializzazione;
    }
    public override void EseguiCompito()
    {
        Console.WriteLine($"Ripara mezzi specializzati in: {Specializzazione}.");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<Dipendente> dipendenti = new List<Dipendente>();
        bool exit = false;

        while (!exit)
        {
            
        }
    }
}