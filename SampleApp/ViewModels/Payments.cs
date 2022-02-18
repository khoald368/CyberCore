using System;

namespace SampleApp.ViewModels
{
    public class Payments
    {
        public int Id { get; set; }

        public Guid TransactionId { get; set; }

        public DateTime PaymentDate { get; set; }

        public string PaymentMethod { get; set; }
    }
}
