using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuServicoWebAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public bool Ativo { get; set; }
    }
}