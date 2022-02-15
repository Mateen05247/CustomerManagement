using Newtonsoft.Json;

namespace CustomerManagement.Model
{
    public class DBhandle
    {
        public string viewcustomer()
        {
            EFDBContext context = new EFDBContext();
            var listP = from e in context.customers
                        select new
                        {
                            CustomerId = e.CustomerId,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            Country = e.Country,
                            CreatedDate = e.CreatedDate
                        };
            List<Customers> listS = new List<Customers>();
            foreach (var listE in listP)
            {
                Customers e = new Customers();
                e.CustomerId = listE.CustomerId;
                e.FirstName = listE.FirstName;
                e.LastName = listE.LastName;
                e.Country = listE.Country;
                e.CreatedDate = listE.CreatedDate;
                listS.Add(e);
            }

            return JsonConvert.SerializeObject(listS);
        }
        public Customers getcusonID(int CustomerId)
        {
            EFDBContext context = new EFDBContext();
            var cus = context.customers.Find(CustomerId);
            return cus;
        }

        public void Addcustomer(Customers c)
        { 
            EFDBContext context = new EFDBContext();
            c.CreatedDate = DateTime.Now;
            context.customers.Add(c);
            context.SaveChanges();
            return;
        }
        public void Deletecustomer(int id)
        {
            EFDBContext context = new EFDBContext();
            context.customers.Remove(context.customers.FirstOrDefault(c => c.CustomerId == id));
            context.SaveChanges();
            return;
        }
        public void Updatecustomer(Customers c)
        {
            EFDBContext context = new EFDBContext();
            Customers cust = context.customers.Find(c.CustomerId);
            cust.FirstName = c.FirstName;
            cust.LastName = c.LastName;
            cust.Country = c.Country;
           
            context.SaveChanges();
        }
    }
}  
