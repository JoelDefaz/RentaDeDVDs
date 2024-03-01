using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renta_de_DVDs.Sistema
{
    internal class Validar
    {
        internal static bool estanLosCamposLlenos(string[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[5] == "")
                {
                    continue;
                }
                if (datos[i] == "")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
