using System;
using System.Collections.Generic;
using System.Text;

namespace AppRpgEtec.Models
{
    public class Usuario
    {
        public string Id { get; set; }

        public string UserName { get; set; }
        
        public string PasswordString { get; set; }

        public string Perfil { get; set; }

        public string Token { get; set; }

        public byte[] Foto { get; set; }
    }
}
