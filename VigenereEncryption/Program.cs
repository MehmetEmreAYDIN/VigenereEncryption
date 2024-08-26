char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();   //Enter letters of the alphabet in this field
char[] plainText = "AçıkMetin".ToUpper().ToCharArray();   //Enter plain text in this field
char[] key = "Anahtar".ToUpper().ToCharArray();   //Enter the key in this field

int[] keyNums = new int[key.Length];
for (int i = 0; i < keyNums.Length; i++)
{
    keyNums[i] = Array.IndexOf(alphabet, key[i]);
}

string cipherText = string.Empty;
for (int i = 0; i < plainText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, plainText[i]) + keyNums[i % key.Length]) % alphabet.Length;
    cipherText += alphabet[ndx];
}
Console.WriteLine(cipherText);