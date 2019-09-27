namespace PerformanceBiller.Entities
{
    
    public class Statement
    {
        public Invoice Invoice { get; }
        public int TotalAmount => Invoice.CalculateAmount().CalculatedAmount;
        public int TotalExtraCredits => Invoice.CalculateVolumeCredits().VolumeCredits;

        public Statement(Invoice invoice)
        {
            Invoice = invoice;
        }
    }
}
