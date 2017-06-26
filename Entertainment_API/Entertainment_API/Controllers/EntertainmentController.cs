using EntertainmentDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Entertainment_API.Controllers
{
    public class EntertainmentController : ApiController
    {

        public IEnumerable<Event> Get()
        {
            using (MKEEntertainmentEntities db = new MKEEntertainmentEntities())
            {
                return db.Events.ToList();
            }
        }

        public Event Get(int id)
        {
            using (MKEEntertainmentEntities db = new MKEEntertainmentEntities())
            {
                return db.Events.FirstOrDefault(a => a.Id == id);
            }
        }

    }
}
