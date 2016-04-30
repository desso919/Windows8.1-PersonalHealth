using PersonalHealth.Models.AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalHealth.Services.Interfaces
{
    public interface IPatientService
    {
        Task<Patient> loginAsync(string username, string password);
    }
}
