using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerManagement.Model
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class APIController : ControllerBase
    {
        // GET: api/<APIController>
        [HttpGet]
        public string viewcus()
        {
            DBhandle db = new DBhandle();
            return db.viewcustomer();
        }

        // GET api/<APIController>/5
        [HttpGet("{id}")]
        [Route("getrecord")]
        public Customers Get(int CustomerId)
        {
            DBhandle db = new DBhandle();
            Customers cus = db.getcusonID(CustomerId);
            return cus;
        }

        // POST api/<APIController>
        [HttpPost]
        [Route("register")]
        public void Post(Customers c)
        {
            DBhandle db = new DBhandle();
            db.Addcustomer(c);
            return;
        }

        // PUT api/<APIController>/5
        [HttpPut]
        public void Put(Customers c)
        {
            DBhandle db = new DBhandle();
            db.Updatecustomer(c);
            return;
        }

        // DELETE api/<APIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DBhandle db = new DBhandle();
            db.Deletecustomer(id);
            return;
        }
    }
}
