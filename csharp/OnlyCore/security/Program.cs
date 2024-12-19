using security.security;

namespace security
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string message = "Muhammadqodir";
            //string crypted = Crypt.EnCrypt(message);
            //Console.WriteLine(crypted);

            //string cryptedMEssage = "Qyleqqehushmv";
            //string message = Crypt.DeCrypt(cryptedMEssage);
            //Console.WriteLine(message);
            string oldHash = "f476a17262b6f6bf7025e340ab8546af23391e5ae84cbc5c49c80a4b36910679";
            string password = "admin123";
            string passwordHash = Hasher.Hash(password);
            Console.WriteLine(oldHash == passwordHash);
        }
    }
}