using System;
using System.Collections.Generic;

namespace FoodPaymentAPI.Model;

public partial class Customerenquiry
{
    public Guid Id { get; set; }

    public string Enquiriessubject { get; set; } = null!;

    public string Enquiriesdescription { get; set; } = null!;

    public DateTimeOffset? Datetimecreated { get; set; }

    public DateTimeOffset? Datetimeupdated { get; set; }

    public bool? Isdeleted { get; set; }

    public Guid Userid { get; set; }

    public virtual User User { get; set; } = null!;
}
