using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalHealth.Models.AppModels;
using System.Collections;
using Newtonsoft.Json;

namespace PersonalHealthServices.Impl.Impl
{
    class PatientManager : ICollection<Patient>
    {
        private List<Patient> patientList;

        public PatientManager()
        {
            patientList = new List<Patient>();
        }

        public PatientManager(string json)
        {
            patientList = JsonConvert.DeserializeObject<List<Patient>>(json);
        }

        public int Count
        {
            get
            {
                return patientList.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(Patient item)
        {
            patientList.Add(item);
        }

        public void Clear()
        {
            patientList.Clear();
        }

        public bool Contains(Patient item)
        {
            return patientList.Contains(item);
        }

        public void CopyTo(Patient[] array, int arrayIndex)
        {
            patientList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Patient> GetEnumerator()
        {
            return patientList.GetEnumerator();
        }

        public bool Remove(Patient item)
        {
            return patientList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return patientList.GetEnumerator();
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(patientList);
        }
    }
}
