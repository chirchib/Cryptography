using System;
using System.Collections.Generic;
using System.Text;

// lab 2
namespace Cryptography.Ciphers
{
    class Shamir_protocol
    {
        private int keyA;
        private int keyB;
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public Shamir_protocol(string keyA, string keyB, string text)
        {
            this.keyA = Convert.ToInt32(keyA);
            this.keyB = Convert.ToInt32(keyA);
        }
    }
}
