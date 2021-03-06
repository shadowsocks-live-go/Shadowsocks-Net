﻿/*
 * Shadowsocks-Net https://github.com/shadowsocks/Shadowsocks-Net
 */

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Buffers;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Argument.Check;

namespace Shadowsocks.Helper
{
    public class ObfuscatorLoader
    {
        public static Dictionary<string, Type> LoadObfuscators()
        {
            var ciphers = from t in Assembly.GetExecutingAssembly().GetTypes()
                          //where t.IsSubclassOf(typeof(Obfuscation.))
                          let attr = t.GetCustomAttribute<Obfuscation.ObfuscatorAttribute>()
                          where attr != null
                          select new KeyValuePair<string, Type>(attr.Name, t);
            return new Dictionary<string, Type>(ciphers);

        }
    }
}
