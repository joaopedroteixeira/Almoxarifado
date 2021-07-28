using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace Almoxarifado
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            bool valorAceito;
            int escolhaTipo = 0;

            List<Item> itens = new List<Item>();
            List<Material> materiais = new List<Material>();
            materiais.Add(new Material() { nomeItem = "cimento", descricao = "cimpor-50Kg", codigo = "1", dataValidade = DateTime.Parse("22-02-2022"), quantidade = 1000, lote = "12-b" });

            Item materialTeste = new Material() { nomeItem="tijolo",descricao="comum",codigo="6",dataValidade=DateTime.Parse("22-03-2022"),lote="12-C"};
 
            Material mate = ()materialTeste;
            mate.quantidade = 300;
            materiais.Add(mate);


            if (materialTeste is Material material1)
            {
               material1.UsarMaterial(5000);
            }
            else
            {
                Console.WriteLine("erro na operação de downcast (is)");
            }
            
            

            Item primeiraFerramenta = new Ferramenta();
            Ferramenta segundaFerramenta = primeiraFerramenta as Ferramenta;
            if (segundaFerramenta != null)
            {
                segundaFerramenta.VerificaQualidade();
            }
            else
            {
                Console.WriteLine("erro na operação de downcast (as)");
            }


            List<Ferramenta> ferramentas = new List<Ferramenta>();
            ferramentas.Add(new Ferramenta() { nomeItem = "alicate", descricao="ferro", codigo = "3" });



            do
            {
                do
                {
                    DataAtualizada();
                    Console.WriteLine("--------------------------------------------------" +
                                      "\n--------------SISTEMA DE ALMOXARIFADO-------------");
                    Console.Write("INFORME O TIPO:\n1-Material\n2-Ferramenta\n3-Item\n0-Sair\n--> ");

                    valorAceito = int.TryParse(Console.ReadLine(), out escolhaTipo);
                    if (escolhaTipo < 0 || escolhaTipo > 3 || valorAceito == false)
                    {
                        Console.WriteLine("valor inserido invalido, tente outro");
                    }
                } while (escolhaTipo < 0 || escolhaTipo > 3 || valorAceito == false);


                if (escolhaTipo == 1)
                {
                    do
                    {
                        ushort opcaoRecebe=0;
                        Console.Write("\n\nINFORME A OPÇÃO QUE DESEJA\n1-Cadastar material\n2-remover material" +
                            "\n3-Imprimir material \n4-Imprimir todos materiais ordenado pelo nome\n5-Quantidade de materiais na lista\n6-Repor material\n7-usar material\n8-Teste de validade\n9-Voltar ao menu inicial\n0-Sair\n-->");
                        valorAceito = ushort.TryParse(Console.ReadLine(), out opcaoRecebe);
                        opcao = opcaoRecebe;
                        if (opcao < 0 || opcao > 9 || valorAceito == false)
                        {
                            Console.WriteLine("\nvalor invalido, tente novamente\n");

                        }
                    } while (opcao < 0 || opcao > 9 || valorAceito == false);
                    switch (opcao)
                    {

                        case 1:
                            int cadastroCont = 0;
                            Console.WriteLine("----------CADASTRO DE  NOVO MATERIAL----------");

                            Console.Write("Informe o nome do material\n-->");
                            string materialNome = Console.ReadLine();

                            Console.Write("Informe a descrição do material\n-->");
                            string materialDescricao = Console.ReadLine();

                            Console.Write("Informe o lote do material\n-->");
                            string materiallote = Console.ReadLine();

                            Double materialQuantidade;
                            do
                            {
                                Console.Write("Informe a quantidade de {0} a ser cadastrado\n-->", materialNome);
                                valorAceito = Double.TryParse(Console.ReadLine(), out materialQuantidade);
                                if (valorAceito == false)
                                {
                                    Console.WriteLine("Valor informado invalido, tente novamente");
                                }
                            } while (valorAceito == false);

                            DateTime materialData;
                            do
                            {
                                Console.Write("Informe a data de validade \ndd/mm/aaaa\n-->");
                                valorAceito = DateTime.TryParse(Console.ReadLine(), out materialData);
                                if (valorAceito == false)
                                {
                                    Console.WriteLine("Valor informado invalido, tente novamente");
                                }
                            } while (valorAceito == false);

                            string materialCodigo;
                            do
                            {
                                cadastroCont = 0;
                                Console.Write("Informe o codigo do material\n-->");
                                materialCodigo = Console.ReadLine();

                                for (int i = 0; i < materiais.Count; i++)
                                {
                                    if (materiais[i].codigo == materialCodigo)
                                    {
                                        cadastroCont++;
                                    }
                                }
                                if (cadastroCont == 0)
                                {
                                    for (int j = 0; j < ferramentas.Count; j++)
                                    {
                                        if (ferramentas[j].codigo == materialCodigo)
                                        {
                                            cadastroCont++;
                                        }
                                    }
                                }

                            } while (cadastroCont > 0);

                            materiais.Add(new Material() { nomeItem = materialNome, descricao = materialDescricao, codigo = materialCodigo, dataValidade = materialData, quantidade = materialQuantidade,lote=materiallote });
                            break;

                        case 2:
                            do
                            {
                                Console.WriteLine("-----REMOVER MATERIAL-----");
                                Console.Write("Informe o codigo do material que deseja remover\n-->");

                                string removeCodigo = Console.ReadLine();

                                for (int i = 0; i < materiais.Count; i++)
                                {
                                    if (materiais[i].codigo == removeCodigo)
                                    {
                                        materiais.Remove(materiais[i]);
                                        Console.WriteLine("Removido com sucesso");
                                    }
                                }

                            } while (valorAceito == false);
                            break;
                        case 3:
                            string imprimeCodigo = "";


                            Console.WriteLine("Imprimir dados de material especifico");
                            Console.WriteLine("Informe o codigo do material que deseja realizar a impressão");
                            imprimeCodigo = Console.ReadLine();
                           Func<Material ,bool> fu= x => x.codigo.Equals(imprimeCodigo);
                            var imprimirMaterial = materiais.Where(x => x.codigo.Equals(imprimeCodigo)).ToList();
                            foreach (var mat in imprimirMaterial)
                            {
                                Console.WriteLine("Nome: " + mat.nomeItem + "\nEmpresa:" + mat.empresa + "\nCodigo: " + mat.codigo + "\nQuantidade: " + mat.quantidade + "\nData Validade: " + mat.dataValidade + "\nLote:" + mat.lote + "\n\n");
                            }

                            break;
                        case 4:
                            Console.WriteLine("Imprimir todos os dados dos materiais de forma ordenada pelo nome\n");
                            List<Material> organizarMaterial = materiais.OrderBy(material => material.nomeItem).ToList();

                            foreach (Material material in organizarMaterial)
                            {
                                Console.WriteLine("Nome: " + material.nomeItem + "\nEmpresa:" + material.empresa + "\nCodigo: " + material.codigo + "\nQuantidade: " + material.quantidade + "\nData Validade: " + material.dataValidade + "\nLote:" + material.lote + "\n\n");

                            }
                            break;
                        case 5:
                            Console.WriteLine("Quantidade de materiais na lista");
                            Console.WriteLine("A quantidade de materiais é: {0}", materiais.Count);

                            break;
                        case 6:
                            Console.WriteLine("Repor material");
                            Console.WriteLine("Informe o codigo do material que deseja repor");
                            string codigoRepor = Console.ReadLine();
                            
                            double quantidadeRepor;
                            float lerRepor;
                            do
                            {
                                Console.WriteLine("Informe a quantidade que deseja repor");
                                valorAceito = float.TryParse(Console.ReadLine(), out lerRepor);
                                quantidadeRepor = lerRepor;

                                if (valorAceito == false)
                                {
                                    Console.WriteLine("Valor informado invalido, tente novamente");
                                }
                            } while (valorAceito == false);
                            DateTime reporData;
                            do
                            {
                                Console.Write("Informe a data de validade do material a ser reposto\ndd/mm/aaaa\n-->");
                                valorAceito = DateTime.TryParse(Console.ReadLine(), out reporData);
                                if (valorAceito == false)
                                {
                                    Console.WriteLine("Valor informado invalido, tente novamente");
                                }
                            } while (valorAceito == false);

                            for (int i = 0; i < materiais.Count; i++)
                            {
                                if (materiais[i].codigo == codigoRepor)
                                {
                                    materiais[i].ReporMaterial(quantidadeRepor,reporData);

                                }
                            }


                            break;
                        case 7:
                            Console.WriteLine("Usar material");
                            Console.WriteLine("Informe o codigo que deseja usar");
                            string codigoUsar = Console.ReadLine();
                            Double quantidadeUsar;
                            int quantidadeUsarInteiro;
                            do
                            {
                                Console.WriteLine("Informe a quantidade que deseja usar");
                                valorAceito = Double.TryParse(Console.ReadLine(), out quantidadeUsar);
                                quantidadeUsarInteiro = (int)quantidadeUsar;
                                Console.WriteLine(quantidadeUsar);
                                if (quantidadeUsar != quantidadeUsarInteiro)
                                {
                                    quantidadeUsarInteiro = quantidadeUsarInteiro + 1;
                                }  
    
                                if (!valorAceito)
                                {
                                    Console.WriteLine("valor informado invalido, tente novamente");
                                }
                            } while (!valorAceito);
                            for (int i = 0; i < materiais.Count; i++)
                            {
                                if (materiais[i].codigo == codigoUsar)
                                {
                                    materiais[i].UsarMaterial(quantidadeUsarInteiro);

                                }
                            }

                            break;
                        case 8:
                            Console.WriteLine("Verificar Data de Validade");
                            string codigoVerifica = Console.ReadLine();
                            for (int i = 0; i < materiais.Count; i++)
                            {
                                if (materiais[i].codigo == codigoVerifica)
                                {
                                    materiais[i].TesteValidade();

                                }
                            }
                            break;
                      
                    }

                }
                else if (escolhaTipo == 2)
                {
                    do
                    {
                        Console.Write("\n\nINFORME A OPÇÃO QUE DESEJA\n1-Cadastar ferramenta\n2-remover ferramenta" +
                            "\n3-Imprimir dados de ferramenta \n4-Imprimir dados de todas ferramentas \n5-Quantidade de ferramenta  na lista\n6-verificar qualidade\n7-Declara Avaria\n8-Consertar\n9-Emprestar\n10-Devolver\n11-Voltar ao menu inicial\n0-Sair\n-->");
                        valorAceito = int.TryParse(Console.ReadLine(), out opcao);
                        if (opcao < 0 || opcao > 11 || valorAceito == false)
                        {
                            Console.WriteLine("\nvalor invalido, tente novamente\n");

                        }
                    } while (opcao < 0 || opcao > 11 || valorAceito == false);



                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("-----Cadastro de ferramentas");

                            Console.WriteLine("Informe o nome da ferramenta");
                            string ferramentaNome = Console.ReadLine();

                            Console.WriteLine("Informe a descrição da ferramenta");
                            string ferramentaDescricao = Console.ReadLine();

                            string ferramentaCodigo;
                            int contCodigo = 0;
                            do
                            {
                                contCodigo = 0;
                                Console.WriteLine("Informe o codigo da ferramenta");
                                ferramentaCodigo = Console.ReadLine();

                                for (int i = 0; i < ferramentas.Count; i++)
                                {
                                    if (ferramentas[i].codigo == ferramentaCodigo)
                                    {
                                        contCodigo++;
                                    }
                                }
                                if (contCodigo == 0)
                                {
                                    for (int j = 0; j < materiais.Count; j++)
                                    {
                                        if (materiais[j].codigo == ferramentaCodigo)
                                        {
                                            contCodigo++;
                                        }

                                    }
                                }
                            } while (contCodigo != 0);

                            ferramentas.Add(new Ferramenta() { nomeItem = ferramentaNome, descricao = ferramentaDescricao, codigo = ferramentaCodigo });

                            break;
                        case 2:
                            Console.WriteLine("---Remover ferramenta---");
                            Console.WriteLine("Informe o codigo da ferramenta que deseja remover");
                            string codigoRemove = Console.ReadLine();

                            for (int i = 0; i < ferramentas.Count; i++)
                            {
                                bool codigoIgual = Igual(ferramentas[i].codigo, codigoRemove);
                                if (codigoIgual==true)
                                {
                                    ferramentas.Remove(ferramentas[i]);
                                    Console.WriteLine("Removido com sucesso");
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Imprimir dados de ferramentas especifica");
                            Console.WriteLine("Informe o codigo da ferramenta que deseja realizar a impressão dos dados");
                            string imprimirCodigo = Console.ReadLine();
                            IEnumerable<Ferramenta> ferramentasRequerer =
                                from ferramentaObjeto in ferramentas
                                where ferramentaObjeto.codigo == imprimirCodigo
                                select ferramentaObjeto;
                            foreach (Ferramenta ferramentaObjeto2 in ferramentasRequerer)
                            {
                                Console.WriteLine("Nome: " + ferramentaObjeto2.nomeItem + "\nCodigo: " + ferramentaObjeto2.codigo + "\nDescrição: " + ferramentaObjeto2.descricao + "\nEmpresa: " + ferramentaObjeto2.empresa);
                            }

                            break;
                        case 4:
                            Console.WriteLine("Imprimir os dados de todas as ferramentas");
                            List<Ferramenta> organizarFerramenta = ferramentas.OrderBy(ferramenta => ferramenta.nomeItem).ToList();

                            foreach (Ferramenta ferramenta in organizarFerramenta)
                            {
                                Console.WriteLine("Nome: " + ferramenta.nomeItem + "Codigo: " + ferramenta.codigo + "Descrição: " + ferramenta.descricao + "Empresa: " + ferramenta.empresa);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Quantidade de ferramentas na lista");
                            Console.WriteLine("A quantidade de ferramenta na lista é: {0}", ferramentas.Count);
                            break;
                        case 6:
                            Console.WriteLine("Verificar Qualidade de ferramenta");
                            Console.WriteLine("Informe o codigo da ferramenta que deseja verificar a qualidade");
                            string verificaCodigo = Console.ReadLine();
                            for (int i = 0; i < ferramentas.Count; i++)
                            {
                                if (ferramentas[i].codigo == verificaCodigo)
                                {
                                    ferramentas[i].VerificaQualidade();
                                }
                            }
                            break;
                        case 7:
                            Console.WriteLine("Declarar avaria");
                            Console.WriteLine("Informe o codigo da ferramenta que deseja declarar a avaria");
                            string avariaCodigo = Console.ReadLine();
                            for (int i = 0; i < ferramentas.Count; i++)
                            {
                                if (ferramentas[i].codigo == avariaCodigo)
                                {
                                    ferramentas[i].DeclararAvaria();

                                    Console.WriteLine("avaria declarada com sucesso");
                                }
                            }
                            break;
                        case 8:
                            Console.WriteLine("Consertar Ferramenta");
                            Console.WriteLine("Informe o codigo da ferramenta que deseja consertar");
                            string consertarCodigo = Console.ReadLine();
                            for (int i = 0; i < ferramentas.Count; i++)
                            {
                                if (ferramentas[i].codigo == consertarCodigo)
                                {
                                    ferramentas[i].Consertar();

                                    Console.WriteLine("Ferramenta consertada com sucesso!!");
                                }
                            }
                            break;
                        case 9:
                            Console.WriteLine("Emprestar Ferramenta");
                            Console.WriteLine("Informe o codigo da ferramenta que deseja emprestar");
                            string emprestarCodigo = Console.ReadLine();
                            for (int i = 0; i < ferramentas.Count; i++)
                            {
                                if (ferramentas[i].codigo == emprestarCodigo)
                                {
                                    ferramentas[i].Emprestar();

                                    Console.WriteLine("Ferramenta emprestada com sucesso!!");
                                }
                            }
                            break;
                        case 10:
                            Console.WriteLine("Devolver Ferramenta");
                            Console.WriteLine("Informe o codigo da ferramenta que deseja devolver");
                            string devolverCodigo = Console.ReadLine();
                            for (int i = 0; i < ferramentas.Count; i++)
                            {
                                if (ferramentas[i].codigo == devolverCodigo)
                                {
                                    ferramentas[i].Devolver();

                                    Console.WriteLine("Ferramenta devolvida com sucesso!!");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Valor invalido");
                            break;

                    }

                }
                else if (escolhaTipo == 3)
                {
                    do
                    {
                        Console.WriteLine("---Itens---");
                        Console.Write("INFORME A OPÇÃO QUE DESEJA\n1-Imprimir todos os itens\n2-Voltar ao menu inicial\n0-SAIR\n-->");
                        valorAceito = int.TryParse(Console.ReadLine(), out opcao);
                        if (opcao < 0 || opcao > 2 || valorAceito == false)
                        {
                            Console.WriteLine("\nvalor invalido, tente novamente\n");

                        }
                    } while (opcao < 0 || opcao > 2|| valorAceito == false);
                    if(opcao==1)
                    {
                            for (int i = 0; i < materiais.Count; i++)
                            {
                                Item item = materiais[i];
                                itens.Add(item);
                            }
                            for (int j = 0; j < ferramentas.Count; j++)
                            {
                                Item item2 = ferramentas[j];
                                itens.Add(item2);
                            }
                       var itensa= materiais.Cast<Item>().Concat(ferramentas);
                            IEnumerable<Item> organizarItens = itens.OrderBy(objetoItem => objetoItem.nomeItem);
                            foreach (Item objetoItem in organizarItens)
                            {
                                Console.WriteLine("\nNome: " + objetoItem.nomeItem + "\nCodigo: " + objetoItem.codigo + "\nDescrição: " + objetoItem.descricao + "\nEmpresa: " + objetoItem.empresa);
                            }
                    }
                   
                }
                
        } while (opcao != 0);
            
       static void DataAtualizada()
      {
      string Date = DateTime.Now.ToString("dd/MM/yy");
      string Hora = DateTime.Now.ToString("HH:mm:ss");
      Console.WriteLine("DATA: {0}", Date);
      Console.WriteLine("HORA: {0}", Hora);
  }
        }
        static bool Igual ( object valor1,  object valor2)
        {
            if (valor1.Equals( valor2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

