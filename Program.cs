using System;

public class Dipendente
{
    private string nome;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    private int eta;
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

    public virtual void EseguiCompito()
    {
        Console.WriteLine("Compito generico del dipendente");
    }
}
