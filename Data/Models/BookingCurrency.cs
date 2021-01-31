﻿using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class BookingCurrency
    {
        public int BookingId { get; set; }
        public string CurrencyCode { get; set; }
        public int CurrencyNumCode { get; set; }
        public double CurrencyValue { get; set; }
        public string CurrencySymbol { get; set; }
        public bool IsCodeBefore { get; set; }
        public double RoundNumbers { get; set; }
        public bool EnablePriceRounding { get; set; }

        public Booking Booking { get; set; }
    }
}