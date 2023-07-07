using System;
using System.Collections.Generic;

namespace FinalAPIProject.Models;

public partial class Orderdetail
{
    public int Orderid { get; set; }

    public int? Cusid { get; set; }

    public int? Productid { get; set; }

    public virtual Customer? Cus { get; set; }

    public virtual Productdetail? Product { get; set; }
}
