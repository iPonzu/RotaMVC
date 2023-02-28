using System;

namespace Model
{
    public class Caminhao
    {
        
        public int Id {get; set;}
        public string Placa {get; set;}
        public string NomeMotorista {get; set;}
       

        public static List<Caminhao> Caminhaos{get; set;} = new List<Caminhao>();
        public Caminhao(int id, string placa, string nomemotorista)
        {
            Id = id;
            Placa = placa;
            NomeMotorista = nomemotorista;
            
        }
    }
}