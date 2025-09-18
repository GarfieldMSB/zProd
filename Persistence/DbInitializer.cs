using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.DASHusoCPUTotal.Any()) return;

        var usoCpu = new List<DASHusoCPUTotal>
        {
            new() {
                timestamp = DateTime.Parse("2025-09-17 09:39:35.000"),
                jobname = "OTROS",
                usoCpuPorcentaje = 2.22,
                owner = "TOTALCPU",
                lpar= "SO2P",
                tipochart= "OTROS",
                workload = "WTOTAL"
            },
            new() {
                timestamp = DateTime.Parse("2025-09-17 09:39:35.000"),
                jobname = "SURRUT1",
                usoCpuPorcentaje = 0,
                owner = "SURRUT1",
                lpar= "SO2P",
                tipochart= "OTROS",
                workload = "WTSO"
            },
            new() {
                timestamp = DateTime.Parse("2025-09-17 09:39:35.000"),
                jobname = "LFIGUE2",
                usoCpuPorcentaje = 0,
                owner = "LFIGUE2",
                lpar= "SO2P",
                tipochart= "OTROS",
                workload = "WTSO"
            },
            new() {
                timestamp = DateTime.Parse("2025-09-17 09:39:35.000"),
                jobname = "TMPDBMAS",
                usoCpuPorcentaje = 0,
                owner = "TMONUSER",
                lpar= "SO2P",
                tipochart= "OTROS",
                workload = "WSTC"
            },
            new() {
                timestamp = DateTime.Parse("2025-09-17 09:39:35.000"),
                jobname = "TMPDBLFS",
                usoCpuPorcentaje = 0,
                owner = "TMONUSER",
                lpar= "SO2P",
                tipochart= "OTROS",
                workload = "WSTC"
            }

        };

        context.DASHusoCPUTotal.AddRange(usoCpu);

        await context.SaveChangesAsync();
    }
}



