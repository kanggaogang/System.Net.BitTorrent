#if !DISABLE_DHT
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Net.BitTorrent.Dht
{
    internal class NodeAddedEventArgs : EventArgs
    {
        private Node node;

        public Node Node
        {
            get { return node; }
        }

        public NodeAddedEventArgs(Node node)
        {
            this.node = node;
        }
    }
}
#endif