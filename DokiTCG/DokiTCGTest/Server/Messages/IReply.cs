﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokiTCGTest.Server.Messages
{
    public interface IReply
    {
        void SetMessage(String message);
    }
}