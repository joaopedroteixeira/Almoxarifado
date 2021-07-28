using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace Almoxarifado
{
    public class Material : Item
    {


        public double quantidade { get; set; }
        public DateTime dataValidade { get; set; }

        public string lote { get; set; }

        public void ReporMaterial(double quantidadeReposição, DateTime dataValidadeReposição)
        {
            if (dataValidade != dataValidadeReposição)
            {
                Console.WriteLine("cadastre o item com um novo codigo pois a data de validade do item é diferente do lote ja cadastrado");
            }
            else
            {
                quantidade = quantidade + quantidadeReposição;
            }
        }
        public void UsarMaterial(int quantidadeUsar)
        {
            if (quantidadeUsar > quantidade)
            {
                Console.WriteLine("A quantidade de material disponivel é menor que a requisitada\n quantidade= {0}", quantidade);
            }
            else
            {
                quantidade = quantidade - quantidadeUsar;
                Console.WriteLine("material retirado para uso com sucesso\n quantidade retirada: {0}\n quantidade disponivel apos retiriada: {1}",quantidadeUsar,quantidade);
            }
        }

        public void TesteValidade()
        {
            DateTime DataAtual = DateTime.Now;
            if (dataValidade <DataAtual)
            {
                Console.WriteLine("o material {0} está vencido , remova ele do estoque", nomeItem);
            }
            else
            {
                Console.WriteLine("Material dentro do prazo de validade");
            }
        }
    }
}
