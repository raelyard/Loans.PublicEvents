using System;

namespace MediaLoanLibrary.Loans.PublicEvents
{
    public interface LoanConsumatedEvent
    {
        int LoanId { get; set; }
        DateTime DueDate { get; set; }
    }
}
