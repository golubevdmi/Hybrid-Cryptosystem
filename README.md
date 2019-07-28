# Hybrid-Cryptosystem
RC4, RSA

## About

This project implements a combined message encryption system.

## Hybrid Cryptosystem

### To encrypt a message addressed to Alice in a hybrid cryptosystem, Bob does the following:

1. Obtains Alice's public key.
2. Generates a fresh symmetric key for the data encapsulation scheme.
3. Encrypts the message under the data encapsulation scheme, using the symmetric key just generated.
4. Encrypts the symmetric key under the key encapsulation scheme, using Alice's public key.
5. Sends both of these encryptions to Alice.

### To decrypt this hybrid ciphertext, Alice does the following:

1. Uses her private key to decrypt the symmetric key contained in the key encapsulation segment.
2. Uses this symmetric key to decrypt the message contained in the data encapsulation segment.
