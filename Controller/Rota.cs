namespace Controller{
    public class Rota{
        public static void CadastrarRota(
            string id,
            string origemId,
            string destinoId,
            string caminhaoId,
            string data
        )
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(id);
            } catch (Exception){
                throw new Exception("ID da Rota inválido.");
            }
            int origemIdConvert = 0;
            try{
                origemIdConvert = int.Parse(origemId);  
            } catch (Exception){
                throw new Exception("ID inválido.");
            }
            Model.Cidade origem = Model.Cidade.BuscarCidade(origemIdConvert);
            Model.Cidade destino = Model.Cidade.BuscarCidade(int.Parse(destinoId));
            Model.Cidade caminhao = Model.Cidade.BuscarCidade(int.Parse(caminhaoId));
            DateTime dataConvert = DateTime.Parse(data);
            Model.Rota rota = new Model.Rota(idConvert, origem, destino, caminhao, dataConvert);
        }
        public static void AlterarRota(
            string id,
            string origemId,
            string destinoId,
            string caminhaoId,
            string data
        )
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(id);
            } catch (Exception){
                throw new Exception("ID inválido.");
            }
            Model.Cidade origem = Model.Cidade.BuscarCidade(int.Parse(origemId));
            Model.Cidade destino = Model.Cidade.BuscarCidade(int.Parse(destinoId));
            Model.Cidade caminhao = Model.Cidade.BuscarCidade(int.Parse(caminhaoId));
            DateTime dataConvert = DateTime.Parse(data);
            Model.Rota rota = new Model.Rota(idConvert, origem, destino, caminhao, dataConvert);
        }
    }
}