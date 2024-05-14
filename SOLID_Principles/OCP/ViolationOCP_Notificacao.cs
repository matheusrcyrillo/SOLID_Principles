using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP
{
    public class ViolationOCP_Notificacao
    {
        public void EnviarNotificacao(string mensagem, ENotificacao tipoNotificacao)
        {
            if(tipoNotificacao == ENotificacao.Email)
            {
                // Lógica para enviar e-mail
            }
            else if(tipoNotificacao == ENotificacao.SMS)
            {
                // Lógica para enviar SMS
            }
            else if(tipoNotificacao == ENotificacao.WhatsApp)
            {
                // Lógica para enviar WhatsApp
            }
        }
    }
}
