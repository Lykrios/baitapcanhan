﻿using Pay1193.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay1193.Services
{
    public interface IPayService
    {
        Task CreateAsync(PaymentRecord paymentRecord);
        Task UpdateAsync(PaymentRecord paymentRecord);
        PaymentRecord GetById(int id);
        Task Delete(int id);
        TaxYear GetTaxYearById(int id);
        IEnumerable<PaymentRecord> GetAll();
        decimal OverTimeHours(decimal hoursWorked, decimal contractualHours);
        decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked, decimal hourlyRate);
        decimal OvertimeRate(decimal hourlyRate);
        decimal OvertimeEarnings(decimal overtimeHours, decimal overtimeRate);
        decimal TotalDeduction(decimal tax, decimal nic, decimal studentLoanRepayment, decimal unionFees);
        decimal TotalEarning(decimal contractualEarnings, decimal overtimeEarnings);
        decimal NetPay(decimal totalEarnings, decimal totalDeduction);
    }
}
