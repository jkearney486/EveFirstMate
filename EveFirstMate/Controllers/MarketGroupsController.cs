using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using EveFirstMate.Models;

namespace EveFirstMate.Controllers
{
    public class MarketGroupsController : ApiController
    {
        private EVEEntities db = new EVEEntities();

        // GET api/MarketGroups
        public IEnumerable<invMarketGroup> GetinvMarketGroups()
        {
            var invmarketgroups = db.invMarketGroups.Where(x => x.invMarketGroup1 == null);
            return invmarketgroups.OrderBy(x => x.marketGroupName);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}