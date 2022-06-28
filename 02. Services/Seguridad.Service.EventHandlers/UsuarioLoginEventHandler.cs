using MediatR;
using Microsoft.EntityFrameworkCore;
using Novell.Directory.Ldap;
using Seguridad.Persistence.Database;
using Seguridad.Service.EventHandlers.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Seguridad.Service.EventHandlers
{
    public class UsuarioLoginEventHandler: IRequestHandler<UsuarioLoginCommand, Object>
    {
        private readonly ApplicationDbContext _context;

        public UsuarioLoginEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Object> Handle(UsuarioLoginCommand command, CancellationToken cancellationToken)
        {
             try
             {
                 var usuario = await _context.Usuario.SingleOrDefaultAsync(x => x.cUsuLogin == command.cUsuLogin);
                 if (usuario != null)
                 {
                     //var resLDAP = validarUsuarioContraLDAP(command.cUsuLogin, command.cUsuContra);
                     var access = await _context.Password.SingleOrDefaultAsync(x => x.nUsuId == usuario.nUsuId && x.cPassword == command.cUsuContra);
                     if (access != null)
                     {
                         return usuario;
                     }
                     else
                     {
                         return "No se encuentra registrado en el LDAP.";
                     }
                 }
                 else
                 {
                     return "No existe en la base de datos.";
                 }
             }
             catch (Exception ex)
             {
                return ex;
             }

        }

        public bool validarUsuarioContraLDAP(String usuNom, String cPass)
        {
            String domain = "SESDIGITAL.LOCAL";//S-recuay-wp/DC=SESDIGITAL,DC=LOCAL
            String userDn = $"{usuNom}@{domain}";
            try
            {
                using (var connection = new LdapConnection { SecureSocketLayer = false })
                {
                    connection.Connect(domain, LdapConnection.DefaultPort);
                    connection.Bind(userDn, cPass);
                    if (connection.Bound)
                        return true;
                }
            }
            catch (LdapException ex)
            {

            }
            return false;
            /*bool res = false;
            try
            {
                DirectoryEntry de = new DirectoryEntry("LDAP://" + "S-recuay-wp/DC=SESDIGITAL,DC=LOCAL", usuNom, cPass, AuthenticationTypes.Secure);
                DirectorySearcher ds = new DirectorySearcher(de);
                ds.Filter = "sAMAccountName=" + usuNom;
                SearchResult sr = null;
                sr = ds.FindOne();
                if (sr != null)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                //}
            }
            catch (DirectoryServicesCOMException e)
            {
                res = false;
            }
            return res;*/
        }

    }
}
