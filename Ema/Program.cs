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
    public Dipendente(string _nome, int _eta)
    {
        nome = _nome;
        eta = _eta;
    }
}

//classe figlia del Dipendente
public class OperatoreCentrale : Dipendente
{
    //proprieta privata
    private string Turno = "";
    //proprieta pubblica con get set
    public string turno
    {
        get
        {
            return Turno;
        }
        set
        {
            if (turno == "Giorno")
            {
                return "Giorno";
            }
            if (turno == "Notte")
            {
                return "Notte";
            }
        }
    }
    //classe ereditata dalla classe madre
    public override void EseguiCompito()
    {
        // base.EseguiCompito();
        Console.WriteLine($"{Turno}");
    }
}