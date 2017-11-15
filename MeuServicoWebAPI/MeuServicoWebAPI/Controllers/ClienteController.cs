using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MeuServicoWebAPI.Models;

namespace MeuServicoWebAPI.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly Cliente[] Clientes = new Cliente[]
        {
            new Cliente { Id = 1, Nome = "Wesley Gibson", Email = "falecom@wesleygibson.net.br", Ativo = true},
            new Cliente { Id = 2, Nome = "Bob Singer", Email = "falecom@bobsinger.net.br", Ativo = true},
            new Cliente { Id = 3, Nome = "Edward Elric", Email = "falecom@edwardrideelric.net.br", Ativo = false}
        };

        // GET: api/Cliente
        public Cliente[] Get()
        {
            return Clientes;
        }

        // GET: api/Cliente/5
        public Cliente Get(int Id)
        {
            return Clientes.SingleOrDefault(x => x.Id == Id);
        }

        // POST: api/Cliente
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
