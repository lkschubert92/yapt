using System.Collections.Generic;

namespace yapt.Db
{
    public class Tenant
    {

        public int TenantId { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}