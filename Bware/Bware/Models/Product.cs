using System;
using System.Collections.Generic;

namespace Bware.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal ProductPrice { get; set; }

    public long ProductQuantity { get; set; }

    public string ProductType { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public string? ProductBrand { get; set; }
}
