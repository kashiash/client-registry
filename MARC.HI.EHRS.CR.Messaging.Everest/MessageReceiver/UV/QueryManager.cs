﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MARC.HI.EHRS.SVC.Messaging.Everest;

namespace MARC.HI.EHRS.CR.Messaging.Everest.MessageReceiver.UV
{
    public class QueryManager : IEverestMessageReceiver
    {
        #region IEverestMessageReceiver Members

        public MARC.Everest.Interfaces.IGraphable HandleMessageReceived(object sender, MARC.Everest.Connectors.UnsolicitedDataEventArgs e, MARC.Everest.Connectors.IReceiveResult receivedMessage)
        {

            throw new NotImplementedException();
        }

        #endregion

        #region IUsesHostContext Members

        /// <summary>
        /// Gets or sets the context for the receiver
        /// </summary>
        public SVC.Core.HostContext Context
        {
            get;
            set;
        }


        #endregion

        #region ICloneable Members

        public object Clone()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}