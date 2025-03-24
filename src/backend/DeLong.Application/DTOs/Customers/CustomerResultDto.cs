﻿using DeLong.Application.DTOs.Users;

namespace DeLong.Application.DTOs.Customers;

public class CustomerResultDto
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? INN { get; set; }
    public string? JSHSHIR { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string MFO { get; set; } = string.Empty;
    public string BankAccount { get; set; } = string.Empty;
    public string BankName { get; set; } = string.Empty;
    public string? OKONX { get; set; }
    public string YurAddress { get; set; } = string.Empty;

    // firma rahbari malumotlari
    public long UserId { get; set; }
    public UserResultDto User { get; set; }
}
