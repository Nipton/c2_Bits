using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_Bits
{
    interface IBits
    {
        public bool this[byte index]
        {
            get; set;
        }
    }

    internal class Bits : IBits
    {
        public long Value { get; set; }

        public Bits(byte value) 
        {
            Value = value;
        }
        public Bits(int value)
        {
            Value = value;
        }
        public Bits(long value)
        {
            Value = value;
        }

        public bool this[byte index]
        {
            get
            {
                return (Value & (1 << index)) != 0;
            }
            set
            {
                if(value)
                {
                    Value |= 1L << index;
                }
                else
                {
                    Value &= ~(1 << index);
                }
            }
        }

        public static implicit operator Bits(byte b)
        {
            return new Bits(b);
        }
        public static implicit operator Bits(long l)
        {
            return new Bits(l);
        }
        public static implicit operator Bits(int i)
        {
            return new Bits(i);
        }

        public override string ToString()
        {
            return $"{Value.ToString()}  =  {Convert.ToString(Value, 2)} ";
        }
    }
}
