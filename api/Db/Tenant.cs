using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace yapt.Db
{
    public class Tenant
    {

        public int TenantId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^([a-zA-Z0-9]+)$", ErrorMessage = "Invalid Tenant String")]
        public string TenantString { get; set; }
    }
}