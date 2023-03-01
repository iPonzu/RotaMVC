using System;

namespace Model{
    public class Cidade{

        public int IdCidade {get; set;}

        public string Nome {get; set;}

        public static List<Cidade> Cidades{get; set;} = new List<Cidade>();


        public Cidade (int idCidade, string nome)
        {
            IdCidade = idCidade;
            Nome = nome;

            Cidades.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {IdCidade}, Nome: {Nome}";
        }

        public static void AlterarCidade(
            int idCidade, 
            string nome
        )
        {
            Cidade cidade = BuscarCidade(idCidade);
            cidade.Nome = nome;
        }
        public static void ExcluirCidade(int id)
        {
            Cidade cidade = BuscarCidade(id);
            Cidades.Remove(cidade);
        }
        public static Cidade BuscarCidade(int id)
        {
            Cidade? cidade = Cidades.Find(c => c.IdCidade == id);
            if (cidade == null)
            {
                throw new Exception ("Cidade não encontrada");
            }
            return cidade;
        }
    }
}
