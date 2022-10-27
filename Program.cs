// See https://aka.ms/new-console-template for more information

// crezione dell'array dei cibi preferiti
string[] cibiPreferiti = { "carbonara", "pizza", "sushi", "patatine fritte", "pancake" };

//stampo la lunghezza dell'array
Console.WriteLine(cibiPreferiti.Length + " questa è la lunghezza della classifica dei cibi");

//stampo l'array come una classifica
for(int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(i+")" + cibiPreferiti[i]);
}

//stampo la prima posizione
Console.WriteLine(cibiPreferiti[0] + " questa è il mio cibo preferito");

//stampo l' ultima posizione
Console.WriteLine(cibiPreferiti[1] + " questa è il mio cibo preferito");