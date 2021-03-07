## General info

#### Problem
Caesar cipher is a an old way of transfering secret information back in medieval times.
The way it works is:

* You have a text such as this: "ABC"
* and the cipher has a shift, for example "+2"
* encrypted text will become: "CDE"
* If we decrypt, we get the same text as original - "ABC"

#### Built with
>C# console app

>Tests libraries - xUnit & Fluent Assertions

## Installation

### Requirements
* .NET 5.0 SDK

### Launch the App
* Open project folder:

  `cd path/to/folder/CaesarCipher`

* Run application:

  `dotnet run`

## Usage

```
------------------------------
       Ceasar Cipher
------------------------------
 Encrypt  |  Decrypt  |  Exit
------------------------------
   Type Your option below:
------------------------------
encrypt
  Enter Encrypt Key:
2
Enter text to Encrypt:
ABCD
..............................
Encrypted text: CDEF
------------------------------
       Ceasar Cipher
------------------------------
 Encrypt  |  Decrypt  |  Exit
------------------------------
   Type Your option below:
------------------------------
decrypt
   Enter Decrypt Key:
2
Enter text to Decrypt:
CDEF
...........................
Decrypted text: ABCD
```
