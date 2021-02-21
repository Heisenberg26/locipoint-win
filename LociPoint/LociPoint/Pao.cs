using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LociPoint
{
    public class Pao
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string people { get; set; }
        public string actions { get; set; }
        public string objects { get; set; }
        public int peopleIds { get; set; }
        public int actionsIds { get; set; }
        public int objectsIds { get; set; }
        public string paoName { get; set; }
        public string range { get; set; }
    }
}
