using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEmpresa
    {
        private Int32 id;
        private string nome;
        private string descricao;
        private string cnpj;

        public int Id {
            get { return id; }
            set { id = value;}
        }

        public string Nome {
            get { return nome; }
            set { nome = value;}
        }

        public string Descricao {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Cnpj {
            get { return cnpj; }
            set { cnpj = value; }
        }
    }
}
