using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gionet.blazor.Data;
using Gionet.blazor.Models;

namespace Gionet.blazor.Data.Services
{
    public class Clientesclass
    {
        private readonly u598002034_fnZfTContext _bdatos;

        public Clientesclass(u598002034_fnZfTContext bdatos)
        {
            _bdatos = bdatos;
        }
        public List<Cliente> Lclientes()
        {
            var lista = _bdatos.Clientes.ToList();
            return lista;
        }
    }
}
