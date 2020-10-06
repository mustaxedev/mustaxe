using System;
using Microsoft.AspNetCore.Identity;

namespace Mustaxe.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string NomeCompleto { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Avatar { get; set; }
    }
}
