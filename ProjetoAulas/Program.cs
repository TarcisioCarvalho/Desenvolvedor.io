// See https://aka.ms/new-console-template for more information
using System.Collections;

/* var arrayList = new ArrayList();
arrayList.Add("Teste");

System.Console.WriteLine(arrayList[0]);

var tipado = new int[2];

System.Console.WriteLine(tipado[0]);
 */

/*  Dictionary<int,string> dictionary = new Dictionary<int, string>();
 dictionary.Add(1,"Teste");
 dictionary.Add(2,"Teste2"); */

 //System.Console.WriteLine(dictionary[1]);

 /* foreach (var item in dictionary)
 {
    System.Console.WriteLine(item);
 } */

 Queue<string> fila = new Queue<string>();

 fila.Enqueue("1");
 fila.Enqueue("2");
 fila.Dequeue();

 foreach (var item in fila)
 {
    System.Console.WriteLine(item);
 }