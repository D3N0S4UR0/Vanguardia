using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    public class pergunta
    {
        private String perg;
        private String resp;

        public pergunta(string perg, string resp)
        {
            this.Perg = perg;
            this.Resp = resp;
        }

        public string Perg { get => perg; set => perg = value; }
        public string Resp { get => resp; set => resp = value; }
    }
}
