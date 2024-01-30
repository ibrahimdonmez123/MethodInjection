using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInjection
{
    public class IkinciClass
    {
        IMesajlaClass _oIMesajlaClass = null;

        public void MesajiGoster(IMesajlaClass oIMesajlaClass, string mesaj)
        {
            _oIMesajlaClass = oIMesajlaClass;
            _oIMesajlaClass.MesajAt(mesaj);
        }
    }
}
