using CyberCore.DataMining.Attributes;

namespace SampleApp.ViewModels
{
    [BaseView(TableName = "Customers")]
    public class Customers
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int Status { get; set; }
    }
}
