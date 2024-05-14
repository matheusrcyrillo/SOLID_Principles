using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP.FixViolationOCP
{
    public abstract class Notificacao
    {
        public abstract void EnviarNotificacao(string mensagem);
    }
}
