namespace BlazorGI.Components
{
    using System.ComponentModel.DataAnnotations;
    public class TestModel
    {
        [Required]
        public string? Name { get; set; }
        [Range(1,100)]
        public int? Quantity { get; set; }
    }
}
