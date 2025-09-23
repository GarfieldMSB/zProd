using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class DASHusoCPUTotalController(AppDbContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<DASHusoCPUTotal>>> GetUsoCpuTotal()
    {
        return await context.DASHusoCPUTotal.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DASHusoCPUTotal>> GetUsoCpuTotalDetalle(int id)
    {
        var usoCpu = await context.DASHusoCPUTotal.FindAsync(id);

        if (usoCpu == null) return NotFound();

        return usoCpu;
    }
}
