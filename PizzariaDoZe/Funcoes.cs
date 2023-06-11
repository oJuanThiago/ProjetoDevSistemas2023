using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PizzariaDoZe
{
    internal class Funcoes
    {
        public static void AjustaResourcesControl(Control container)
        {
            foreach (Control c in container.Controls)
            {
                AjustaResourcesControl(c);
                ComponentResourceManager resources = new(typeof(Properties.Resources));
                resources.ApplyResources(c, c.Name);
            }
        }

        /// string hash = ClassFuncoes.Sha256Hash(textBoxSenha.Text);
        public static string Sha256Hash(string senha)
        {
            // Create a new Stringbuilder to collect the bytes and create a string.
            var hash = new StringBuilder();
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                // Loop through each byte of the hashed data and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    hash.Append(data[i].ToString("x2"));
                }
            }
            // retorna o hash SHA256.
            return hash.ToString();
        }

        internal static byte[] ConverteImagemParaByteArray(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            if (image != null)
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

            return memoryStream.ToArray();
        }
    }
}
