using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Moodle
{
    internal class UsuariosMoodle
    {
        private static string moodleUrl = "http://localhost/webservice/rest/server.php";
        private static string token = "b0a4229454aeff94a9f0073a32e17031";

        //Create
        static async Task CreateUser()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {


                    string function = "core_user_create_users";

                    client.BaseAddress = new Uri(moodleUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

                    Dictionary<string, string> postData = new Dictionary<string, string>
                {
                    { "users[0][username]", "tetuser888" },
                    { "users[0][password]", "TtPassword123!" },
                    { "users[0][firstname]", "An8" },
                    { "users[0][lastname]", "Examp44" },
                    { "users[0][email]", "eltomv948888@gmail.com" }
                };

                    FormUrlEncodedContent content = new FormUrlEncodedContent(postData);

                    HttpResponseMessage response = await client.PostAsync($"/webservice/rest/server.php?wstoken={token}&wsfunction={function}&moodlewsrestformat=json", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(result);

                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Get
        static async Task GetUsersbyID(int id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {


                    string function = "core_user_get_users_by_field";

                    client.BaseAddress = new Uri(moodleUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync($"/webservice/rest/server.php?wstoken={token}&wsfunction={function}&field=id&values[0]={id}&moodlewsrestformat=json");




                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        static async Task GetUsers()
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
                        string result = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Delete
        static async Task DeleteUsersbyID(int id)
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
                        string result = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(result);

                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                    Console.ReadKey();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Update
        static async Task UpdateUser(int id)
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
                        string result = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(result);

                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
