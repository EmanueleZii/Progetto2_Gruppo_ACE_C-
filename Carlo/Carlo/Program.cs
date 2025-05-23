using System;

//Creazione della classe base
public class Dipendente
{
    //Dichiarazione attributi
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
    //Metodo di stampa basico che verrà sovrascritto dalle derivate
    public virtual void EseguiCompito()
    {
        Console.WriteLine("Compito generico del dipendente");
    }
    //Costruttore che dichiara le variabili
    public Dipendente(string nome, int eta)
    {
        Nome = nome;
        Eta = eta;
    }
}
//Creazione classe derivata
public class Autista : Dipendente
{
    private string patente;
    public string Patente
    {
        get { return patente; }
        set { patente = value; }
    }
    //Costruttore che dichiara i valori della derivata
    public Autista(string nome, int eta, string patente) : base(nome, eta)
    {
        Patente = patente;
    }
    //Sovrascrittura del metodo di stampa
    public override void EseguiCompito()
    {
        Console.WriteLine($"{Nome} sta guidando il veicolo con la patente {Patente}");
    }
}

