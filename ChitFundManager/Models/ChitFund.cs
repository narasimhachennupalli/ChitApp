namespace ChitFundManager.Models;

/// <summary>
/// Represents a chit fund group
/// </summary>
public class ChitFund
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal TotalAmount { get; set; }
    public int NumberOfMembers { get; set; }
    public int DurationMonths { get; set; }
    public DateTime StartDate { get; set; }
    public bool IsActive { get; set; }
}
