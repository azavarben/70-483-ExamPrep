using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Encryption
{
    public class FileEncrypt
    {
        public void EncryptFile()
        {
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyDataFile.txt");

            var fileContents = "super secret shit";

            var bytes = Encoding.Unicode.GetBytes(fileContents);

            File.WriteAllText(fileName, fileContents);

            File.Encrypt(fileName); //encrypts it using the current windows logon?
        }

    }
}
