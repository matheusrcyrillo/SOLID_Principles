using SOLID_Principles.OCP.FixViolationOCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP
{
    public class SMS : Notificacao
    {
        public override void EnviarNotificacao(string mensagem)
        {
            // Lógica para enviar SMS
        }
    }
}
