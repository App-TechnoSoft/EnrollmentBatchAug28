﻿namespace EDental.Infrastructure.Data.Models;
public class Procurement
{
    public int Id { get; set; }
    public string Particulars { get; set; }
    public string Vendor { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Warranty { get; set; }
    public DateTime PurchaseDate { get; set; }
}
