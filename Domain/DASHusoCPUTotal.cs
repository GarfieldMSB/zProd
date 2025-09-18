using System;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class DASHusoCPUTotal
{
    public int Id { get; set; }
    public DateTime timestamp { get; set; }
    public required string jobname { get; set; }
    public double usoCpuPorcentaje { get; set; }
    public string? owner { get; set; }
    public required string lpar { get; set; }
    public required string tipochart { get; set; }
    public string? workload { get; set; }
}
