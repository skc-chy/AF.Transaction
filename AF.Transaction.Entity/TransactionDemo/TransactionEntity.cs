using System;

namespace AF.Transaction.Entity.TransactionDemo
{
    public sealed class TransactionEntity
    {
        public Guid EmpID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

    }
}
