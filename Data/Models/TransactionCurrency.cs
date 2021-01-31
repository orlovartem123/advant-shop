﻿using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TransactionCurrency
    {
        public int TransactionId { get; set; }
        public string CurrencyCode { get; set; }
        public int CurrencyNumCode { get; set; }
        public double CurrencyValue { get; set; }
        public string CurrencySymbol { get; set; }
        public bool IsCodeBefore { get; set; }
        public double RoundNumbers { get; set; }
        public bool EnablePriceRounding { get; set; }

        public Transaction1 Transaction { get; set; }
    }
}
