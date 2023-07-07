using System.ComponentModel.DataAnnotations.Schema;

namespace Websample.Repository
{
    public class product
    {
        [ForeignKey(nameof(customer))]
        public int Id { get; set; }
    }
}
