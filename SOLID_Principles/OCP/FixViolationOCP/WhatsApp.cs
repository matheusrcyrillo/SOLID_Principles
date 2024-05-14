using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP.FixViolationOCP
{
    public class WhatsApp : Notificacao
    {
        public override void EnviarNotificacao(string mensagem)
        {
            // Lógica para enviar mensagem via WhatsApp
        }
    }
}
