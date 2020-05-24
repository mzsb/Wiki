using System;
using System.Collections.Generic;
using System.Text;
using Wiki.BLL.Model.Entity.DataValueModel;

namespace Wiki.BLL.Model.Entity
{
    public class Snak
    {
        private DataValue _dataValue;
        public DataValue DataValue
        {
            get => _dataValue;

            set
            {
                if (_dataValue == null)
                {
                    _dataValue = value.CastToSpecific();
                }
            }
        }
    }
}
