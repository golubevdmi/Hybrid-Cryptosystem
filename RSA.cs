using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace Crypt
{
    class RSA
    {
        Int64 P = 0, Q = 0;    // Prime numbers. User input
        Int64 N = 0;           // Module(P * Q)
        Int64 E = 0;           // Exponent(public key)
        Int64 d = 0;           // Private key

        // Alphabet
        List<char> character = new List<char>();

        public RSA()
        {
            GenerateCharacter();
        }

        //
        // Generates a public and private key from the transmitted prime numbers
        public bool GeneratePublicAndPrivateKey(Int64 p, Int64 q)
        {
            if (!isPrime(p))
            {
                MessageBox.Show("P is not prime");
                return false;
            }
            if (!isPrime(q))
            {
                MessageBox.Show("Q is not prime");
                return false;
            }

            P = p;
            Q = q;
            N = P * Q;

            if (!calculateExponent())
            {
                MessageBox.Show("Exponent not generated");
                return false;
            }
            if (!calculatePrivateKey())
            {
                MessageBox.Show("d not generated");
                return false;
            }


            return true;
        }


        // Message Encryption Method
        // Encrypt using created alphabet
        // Each character is converted to a numeric format and is encrypted using the formula Ci = Mi ^ E (mod N)
        public List<string> Encrypt(string message)
        {
            List<string> result = new List<string>();

            BigInteger tmp;

            for (int i = 0; i < message.Length; i++)
            {
                int index = character.IndexOf(message[i]);

                tmp = new BigInteger(index);
                tmp = BigInteger.Pow(tmp, Convert.ToInt32(E));
                tmp = tmp % N;

                result.Add(Convert.ToString(tmp));
            }
            return result;
        }
        // Message decryption method
        // Each number is decoded by the formula Ci = Mi ^ d (mod N)
        // The resulting number is translated into a symbol using the alphabet
        public string Decrypt(List<string> codedMessage)
        {
            string originalMessage = "";

            BigInteger tmp;

            foreach(string item in codedMessage)
            {
                if (item == "")
                    continue;

                tmp = new BigInteger(Convert.ToDouble(item));
                tmp = BigInteger.Pow(tmp, Convert.ToInt32(d));

                tmp = tmp % N;

                int index = Convert.ToInt32(tmp.ToString());

                originalMessage += character.ElementAt<char>(index).ToString();
            }

            return originalMessage;
        }

        public Int64 GetE()             { return E; }
        public Int64 GetN()             { return N; }

        // Returns the private key(the method was created for demonstration in the application)
        public Int64 GetD()             { return d; }     
        
        public int getSizeCharacter()   { return character.Count; }

        // The exponent (public key) is calculated (1 <e <Euler (N)),
        // Mutually simple with the Euler function of N
        private bool calculateExponent()
        {
            E = 0;
            Int64 Euler = (P - 1) * (Q - 1);

            for (E = 4; E < Euler; E++)
                if (gcd(E, Euler) == 1)
                    return true;

            return false;
        }
        
        // Вычисляется число d, мультипликативно обратное к числу E по модулю функции Эйлера от N,
        // то есть число, удовлетворяющее сравнению:  d ⋅ E ≡ 1 (mod φ(N))
        private bool calculatePrivateKey()
        {
            d = 0;
            Int64 Euler = (P - 1) * (Q - 1);

            for (d = N - 1; d > 2; d--)
            {
                if (d * E % Euler == 1)
                {
                    return true;
                }
            }

            return false;
        }
        
        // Генерация алфавита
        //
        private void GenerateCharacter()
        {
            if (character.Count > 0)
                return;

            for (char i = 'а'; i <= 'я'; i++)
                character.Add(i);
            for (char i = 'a'; i <= 'z'; i++)
                character.Add(i);
            for (char i = 'А'; i <= 'Я'; i++)
                character.Add(i);
            for (char i = 'A'; i <= 'Z'; i++)
                character.Add(i);
            for (Int32 i = 0; i < 10000; i++)
                character.Add(Convert.ToChar(i));

            return;
        }

        //
        // Check for simplicity (for P and Q)
        private bool isPrime(Int64 n)
        {
            if (n < 2)
                return false;

            for (Int64 i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        // GCD calculation for E
        // Recursive method
        private Int64 gcd(Int64 a, Int64 b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }
    }
}