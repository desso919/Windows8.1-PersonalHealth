using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalHealth.Services.Interfaces;
using Newtonsoft.Json;
using PersonalHealth.Models.AppModels;

namespace PersonalHealthServices.Impl.Impl
{
    public class PatientService : IPatientService
    {
        public async Task<Patient> loginAsync(string username, string password)
        {
           string json = await WebService.getInstance().GetPatientByUsernameAndPasswordAsync(username, password);        
           return JsonConvert.DeserializeObject<Patient>(json);
        }
    }
}
