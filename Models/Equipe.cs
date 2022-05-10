using EJOGOS.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS.Models
{
    public class Equipe : EquipeBase, iEquipe
    {
        public int idEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //variavel de dados.

        private const string caminhobd = "Database/equipe.csv";


        public Equipe()
        {

            //metodo da classe de herança Equipebase.
            CriarPastaOuArquivo(caminhobd);

        }

        //criar uma função que irá receber o objeto EQUIPE,
        //e vai retornar no formato .csv (string)

        private string Preparar(Equipe e)
        {
            //ou tbm : return e.idEquipe + ";" + ";" + e.Imagem;
            return $"{e.idEquipe};{e.Nome};{e.Imagem}";

        }














        public void Criar(Equipe novaEquipe)
        {
            string valor = Preparar(novaEquipe);

            //array de string = na posição zero temos o retorno do "Preparar".
            string[] equipe_texto = {Preparar(novaEquipe)};


            //arquivo vamos add uma nova linha.
            //caminho do arquivo, string em formato de array.
            File.AppendAllLines(caminhobd, equipe_texto);

        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> equipes = new List<Equipe>();

            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);



            }



            return listaEquipes;

        }
    }

}
