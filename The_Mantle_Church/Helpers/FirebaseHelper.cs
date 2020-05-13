using Firebase.Database;
using The_Mantle_Church.Model;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;

namespace The_Mantle_Church.Helpers
{
    class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://themantleapp.firebaseio.com/");

        public async Task<List<Person>> GetAllPersons()
        {

            return (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Select(item => new Person
              {
                  Name = item.Object.Name,
                  PersonId = item.Object.PersonId,
                  PhoneNo = item.Object.PhoneNo,
                  Department = item.Object.Department,
                  Location = item.Object.Location
              }).ToList();
        }

        public async Task AddPerson(int personId, string name, string Location, string PhoneNo, string Department)
        {

            await firebase
              .Child("Persons")
              .PostAsync(new Person() { PersonId = personId, Name = name, Location = Location, PhoneNo = PhoneNo, Department = Department});
        }

        //public async Task<Person> GetPerson(int personId)
        //{
        //    var allPersons = await GetAllPersons();
        //    await firebase
        //      .Child("Persons")
        //      .OnceAsync<Person>();
        //    return allPersons.Where(a => a.PersonId == personId).FirstOrDefault();
        //}

        //public async Task UpdatePerson(int personId, string name)
        //{
        //    var toUpdatePerson = (await firebase
        //      .Child("Persons")
        //      .OnceAsync<Person>()).Where(a => a.Object.PersonId == personId).FirstOrDefault();

        //    await firebase
        //      .Child("Persons")
        //      .Child(toUpdatePerson.Key)
        //      .PutAsync(new Person() { PersonId = personId, Name = name });
        //}

        //public async Task DeletePerson(int personId)
        //{
        //    var toDeletePerson = (await firebase
        //      .Child("Persons")
        //      .OnceAsync<Person>()).Where(a => a.Object.PersonId == personId).FirstOrDefault();
        //    await firebase.Child("Persons").Child(toDeletePerson.Key).DeleteAsync();

        //}
    }

}