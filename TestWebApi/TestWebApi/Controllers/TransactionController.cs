using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebApi.Models;
namespace TestWebApi.Controllers
{
    public class TransactionController : ApiController
    {
        // GET: api/Transaction
        [HttpGet]
        public IEnumerable<Transaction> GetAllTransaction()
        {
            Transaction t = new Transaction();
            Transaction t1 = new Transaction();
            List<Transaction> li = new List<Transaction>();

            t.ApplicationId = 101;
            t.Type = "Debit";
            t.Summary = "Payment";
            t.Amount = 50;
            t.PostingDate = DateTime.Now;
            t.IsCleared = true;
            t.ClearedDate = DateTime.Now;

            t1.ApplicationId = 102;
            t1.Type = "Debit";
            t1.Summary = "Payment";
            t1.Amount = 100;
            t1.PostingDate = DateTime.Now;
            t1.IsCleared = true;
            t1.ClearedDate = DateTime.Now;

            li.Add(t);
            li.Add(t1);
            return li;
        }

        public IEnumerable<Transaction> Get(int id)
        {
            Transaction t = new Transaction();
            Transaction t1 = new Transaction();
            List<Transaction> li = new List<Transaction>();
            if (id == 1)
            {
                t.ApplicationId = 101;
                t.Type = "Debit";
                t.Summary = "Payment";
                t.Amount = 50;
                t.PostingDate = DateTime.Now;
                t.IsCleared = true;
                t.ClearedDate = DateTime.Now;
                li.Add(t);
            }
            else
            {
                t1.ApplicationId = 102;
                t1.Type = "Debit";
                t1.Summary = "Payment";
                t1.Amount = 100;
                t1.PostingDate = DateTime.Now;
                t1.IsCleared = true;
                t1.ClearedDate = DateTime.Now;
                li.Add(t1);
            }
            return li;
        }


        // POST: api/Transaction
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Transaction/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Transaction/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
