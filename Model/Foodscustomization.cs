using System;
using System.Collections.Generic;

namespace FoodPaymentAPI.Model;

public partial class Foodscustomization
{
    public Guid Id { get; set; }

    public string Foodcustomizationname { get; set; } = null!;

    public decimal Foodcustomizationprice { get; set; }

    public DateTimeOffset? Datetimecreated { get; set; }

    public DateTimeOffset? Datetimeupdated { get; set; }

    public bool? Isdeleted { get; set; }

    public Guid Foodid { get; set; }

    public virtual Food Food { get; set; } = null!;
}
