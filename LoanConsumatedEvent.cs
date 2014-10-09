using System;

namespace MediaLoanLibrary.Loans.PublicEvents
{
    public interface LoanConsumatedEvent
    {
        Guid LoanId { get; set; }
        DateTime DueDate { get; set; }
    }
}
