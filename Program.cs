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