# Hybrid-Cryptosystem
RC4, RSA

## About

This project implements a combined message encryption system.

## Hybrid Cryptosystem Example

### To encrypt a message addressed to Alice in a hybrid cryptosystem, Bob does the following:

1. Obtains Alice's public key.
2. Generates a fresh symmetric key for the data encapsulation scheme.
3. Encrypts the message under the data encapsulation scheme, using the symmetric key just generated.
4. Encrypts the symmetric key under the key encapsulation scheme, using Alice's public key.
5. Sends both of these encryptions to Alice.

### To decrypt this hybrid ciphertext, Alice does the following:

1. Uses her private key to decrypt the symmetric key contained in the key encapsulation segment.
2. Uses this symmetric key to decrypt the message contained in the data encapsulation segment.

## RC4 (Rivest cipher 4 or Ron’s code)

Stream cipher widely used in various information security systems in computer networks (for example, in SSL and TLS protocols, wireless network security algorithms WEP and WPA).

### The main advantages of the cipher:

1. high speed;
2. variable key size.

### RC4 is quite vulnerable if:

1. no random or related keys are used;
2. one keystream is used twice.
