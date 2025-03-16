﻿using DeLong.Domain.Common;

namespace DeLong.Domain.Entities;

public class CashRegister : Auditable
{
    public long UserId { get; set; }
    public User? User { get; set; }

    public long WarehouseId { get; set; }
    public Warehouse? Warehouse { get; set; }

    public decimal UzsBalance { get; set; }  // so'm mablag' qoldiq
    public decimal UzpBalance { get; set; }  // plastik mablag' qoldiq
    public decimal UsdBalance { get; set; }  // dollar mablag' qoldiq
    public decimal DebtAmount { get; set; } // Nasiya summasi

    public DateTimeOffset OpenedAt { get; set; } = GetUzbekistanTime();
    public DateTimeOffset? ClosedAt { get; set; }

    // Ombordan kirim va omborga chiqimlar bilan bog‘lanish uchun
    public List<CashTransfer> Transfers { get; set; } = new();

    private static DateTimeOffset GetUzbekistanTime()
    {
        TimeZoneInfo uzbTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Asia Standard Time");
        return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, uzbTimeZone);
    }
}