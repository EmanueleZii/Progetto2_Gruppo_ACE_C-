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

    public virtual void StampaInfo()
    {
        Console.Write($"Nome: {Nome}, età: {Eta}");
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

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.Write($", specializzazione: {Specializzazione}\n");
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

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.Write($", patente: {Patente}\n");
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
            if (turno == "Giorno" && turno == "giorno")
            {
                Turno = "Giorno";
            }
            if (turno == "Notte" && turno == "notte")
            {
                Turno = "Notte";
            }
        }
    }
    //classe ereditata dalla classe madre
    public override void EseguiCompito()
    {
        Console.WriteLine($"Gestisce le comunicazioni in turno: {Turno}");
    }
    public OperatoreCentrale(string nome, int eta, string _turno) : base(nome, eta)
    {
        Turno = _turno;
    }
    
    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.Write($", turno: {Turno}\n");
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
            Console.WriteLine("\n\nBenvenuto.");
            Console.WriteLine("[1] Aggiungi autista");
            Console.WriteLine("[2] Aggiungi meccanico");
            Console.WriteLine("[3] Aggiungi operatore centrale");
            Console.WriteLine("[4] Visualizza dipendenti");
            Console.WriteLine("[5] Esegui compiti");
            Console.WriteLine("[0] Esci");

            int menuAction = int.Parse(Console.ReadLine());

            switch (menuAction)
            {
                case 0:
                    exit = true;
                    break;

                case 1:
                    Console.Write("Inserisci nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Inserisci età: ");
                    int eta = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci patente: ");
                    string patente = Console.ReadLine();

                    dipendenti.Add(new Autista(nome, eta, patente));
                    break;

                case 2:
                    Console.Write("Inserisci nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Inserisci età: ");
                    eta = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci specializzazione: ");
                    string specializzazione = Console.ReadLine();

                    dipendenti.Add(new Meccanico(nome, eta, specializzazione));
                    break;

                case 3:
                    Console.Write("Inserisci nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Inserisci età: ");
                    eta = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci turno: ");
                    string input = Console.ReadLine();
                    string turno = "";

                    if (input.ToLower() == "giorno" || input.ToLower() == "notte")
                    {
                        turno = input;
                    }
                    else
                    {
                        Console.WriteLine("Turno non valido.");
                    }

                    dipendenti.Add(new OperatoreCentrale(nome, eta, turno));
                    break;

                case 4:
                    foreach (Dipendente d in dipendenti)
                    {
                        d.StampaInfo();
                    }
                    break;

                case 5:
                    foreach (Dipendente d in dipendenti)
                    {
                        d.EseguiCompito();
                    }
                    break;

                default:
                    Console.WriteLine("Azione non valida.");
                    break;
            }
        }
    }
}