using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace moodle
{
    public class UsuarioMoodle {
        private string moodleUrl = "http://localhost/webservice/rest/server.php";
        private string token = "b0a4229454aeff94a9f0073a32e17031";
        
        public async Task<string> CreateUser() {
            try {
                using (HttpClient client = new HttpClient()) {
                    string function = "core_user_create_users";
                    client.BaseAddress = new Uri(moodleUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                    Dictionary<string, string> postData = new Dictionary<string, string> {
                        { "users[0][username]", "tetuser888" },
                        { "users[0][password]", "TtPassword123!" },
                        { "users[0][firstname]", "An8" },
                        { "users[0][lastname]", "Examp44" },
                        { "users[0][email]", "eltomv948888@gmail.com" }
                    };

                    FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
                    HttpResponseMessage response = await client.PostAsync($"/webservice/rest/server.php?wstoken={token}&wsfunction={function}&moodlewsrestformat=json", content);

                    if (response.IsSuccessStatusCode) {
                        return await response.Content.ReadAsStringAsync();
                    } else {
                        return response.StatusCode.ToString();
                    }
                }
            } catch (Exception exception) {
                throw exception;
            }
        }
        public async Task<string> GetUsersbyID(int id) {
            try {
                using (HttpClient client = new HttpClient()) {
                    string function = "core_user_get_users_by_field";
                    client.BaseAddress = new Uri(moodleUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync($"/webservice/rest/server.php?wstoken={token}&wsfunction={function}&field=id&values[0]={id}&moodlewsrestformat=json");

                    if (response.IsSuccessStatusCode) {
                        return await response.Content.ReadAsStringAsync();
                    } else {
                        return response.StatusCode.ToString();
                    }
                }
            } catch (Exception exception) {
                throw exception;
            }
        }

        public async Task<string> GetUsers()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {


                    string function = "core_user_get_users";

                    client.BaseAddress = new Uri(moodleUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));



                    Dictionary<string, string> postData = new Dictionary<string, string>
                {
                    { "criteria[0][key]", "email" },
                    { "criteria[0][value]", "%@%"}
                };

                    FormUrlEncodedContent content = new FormUrlEncodedContent(postData);

                    HttpResponseMessage response = await client.PostAsync($"?wstoken={token}&wsfunction={function}&moodlewsrestformat=json", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();

                    }
                    else
                    {
                        return response.StatusCode.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<string> DeleteUsersbyID(int id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    string function = "core_user_delete_users";

                    client.BaseAddress = new Uri(moodleUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));


                    Dictionary<string, string> postData = new Dictionary<string, string>
                {
                     { "userids[0]", id.ToString() }
                };

                    FormUrlEncodedContent content = new FormUrlEncodedContent(postData);

                    HttpResponseMessage response = await client.PostAsync($"/webservice/rest/server.php?wstoken={token}&wsfunction={function}&moodlewsrestformat=json", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();

                    }
                    else
                    {
                        return response.StatusCode.ToString();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public async Task<string> UpdateUser(int id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {


                    string function = "core_user_update_users";

                    client.BaseAddress = new Uri(moodleUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

                    Dictionary<string, string> postData = new Dictionary<string, string>
             {
                 { "users[0][id]", id.ToString() },
                 { "users[0][username]", "usermodificado" },
                 { "users[0][password]", "TtPassword123!" },
                 { "users[0][firstname]", "modificado" },
                 { "users[0][lastname]", "modificado" },
             };

                    FormUrlEncodedContent content = new FormUrlEncodedContent(postData);

                    HttpResponseMessage response = await client.PostAsync($"/webservice/rest/server.php?wstoken={token}&wsfunction={function}&moodlewsrestformat=json", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();

                    }
                    else
                    {
                        return response.StatusCode.ToString();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
