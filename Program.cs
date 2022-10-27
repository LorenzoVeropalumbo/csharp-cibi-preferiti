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
//scorro l'array
int index2 = 1;
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    //verifico che non sia il primo o l'ultimo elemento
    if (i > 1 && i < cibiPreferiti.Length - 2)
    {
        Console.WriteLine(index2++ + ") " + cibiPreferiti[i]);
    }

    index2++;
}

//modo alternativo
Console.WriteLine((cibiPreferiti.Length / 2 + 1) + ") " + cibiPreferiti[cibiPreferiti.Length/2]);