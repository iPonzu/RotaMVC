using System;
using System.Collections.Generic;

namespace Model
{
    public class Caminhao
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string NomeMotorista { get; set; }

        public static List<Caminhao> Caminhoes { get; set; } = new List<Caminhao>();

        public Caminhao(int id, string placa, string nomemotorista)
        {
            Id = id;
            Placa = placa;
            NomeMotorista = nomemotorista;

            Caminhoes.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Placa: {Placa}, Motorista: {NomeMotorista},";
        }

        public static void AlterarCaminhao(
            int id,
            string placa,
            string nomemotorista
        )
        {
            Caminhao caminhao = BuscarCaminhao(id);
            caminhao.Placa = placa;
            caminhao.NomeMotorista = nomemotorista;
        }

        public static void ExcluirCaminhao(int id)
        {
            Caminhao caminhao = BuscarCaminhao(id);
            Caminhoes.Remove(caminhao);
        }

        public static Caminhao BuscarCaminhao(int id)
        {
            Caminhao? caminhao = Caminhoes.Find(c => c.Id == id);
            if (caminhao == null) {
                throw new Exception("Caminhão não encontrado");
            }

            return caminhao;
        }
    }
}