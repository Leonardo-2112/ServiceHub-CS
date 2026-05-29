using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHubClass
{
    internal class Nivel
    {
        //Atributos
        private int id;
        private string? nome;
        private string? sigla;

        //Construtores
        public int Id { get => id; set => id = value; }
        public string? Nome { get => nome; set => nome = value; }
        public string? Sigla { get => sigla; set => sigla = value; }

    }
}
