using System;
using System.Collections.Generic;

namespace DrugManagement.Data.Entities;

public partial class TblDrug
{
    public int DrugId { get; set; }

    public string? DrugName { get; set; }

    public string? Cost { get; set; }

    public string? ExpiryDate { get; set; }
}
