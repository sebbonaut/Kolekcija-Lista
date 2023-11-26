using Kolekcija_Lista;

List<Artikl> artikli = new()
{
    new("jabuka", 1.19),
    new("mandarine", 0.79)
};
artikli.TrimExcess(); //artikli.Capacity = 2;
artikli.Add(new("kivi", 1.49));
artikli.Insert(1, new("orah jezgra 500g", 4.99));
Console.WriteLine(artikli.Count + " " + artikli.Capacity);
//Console.WriteLine(artikli[1]);
foreach (Artikl artikl in artikli)
{
    Console.WriteLine(artikl);
}
/* Console.WriteLine("-----Nakon izbacivanja-----");
artikli.RemoveAt(0);
artikli.Remove(new("orah jezgra 500g", 4.99));
foreach (Artikl artikl in artikli)
{
    Console.WriteLine(artikl);
} */
Kosarica kosarica = new(artikli);
Console.WriteLine(kosarica);
/*Console.WriteLine("U kosarici kosarica:");
foreach (Artikl artikl in kosarica)
    Console.WriteLine(artikl);*/
Console.WriteLine("Vrijednost kosarice: " + kosarica.Vrijednost);

/*Console.Write("Unesi limit: ");
double limit = Convert.ToDouble(Console.ReadLine());
//kosarica.UkloniPreskupe(limit);
kosarica.UkloniVisak(limit);
Console.WriteLine(kosarica);

Console.WriteLine("-----Tri najjeftinija artikla:-----");
foreach (Artikl artikl in kosarica.TriNajjeftinija)
    Console.WriteLine(artikl);

List<Artikl> novi = new()
{
    new("avokado", 0.99),
    new("donut", 0.55)
};
Kosarica nova = new(novi);
artikli.AddRange(nova);
Console.WriteLine("----Elementi liste artikli:----");
foreach (var item in artikli)
{
    Console.WriteLine(item);
}*/

LinkedList<Artikl> lista = new();
lista.AddFirst(new Artikl("ketchup", 1.99));
if (lista.First is not null)
    lista.AddAfter(lista.First, new Artikl("jogurt jagoda", 0.6));
lista.AddBefore(lista.First!.Next!, new Artikl("vocni pire", 0.89));
Console.WriteLine("Br. elemenata: " + lista.Count);
Console.WriteLine("Elementi vezane liste:");
foreach (Artikl artikl in lista)
{
    Console.WriteLine(artikl);
}

Artikl a = new("jogurt jagoda", 0.6);
if(lista.Contains(a))
{
    LinkedListNode<Artikl>? cvor = lista.Find(a);
    Console.WriteLine(cvor);
    Console.WriteLine(cvor!.Value);
    lista.Remove(cvor);
    lista.AddFirst(cvor);
}
Console.WriteLine("Elementi vezane liste nakon promjene:");
foreach (var item in lista)
{
    Console.WriteLine(item);
}