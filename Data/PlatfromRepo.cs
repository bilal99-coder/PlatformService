using System.Collections.Generic;
using System.Linq;
using PlatformService.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace PlatformService.Data;
public class PlatformRepo : IPlatformRepo
{
    private readonly AppDbContext _context;

    public PlatformRepo(AppDbContext context)
    {
        _context = context;
    }

    public void CreatePlatform(Platform Plat)
    {
        if (Plat == null ){
            throw new ArgumentNullException(nameof(Plat)); 
        }

        _context.Platforms.Add(Plat); 
    }

    public IEnumerable<Platform> GetAllPlatforms()
    {
        return _context.Platforms.ToList(); 
    }

    public Platform GetPlatformById(int id)
    {
        return _context.Platforms.FirstOrDefault( p => p.Id == id); 
    }

    public bool saveChanges()
    {
        return (_context.SaveChanges() >=0); 
    }

   
}

