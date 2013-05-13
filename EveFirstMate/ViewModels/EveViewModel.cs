using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using EveFirstMate.Models;

namespace EveFirstMate.ViewModels
{
    public class EveViewModel
    {
        public List<invMarketGroup> marketGroups { get; set; }

        public EveViewModel()
        {
            marketGroups = new List<invMarketGroup>();
        }
    }
}
