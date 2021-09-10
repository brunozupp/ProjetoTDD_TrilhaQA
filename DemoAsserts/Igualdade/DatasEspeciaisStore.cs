using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts.Igualdade
{
    public class DatasEspeciaisStore
    {
        public DateTime Data(DatasEspeciais datasEspeciais)
        {
            switch(datasEspeciais)
            {
                case DatasEspeciais.AnoNovo:
                    return new DateTime(2017, 1, 1, 0, 0, 0, 0);
                default:
                    throw new ArgumentOutOfRangeException("datas especiais");
            }
        }
    }
}
