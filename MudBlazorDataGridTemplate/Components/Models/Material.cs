namespace MudBlazorDataGridTemplate.Components.Models;

public class Material
{
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public string? Batching { get; set; }
    public string? DefaultUnitOfWeight { get; set; }
    public string? ItemIdNumberFormat { get; set; }
    public string? NextBatchId { get; set; }
    public Guid? SampleOfMaterialId { get; set; }
    public int? ItemIdExpectedInheritances { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string? ModifiedBy { get; set; }
    public bool IsActive { get; set; }
}
