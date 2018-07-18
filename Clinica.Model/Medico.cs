using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Modelo
{
    public class Medico : Pessoa
    {
        public int CRM { get; set; }
        public TipoEspecialidade Especialidade { get; set; }


        public string ResumoMedico
        {
            get
            {
                return $"{Nome} : {Especialidade}";
            }
        }

    }
}
