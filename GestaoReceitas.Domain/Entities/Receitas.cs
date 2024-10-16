using GestaoReceitas.Domain.Enums;
using System.Collections.Generic;
using System.Security.Policy;

namespace GestaoReceitas.Domain.Entities
{
    public class Receitas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Users Autor { get; set; }
        public List<Ingredientes> Ingredientes { get; set;}
        public string Descrição { get; set; }
        public DificuldadeEnum Dificuldade { get; set;}
        public CategoriaReceitaEnum CategoriaReceita { get; set;}
        public double Tempo { get; set; }
        public double Custo { get; set; }
    }
}
