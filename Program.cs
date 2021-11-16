using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha a estrutura de dados: ");
            Console.WriteLine("Stack [1]\nQueue[2]\nList[3]");
            int escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (escolha)
            {
                case <= 1:
                    StackExemplo();
                    break;
                case <= 2:
                    QueueExemplo();
                    break;
                case <= 3:
                    ListsExemplo();
                    break;
                case <= 4:
                    HashExemplos();
                    break;
                default:
                    Console.WriteLine("Entrada invalida");
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
            }
            


        }
        static void StackExemplo()
        {
            Stack<string> Pilha = new Stack<string>();

            Pilha.Push("A");
            Pilha.Push("B");
            Pilha.Push("C");
            Pilha.Push("D");
            Pilha.Push("E");
            Pilha.Push("F");

            for (int countpilha = Pilha.Count() ; countpilha > 0; countpilha--)
            {
                foreach (string i in Pilha)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("---------------------------------------------------\n");
                Console.WriteLine("Itens na pilha: " + Pilha.Count());
                Console.WriteLine("Excluindo o primeiro da pilha - " + Pilha.Peek());
                Console.ReadLine();
                Console.WriteLine("---------------------------------------------------\n");
                Console.Clear();
                Pilha.Pop();
            }
            
        }
        static void QueueExemplo()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("A");
            fila.Enqueue("B");
            fila.Enqueue("C");
            fila.Enqueue("D");
            fila.Enqueue("E");
            fila.Enqueue("F");

            for (int countFila = fila.Count(); countFila > 0; countFila--)
            {
                foreach (string i in fila)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("---------------------------------------------------\n");
                Console.WriteLine("Itens na fila: " + fila.Count());
                Console.WriteLine("Excluindo o primeiro da fila - " + fila.Peek());
                Console.ReadLine();
                Console.Clear();
                fila.Dequeue();
                Console.WriteLine("---------------------------------------------------\n");
            }

        }
        static void ListsExemplo()
        {
            List<String> lista = new List<string>();
            List<String> lista2 = new List<string>();
            lista.Add("A");
            lista.Add("B");
            lista.Add("C");
            lista.Add("D");
            lista.Add("E");
            lista.Add("F");

            lista2.AddRange(lista);

            foreach(string i in lista)
            {
                Console.WriteLine(i);
            }
            foreach(string i in lista2)
            {
                Console.WriteLine(i);
            }
            int tamanho = lista.Capacity;
            Console.WriteLine($" -------- {tamanho} -------------- ");

        }
        static void LinkedListsExemplo()
        {

        }
        static void HashExemplos()
        {
            HashSet<int> pares = new HashSet<int>();
            HashSet<int> impares = new HashSet<int>();

            for (int i = 0; i < 50; i++)
            {
                pares.Add(i * 2);
                impares.Add((i * 2) + 1);
            }

            foreach(int i in pares)
            {
                Console.WriteLine(i);
            }
            foreach (int i in impares)
            {

                Console.WriteLine(i);
            }
        }

    }


}
