using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Almoxarifado
{
    public class Ferramenta : Item
    {
        bool avaria { get; set; }
        bool emprestado { get; set; }
        
        public  Ferramenta()
        {
            avaria = false;
            emprestado = false;
        }
        public void VerificaQualidade()
        {
            if (avaria)
            {
                Console.WriteLine("A ferramenta {0} está com avarias",nomeItem);
            }
            else
            {
                Console.WriteLine("A ferramenta {0} está em bom estado de conservação", nomeItem);
            }
        }
        public void DeclararAvaria()
        {
            avaria = true;
        }
        public void Consertar()
        {
            avaria = false;
        }
        public void Emprestar()
        {
            if (avaria == true)
            {
                Console.WriteLine("o equipamento {0} não pode ser emprestado pois apresenta avaria", nomeItem);
            }
            else if(emprestado==true)
            {
                Console.WriteLine("o equipamento {0} não pode ser emprestado pois já está emprestado",nomeItem);
            }
            else
            {
                this.emprestado = true;
                Console.WriteLine("equipamento emprestado com sucesso");
            }
        }
        public void Devolver()
        {
            this.emprestado = false;
            Console.WriteLine("devolução realizada com sucesso");
        }
    }
}
