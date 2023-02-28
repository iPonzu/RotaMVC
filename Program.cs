using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace rotamvc{
    public class Program{
        public static void Main(string[] args){
            List<Caminhao> caminhoes = new List<Caminhao>();
            caminhoes.Add(new Caminhao(202301, "KLA-0944", "Lucas"));
            caminhoes.Add(new Caminhao(202302, "NIW5H24", "Felipe"));
            caminhoes.Add(new Caminhao(202303, "RLG8G20", "Carlos"));
            caminhoes.Add(new Caminhao(202304, "NHJ9Y00", "Eduardo"));
            caminhoes.Add(new Caminhao(202305, "RDS4D70", "Bruno"));
            caminhoes.Add(new Caminhao(202306, "MVE7D17", "Fernando"));

            IEnumerable<Caminhao> Volvo = from Caminhao in caminhoes
                where Caminhao.NomeMotorista == "Felipe"
                select Caminhao;

            foreach(Caminhao caminhao in Volvo){
                Console.WriteLine(caminhao.Id);
                Console.WriteLine(caminhao.Placa);
                Console.WriteLine(caminhao.NomeMotorista);
            }    

            Caminhao gol = (from Caminhao in caminhoes
                            where Caminhao.NomeMotorista == "Felipe"
                            select Caminhao).First();

            int id = (from Caminhao in caminhoes
                      where Caminhao.Id == 202302
                      select Caminhao).Count();            

        

        }
    }    
}