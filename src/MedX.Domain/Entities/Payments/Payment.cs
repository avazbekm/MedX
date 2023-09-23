﻿using MedX.Domain.Commons;
using MedX.Domain.Enums;

namespace MedX.Domain.Entities;

public class Payment : Auditable
{
    public bool IsPaid { get; set; } 
    public decimal Amount { get; set; }
    public string PaymentFor { get; set; }
    public long AppointmentId { get; set; }
    public Appointment Appointment { get; set; }
    public TypeOfPayment TypeOfPayment { get; set; }
}