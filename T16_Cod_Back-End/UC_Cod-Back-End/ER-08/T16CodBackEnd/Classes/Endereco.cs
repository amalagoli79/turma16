using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T16CodBackEnd.Classes
{
    public class Endereco
    {
        public string? logradouro {get; set;}  = " ";
        public int numero {get; set;}  = 0;
        public string? complemento {get; set;}  = " ";
        public bool endComercial {get; set;}  = false;
    }
}