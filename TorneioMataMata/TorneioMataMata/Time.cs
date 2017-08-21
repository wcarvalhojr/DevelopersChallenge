using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TorneioMataMata
{
    public class Time
    {
        #region Fields
        private string _grupoA;
        private string _grupoB;

        private bool _checkA;
        private bool _checkB;
        #endregion

        #region Properties
        public virtual String grupoA
        {
            get { return _grupoA; }
            set { _grupoA = value; }
        }

        public virtual String grupoB
        {
            get { return _grupoB; }
            set { _grupoB = value; }
        }

        public virtual bool checkA
        {
            get { return _checkA; }
            set { _checkA = value; }
        }

        public virtual bool checkB
        {
            get { return _checkB; }
            set { _checkB = value; }
        }
        #endregion
    }
}