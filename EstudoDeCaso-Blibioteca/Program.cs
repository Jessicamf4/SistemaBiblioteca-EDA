using System.Security.Cryptography.X509Certificates;

namespace EstudoDeCaso_Blibioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de livros que terão na biblioteca: ");
            int n = int.Parse(Console.ReadLine());

            Biblioteca biblioteca = new Biblioteca(n);

            Console.WriteLine("Digite quanto livros deseja adicionar: ");
            int m = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite o nome do livro");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o nome do autor");
                string autor = Console.ReadLine();
                Console.WriteLine("Digite o número do IBSN");
                int ibsn = int.Parse(Console.ReadLine());

                biblioteca.AdicionarLivro(nome, autor, ibsn);
            }

            Console.WriteLine("Agora escolha o tipo de ordenação dos livros: 1: por título do livro | 2: por nome do autor");
            int ordenacao = int.Parse(Console.ReadLine());

            void ordenaLista()
            {
                if (ordenacao == 1)
                {
                    biblioteca.OrdenarPorNome();
                }
                else
                {
                    biblioteca.OrdenarPorAutor();
                }
            }
            

            int opcao = 0;
            do
            {
                Console.WriteLine("Digite 1 - para remover livro | 2 - para adicionar livro | 3 - para emprestar | 4 - para devolver" +
                    " 5 - para Buscar por titulo do livro | 6 - para buscar por autor | 7 - Mostrar todos os livros | 8 - para sair ");
                opcao  = int.Parse(Console.ReadLine()); 

                if(opcao == 1)
                {
                    Console.WriteLine("Digite o nome do livro: ");
                    string str = Console.ReadLine();
                    biblioteca.RemoverLivro(str);
                    ordenaLista();
                }
                else if(opcao == 2)
                {
                    Console.WriteLine("Digite o nome do livro");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o nome do autor");
                    string autor = Console.ReadLine();
                    Console.WriteLine("Digite o nome do autor");
                    int ibsn = int.Parse(Console.ReadLine());

                    biblioteca.AdicionarLivro(nome, autor, ibsn);
                    ordenaLista();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Digite o nome do livro: ");
                    string str = Console.ReadLine();
                    biblioteca.EmprestarLivro(str);
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Digite o nome do livro: ");
                    string str = Console.ReadLine();
                    biblioteca.DevolverLivro(str);
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Digite o nome do livro: ");
                    string str = Console.ReadLine();
                    biblioteca.BuscarPorTitulo(str);
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("Digite o nome do título do livro: ");
                    string str = Console.ReadLine();
                    biblioteca.BuscarPorAutor(str);
                }
                else if (opcao == 7)
                {
                    ordenaLista();
                    biblioteca.ImprimeLista();
                }
            } while (opcao != 8);

           
        }

    }
}