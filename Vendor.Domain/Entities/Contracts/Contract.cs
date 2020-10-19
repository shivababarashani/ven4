using System;
using System.Collections.Generic;
using System.Text;

namespace Vendor.Domain.Entites.Contracts
{
    public class Contract
    {
        public long Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ContractingParty { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string ProductName { get; set; }
        public decimal WeightNumber { get; set; }
        public string Description { get; set; }
        public DateTime DeliveryTime { get; set; }
        public decimal Progress { get; set; }
        public long ContractTypeId { get; set; }
        public long UnitId { get; set; }
        public string UserId { get; set; }
        public virtual ContractType ContractType { get; set; }
        public virtual Unit Unit { get; set; }


    }
}
