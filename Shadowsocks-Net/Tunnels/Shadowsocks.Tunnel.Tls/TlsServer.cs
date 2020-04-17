﻿/*
 * Shadowsocks-Net https://github.com/shadowsocks/Shadowsocks-Net
 */

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Buffers;
using System.Linq;
using System.IO;
using Microsoft.Extensions.Logging;
using Argument.Check;
using System.Text;

namespace Shadowsocks.Tunnel.Tls
{
    using Infrastructure;
    using Infrastructure.Sockets;
    public class TlsServer : Server<TlsClient>
    {
        public override Task<TlsClient> Accept()
        {
            throw new NotImplementedException();
        }

        public override void Listen()
        {
            throw new NotImplementedException();
        }

        public override void StopListen()
        {
            throw new NotImplementedException();
        }
    }
}