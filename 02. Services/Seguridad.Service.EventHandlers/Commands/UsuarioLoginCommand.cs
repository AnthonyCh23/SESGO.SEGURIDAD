using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad.Service.EventHandlers.Commands
{
    public class UsuarioLoginCommand: IRequest<Object>
    {
        public string cUsuLogin { get; set; }
        public string cUsuContra { get; set; }
    }
}
