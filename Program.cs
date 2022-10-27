// See https://aka.ms/new-console-template for more information

// crezione dell'array dei cibi preferiti
using System;
using System.Xml.Linq;

string[] cibiPreferiti = { "carbonara", "pizza", "sushi", "patatine fritte", "pancake" };

//stampo la lunghezza dell'array
Console.WriteLine(cibiPreferiti.Length + " questa è la lunghezza della classifica dei cibi");

//variabile per contare l'array
int index = 1;
//stampo l'array come una classifica
for(int i = 0; i < cibiPreferiti.Length; i++)
{   
    
    Console.WriteLine(index+") " + cibiPreferiti[i]);
    index++;
}

//stampo la prima posizione
Console.WriteLine(cibiPreferiti[0] + " questa è il mio cibo preferito");

//stampo l' ultima posizione
Console.WriteLine(cibiPreferiti[cibiPreferiti.Length - 1] + " questa è il mio cibo preferito ma non troppo");

//Bonus
//modo1
Console.WriteLine((cibiPreferiti.Length / 2 + 1) + ") " + cibiPreferiti[cibiPreferiti.Length/2]);

//soluzine di paolo
if(cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine((cibiPreferiti.Length / 2 + 1) + ") " + cibiPreferiti[cibiPreferiti.Length / 2]);
    Console.WriteLine((cibiPreferiti.Length / 2 + 1) + ") " + cibiPreferiti[cibiPreferiti.Length / 2 - 1]);

} else
{
    Console.WriteLine((cibiPreferiti.Length / 2 + 1) + ") " + cibiPreferiti[cibiPreferiti.Length / 2]);
}


//Snack ISTRUZIONI CONDIZIONALI
{ 
    /*L’utente inserisce due numeri in successione.
    Il software stampa il maggiore.*/

    //ask 2 numbers from the console
    Console.WriteLine("inserisci un numero");
    int primoNumero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("inserisci un altro numero");
    int secondoNumero = Convert.ToInt32(Console.ReadLine());

    //check if the numbers are the same value
    if(primoNumero != secondoNumero)
    {
        //check if the first is bigger then the second
        if (primoNumero > secondoNumero)
        {
            Console.WriteLine("il primo numero è maggiore del secondo");
        } else
        {
            Console.WriteLine("il secondo numero è maggiore del primo");
        }
    }
    else
    {
        Console.WriteLine("i numeri sono uguali");
    }
}
{ 
    /*L’utente inserisce due parole in successione.
    Il software stampa prima la parola più corta, poi la parola più lunga.*/

    //ask 2 numbers from the console
    Console.WriteLine("insert a word");
    string firstWord = Console.ReadLine();

    Console.WriteLine("insert another word");
    string secondWord = Console.ReadLine();


    if (firstWord.Length != secondWord.Length)
    {
        //check if the first is bigger then the second
        if (firstWord.Length > secondWord.Length)
        {
            Console.WriteLine("the first is bigger then the second");
        }
        else
        {
            Console.WriteLine("the second is bigger then the first");
        }
    }
    else
    {
        Console.WriteLine("the word have the same length");
    }
}

//CICLO FOR
{ 
    /*Il software deve chiedere per 10 volte all’utente di inserire un numero.
    Il programma stampa la somma di tutti i numeri inseriti.*/

    int totalSum = 0;

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("insert a numeber");
        int numberToSum = Convert.ToInt32(Console.ReadLine());
        totalSum += numberToSum;
    }

    Console.WriteLine("your total sum is {0}", totalSum);
}

{
    /*Calcola la somma e la media dei numeri da 2 a 10.*/
    int Media = 0;
    int TotalCicleDo = 0;
    for (int i = 2; i < 11; i++)
    {
        Media += i;
        TotalCicleDo++;
    }

    float Total = Media / TotalCicleDo;
    Console.WriteLine(Total + " è la tua media");
}


// OPERATORE MODULO
{
    Console.WriteLine("insert a numeber");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber % 2 == 0)
    {
        Console.WriteLine(userNumber);
    }
    else
    {
        Console.WriteLine(userNumber+1);
    }
}

//ARRAY

{
    /*In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
    Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla
    festa.*/

    string[] nomiInvitati = { "luca", "paolo", "lorenzo" };

    Console.WriteLine("scrivi il tuo nome");
    string UserName = Console.ReadLine();
    bool isIn = false;

    for (int i = 0; i < nomiInvitati.Length; i++)
    {
        if (nomiInvitati[i].Equals(UserName))
        {
            isIn = true;
        }
    }

    if (isIn)
    {
        Console.WriteLine("sei nella lista");
    } else
    {
        Console.WriteLine("non sei nella lista");
    }

}

{
    /* Crea un array vuoto.
    Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
    nell’array.*/
    int[] arrayToSave = new int[6];

    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine("scegli un numero");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        if(userNumber % 2 == 1) 
        {
            arrayToSave[i] = userNumber;
        }
     
    }

    for (int i = 0; i < arrayToSave.Length; i++)
    {
        Console.Write(arrayToSave[i] + "-");
    }
}

{
    /*Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
    posizione dispari.*/
    int[] arrayToSave = {1,2,3,4,5,6,7};
    int sum = 0;
    for (int i = 0; i < arrayToSave.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum += arrayToSave[i];
        }
    }

    Console.WriteLine(sum);
}

{
    /*Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
    Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
    somma degli elementi è minore di 50.*/

    int[] arrayToSave = new int[50];
    int sum = 0;
    int i = 0;
    while(sum < 49)
    {
        Console.WriteLine("scegli un numero");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        arrayToSave[i] = userNumber;
        sum += userNumber;
        i++;
        Console.WriteLine(sum + " somma attuale");
    }
}

{
    /*Fai inserire un numero, che chiameremo N, all’utente.
    Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
    Ogni volta che ne crei uno, stampalo a schermo.*/

    Console.WriteLine("scegli un numero");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < userNumber; i++)
    {
        int[] arrayToSave = new int[10];
        
        for (int j = 0; j < arrayToSave.Length; j++)
        {
            Random rd = new Random();
            arrayToSave[i] = rd.Next(1, 100);
            Console.Write(arrayToSave[i] + "-");
        }
        Console.WriteLine();
    }
}