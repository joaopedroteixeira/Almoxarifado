using System;
using System.Collections.Generic;
using System.Text;

namespace Almoxarifado
{
    //classe base do almoxarifado
   public  class  Item
    {
        public string nomeItem { get; set; }
        public string descricao { get; set; }
        public string empresa { get; set; }
        public string codigo { get; set; }
        
        public Item()
        {
            this.empresa ="JP engenharia";
        }

    }
}
