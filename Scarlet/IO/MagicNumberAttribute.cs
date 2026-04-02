using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scarlet.IO
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class MagicNumberAttribute : Attribute
    {
        public byte[] MagicNumber { get; private set; }
        public long Position { get; private set; }

        public MagicNumberAttribute(byte[] magicNumber, long position)
        {
            MagicNumber = magicNumber;
            Position = position;
        }

        public MagicNumberAttribute(string magicNumber, long position)
        {
            MagicNumber = Encoding.ASCII.GetBytes(magicNumber);
            Position = position;
        }

        public MagicNumberAttribute(string magicNumber, int encoder, long position)
        {
            var encoding = Encoding.GetEncoding(encoder);
            MagicNumber = encoding.GetBytes(magicNumber);
            Position = position;
        }
    }
}
