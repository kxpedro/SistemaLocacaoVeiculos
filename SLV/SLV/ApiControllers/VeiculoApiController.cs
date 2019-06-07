using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLV.ApiControllers
{
    public class VeiculoApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[];
        }

        // GET api/<controller>/5
        public string GetById(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}