using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad.Domain
{
    public class Password
    {
        public int nUsuId { get; set; }
        public int nPassItem { get; set; }
        public String cPassword { get; set; }
        public DateTime fPassFecCre { get; set; }
        public int nPassActivo { get; set; }
        public int nPassCnt { get; set; }
    }
}
