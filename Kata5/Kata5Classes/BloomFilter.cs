using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata5.Kata5Classes
{
    public class BloomFilter
    {
        public BloomFilter(int n)
        {
            bitArray = new BitArray(n);
        }

        public BitArray bitArray;

        public int HashFunction(string valueToHash)
        {
            int sum = 0;
            Char[] stringArray = valueToHash.ToCharArray();

            for(int i = 0; i < stringArray.Length; i++)
            {
                sum += (int)stringArray[i];
            }

            return sum % bitArray.Length;
        }

        public void Add(string valueToBeAdded)
        {
            int position = HashFunction(valueToBeAdded);
            bitArray[position] = true;
        }

        public bool Check(string valueToBeChecked)
        {
            int hashIndex = HashFunction(valueToBeChecked);

            if (bitArray[hashIndex])
                return true;

            return false;
        }
    }
}
