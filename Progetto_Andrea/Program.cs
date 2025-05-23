using System;

public class Dipendente
{
    private string nome;
    private int eta;

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

public class Meccanico : Dipendente
{
    private string specializzazione;

    public string Specializzazione
    {
        get { return specializzazione; }
        set { specializzazione = value; }
    }

    public Meccanico(string _nome, int _eta, string _specializzazione) : base(_nome, _eta)
    {
        Specializzazione = _specializzazione;
    }
    public override void EseguiCompito()
    {
        Console.WriteLine($"Ripara mezzi specializzati in: {Specializzazione}.");
    }
}

