// See https://aka.ms/new-console-template for more information

// crezione dell'array dei cibi preferiti
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

//CICLO FOR

/*Il software deve chiedere per 10 volte all’utente di inserire un numero.
Il programma stampa la somma di tutti i numeri inseriti.*/

/*int[] numeri */
int totalSum = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("insert a numeber");
    int numberToSum = Convert.ToInt32(Console.ReadLine());
    totalSum += numberToSum;
}

Console.WriteLine("your total sum is {0}", totalSum);