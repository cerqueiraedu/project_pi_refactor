using System.Collections.Generic;
using System.Linq;
using PerformanceBiller.Entities;
using PerformanceBiller.Infra.DTO.Repositories.Abstractions;
using PerformanceBiller.Infra.Factories;
using PerformanceBiller.Repositories.Abstractions;

namespace PerformanceBiller.Infra.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public readonly IPlayDtoRepository PlayDtoRepository;
        public readonly IInvoiceDtoRepository InvoiceDtoRepository;

        public InvoiceRepository(
            IPlayDtoRepository playDtoRepository, 
            IInvoiceDtoRepository invoiceDtoRepository)
        {
            PlayDtoRepository = playDtoRepository;
            InvoiceDtoRepository = invoiceDtoRepository;
        }

        public IEnumerable<Invoice> Get()
        {
            var plays = PlayDtoRepository.Get();

            return InvoiceDtoRepository
                .Get()
                .Select(invoice =>
                {
                    var invoiceItem = new Invoice(new Customer(invoice.Customer));
                    
                    invoice
                        .Performances
                        .Select(performance => 
                        {
                            var play = plays.GetValueOrDefault(performance.PlayId);

                            return new Performance(
                                PlayGenreFactory.PlayGenreFactoryInstance.Build(play.Type), 
                                performance.Audience,
                                play.Name);
                        })
                        .ToList()
                        .ForEach(invoiceItem.AddPerformance);
                   
                    return invoiceItem;
                });
        }
    }
}
