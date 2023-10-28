using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDeCaso_Blibioteca
{
    internal class Livro 
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public bool Disponivel { get; set; }

        public Livro(string nome, string autor, int iSBN)
        {
            Titulo = nome;
            Autor = autor;
            ISBN = iSBN;
            Disponivel = true;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor} - {ISBN} ISBN - {(Disponivel ? "Disponível" : "Não disponível")}";
        }
    }
}
