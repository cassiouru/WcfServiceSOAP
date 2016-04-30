using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSOAP
{
    [DataContract]
    public class ObtemCidadePorEstado : IObtemCidadePorEstado
    {
        IList<Cidade> cidades;

        public ObtemCidadePorEstado()
        {
            this.cidades = new List<Cidade>()
            {
                new Cidade()
                {
                    Nome = "URU",
                    Uf = "SP"
                },
                new Cidade()
                {
                    Nome = "PONGAI",
                    Uf = "SP"
                },
                new Cidade()
                {
                    Nome = "Angra dos reis",
                    Uf = "RJ"
                },
                new Cidade()
                {
                    Nome = "Parati",
                    Uf = "RJ"
                },
                new Cidade()
                {
                    Nome = "Rio das ostras",
                    Uf = "RJ"
                },
                new Cidade()
                {
                    Nome = "Ponta Grossa",
                    Uf = "PR"
                },
                new Cidade()
                {
                    Nome = "Curitiba",
                    Uf = "PR"
                }
            };
        }

        public string[] Obter(string uf)
        {
            return this.cidades.Where(x=> x.Uf == uf.ToUpper()).Select(x=> x.Nome).ToArray();
        }
    }

    public class Cidade
    {
        public string Nome { get; set; }
        public string Uf { get; set; }
    }
}
