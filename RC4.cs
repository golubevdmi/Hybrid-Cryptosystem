using System.Linq;


namespace Crypt
{
    class RC4
    {
        // Permutations containing all possible bytes from 0x00 to 0xFF.
        byte[] S = new byte[256];  

        // Counters
        int x = 0;
        int y = 0;

        public RC4(byte[] key)
        {
            init(key);
        }

        // For initial initialization of the vector permutation key,
        // key-scheduling algorithm is used.
        private void init(byte[] key)
        {
            int keyLength = key.Length;

            for (int i = 0; i < 256; i++)
                S[i] = (byte)i;

            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + S[i] + key[i % keyLength]) % 256;
                S.Swap(i, j);
            }
        }

        // Pseudo-Random Generation Algorithm.
        // At each call, the method will return the next byte of the key stream,
        // which we will combine by xor'om c byte source data.
        private byte keyItem()
        {
            x = (x + 1) % 256;
            y = (y + S[x]) % 256;

            S.Swap(x, y);

            return S[(S[x] + S[y]) % 256];
        }

        // For each byte of the array/stream of input unencrypted data
        // request the key byte and combine them with xor (^)
        public byte[] Encode(byte[] dataB, int size)
        {
            byte[] data = dataB.Take(size).ToArray();

            byte[] cipher = new byte[data.Length];

            for (int m = 0; m < data.Length; m++)
                cipher[m] = (byte)(data[m] ^ keyItem());

            return cipher;
        }

        //
        // For decoding, use the Encode method.
        public byte[] Decode(byte[] dataB, int size)
        {
            return Encode(dataB, size);
        }
    }

    static class SwapExt
    {
        // Swaps two elements in the array
        public static void Swap<T>(this T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
