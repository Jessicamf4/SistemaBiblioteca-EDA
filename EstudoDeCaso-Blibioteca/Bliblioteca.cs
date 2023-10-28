using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDeCaso_Blibioteca
{
    internal class Biblioteca
    {

        private Livro[] livros;
        private int quantidade;

        public Biblioteca(int capacidade)
        {
            livros = new Livro[capacidade];
            quantidade = 0;
        }

        public void AdicionarLivro(string titulo, string autor, int isbn)
        {
            if (quantidade < livros.Length)
            {
                Livro novoLivro = new Livro(titulo, autor, isbn);
                livros[quantidade] = novoLivro;
                quantidade++;
                OrdenarPorNome();
                OrdenarPorAutor();
            }
            else
            {
                Console.WriteLine("Biblioteca cheia. Impossível adicionar mais livros.");
            }
        }

        public void RemoverLivro(string titulo)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (String.Compare(livros[i].Titulo, titulo, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    for (int j = i; j < quantidade - 1; j++)
                    {
                        livros[j] = livros[j + 1];
                    }
                    quantidade--;
                    Array.Resize(ref livros, quantidade);
                    return;
                }
            }
            Console.WriteLine("Livro não encontrado.");
        }

        public void EmprestarLivro(string titulo)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (String.Compare(livros[i].Titulo, titulo, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    livros[i].Disponivel = false;
                    return;
                }
                Console.WriteLine("Livro não encontrado.");
            }
            
        }

        public void DevolverLivro(string titulo)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (String.Compare(livros[i].Titulo, titulo, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    livros[i].Disponivel = true;
                    return;
                }
                Console.WriteLine("Livro não encontrado.");
            }
            
        }

        public void BuscarPorTitulo(string titulo)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (String.Compare(livros[i].Titulo, titulo, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    Console.WriteLine(livros[i]);
                }
                Console.WriteLine("Não foi possível encontrar o livro.");
            }

        }

        public void BuscarPorAutor(string autor)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (String.Compare(livros[i].Autor, autor, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    Console.WriteLine(livros[i]);
                }
                Console.WriteLine("Não foi possível encontrar o livro.");
            }
        }

        public void OrdenarPorNome()
        {
            for (int i = 1; i < quantidade; i++)
            {
                Livro chave = livros[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(livros[j].Titulo, chave.Titulo, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    livros[j + 1] = livros[j];
                    j = j - 1;
                }

                livros[j + 1] = chave;
            }
        }

        public void OrdenarPorAutor()
        {
            for (int i = 1; i < quantidade; i++)
            {
                Livro chave = livros[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(livros[j].Autor, chave.Autor, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    livros[j + 1] = livros[j];
                    j = j - 1;
                }

                livros[j + 1] = chave;
            }
        }

        public void ImprimeLista()
        {
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine(livros[i]);
            }

        }
    }
}
    



