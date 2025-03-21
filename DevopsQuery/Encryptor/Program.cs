//*********************************************************************************************************************************
// File Name			:	Program.cs
// Author				:	Anand Naikar <anandyn29@gmail.com>  
// Description			:	Initial Version
// Date(dd-MM-yyyy)		:	2-12-2022
// Copyright (c) | All Rights Reserved
//*********************************************************************************************************************************

using Encryptor;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter plain text to encrypt : ");
        var plainText = Console.ReadLine().Trim();
        var encryptedText = EncryptionHandler.Encrypt(plainText);
        var decryptedeText = EncryptionHandler.Decrypt(encryptedText);

        Console.WriteLine($"Encrypted text is : {Environment.NewLine}{encryptedText}");
       // Console.WriteLine($"Decrypted text is : {Environment.NewLine}{decryptedeText}");

        Console.WriteLine("Press any key to exit ");
        Console.ReadKey();
    }
}