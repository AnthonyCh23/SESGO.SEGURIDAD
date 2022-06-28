using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seguridad.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad.Persistence.Database.Configuration
{
    public class PasswordConfiguration
    {
        public PasswordConfiguration(EntityTypeBuilder<Password> entityBuilder)
        {
            entityBuilder.HasKey(x => x.nPassItem);

        }
    }
}
