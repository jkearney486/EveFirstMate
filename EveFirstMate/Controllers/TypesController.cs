using EveFirstMate.ViewModels;
using EveFirstMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EveFirstMate.Controllers
{
    public class TypesController : ApiController
    {
        // GET api/types
        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET api/types/5
        public TypeViewModel Get(int id)
        {
            using (EVEEntities entities = new EVEEntities())
            {
                invType itemType = entities.invTypes.SingleOrDefault(x => x.typeID == id);
                TypeViewModel vm = new TypeViewModel(itemType);

                return vm;
            }
        }

        // POST api/types
        /*public void Post([FromBody]string value)
        {
        }

        // PUT api/types/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/types/5
        public void Delete(int id)
        {
        }*/
    }
}
