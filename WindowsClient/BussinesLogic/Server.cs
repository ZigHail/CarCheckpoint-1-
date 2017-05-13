using CarCheckpoint.Models;
using CarCheckpoint.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient.BussinesLogic
{
    public class Server
    {
        const string APP_PATH = "http://localhost:54776/api";

        public static AllUserData GetUser(string cardId)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{APP_PATH}/users/GetUserByCardId/{cardId}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<AllUserData>(result);
            }
        }
        public static User GetUser(int id)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{APP_PATH}/users/GetUserById/{id}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<User>(result);
            }
        }

        public static User GetUserInGarage(string garage)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{APP_PATH}/users/GetUserByGarage/{garage}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<User>(result);
            }
        }

        public static List<User> GetAllUsers()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{APP_PATH}/users/GetAllUsers").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<User>>(result);
            }
        }

        public static List<AdminSettings> GetAdminSettings()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{APP_PATH}/admin/GetSettings/").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<AdminSettings>>(result);
            }
        }

        public static List<WriteOff> GetAllWriteOff()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{APP_PATH}/admin/GetWriteOffs/").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<WriteOff>>(result);
            }
        }

         


        public static string AddUser(User user, string cardId)
        {
            var allAboutUser = new AllUserData()
            {
                Card = new RFIDCard() { CardId = cardId },
                User = user
            };
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync($"{APP_PATH}/users/AddUser", allAboutUser).Result;
                return response.StatusCode.ToString();
            }
        }

        public static string AddCardToUser(User user, string cardId)
        {
            var allAboutUser = new AllUserData()
            {
                Card = new RFIDCard() { CardId = cardId },
                User = user
            };
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync($"{APP_PATH}/users/AddCardToUser", allAboutUser).Result;
                return response.StatusCode.ToString();
            }
        }

        public static string ChangeSettings(List<AdminSettings> settings)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync($"{APP_PATH}/admin/ChangeSettings", settings).Result;
                return response.StatusCode.ToString();
            }
        }

        public static string WriteOff(int price)
        {            
            using (var client = new HttpClient())
            {                
                var response = client.PostAsJsonAsync($"{APP_PATH}/admin/WriteOff", price).Result;
                return response.StatusCode.ToString();
            }
        }
        public static string Pay(User user, double sum)
        {
            var payment = new Payment()
            {
                Sum = sum,
                PayUser = user
            };
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync($"{APP_PATH}/admin/Pay", payment).Result;
                return response.StatusCode.ToString();
            }
        }

    }
}



