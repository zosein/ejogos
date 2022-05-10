using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Interface
{
    public interface iEquipe
    {
        void Criar(Equipe novaEquipe);

        List<Equipe> LerEquipes();

        


    }
}
