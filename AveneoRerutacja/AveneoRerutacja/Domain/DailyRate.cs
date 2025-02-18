﻿using AveneoRerutacja.Dimension;

namespace AveneoRerutacja.Domain
{
    public class DailyRate
    {
        public int Id { get; set; }
        public SourceCurrency SourceCurrency { get; set; }
        public TargetCurrency TargetCurrency { get; set; }
        public DateClass Date { get; set; }
        public decimal Rate { get; set; }

        public DailyRate() { }

        public DailyRate(string date, decimal rate, string sourceCurrencyCode, string targetCurrencyCode, 
            string sourceCurrencyName = null, string targetCurrencyName = null)
        {
            SourceCurrency = new SourceCurrency(sourceCurrencyCode, sourceCurrencyName);
            TargetCurrency = new TargetCurrency(targetCurrencyCode, targetCurrencyName);
            Date = new DateClass(date);
            Rate = rate;
        }
        
        public DailyRate(DateClass date, decimal rate, SourceCurrency sourceCurrency, TargetCurrency targetCurrency)
        {
            Date = date;
            Rate = rate;
            SourceCurrency = sourceCurrency;
            TargetCurrency = targetCurrency;
        }
    }
}