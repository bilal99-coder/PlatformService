using System.Collections.Generic;
using PlatformService.Models; 
namespace PlatformService.Data
{
    public interface IPlatformRepo  
    { 
        bool saveChanges(); 
        IEnumerable<Platform> GetAllPlatforms(); 
        
    }
}