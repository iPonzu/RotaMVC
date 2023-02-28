using System;

namespace Model{
    public class Cidade{

        public int idCidade {get; set;}

        public string Nome {get; set;}

        public static List<Cidade> Cidades{get; set;} = new List<Cidade>();


        public Cidade (int IdCidade, string nome)
        {
            IdCidade = idCidade;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Id: {idCidade}, Nome: {Nome}";
        }

        public static void AlterarCidade(
        int idCidade, string nome)
        {
            Cidade cidade = BuscarCidade(idCidade);
        }
        public static BuscarCidade(            
            )

    }
}