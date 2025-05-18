using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.ViewModel;
using WpfApp1List.Model;
using WpfApp1Todo.Model;
//using WpfApp1Todo.ViewModel;


namespace WpfApp1.Data
{
    
    public class TodoDataProvider  { 
        //static???
      public  async Task<List<Todo>> GetAllAsync()
       {
       var httpClient = new HttpClient();
  
       var response = await httpClient.GetFromJsonAsync<List<Todo>>("https://localhost:7169/api/Task");
         return response;
       }
        public async Task<List<Todo>> GetFilteredAsync_Checked()
        {
            var httpClient = new HttpClient();

            // Constructing the query string with multiple parameters
            var response = await httpClient.GetFromJsonAsync<List<Todo>>($"https://localhost:7169/api/Task/filternotchecked");

            return response;
        }

        public async Task<List<Todo>> GetFilteredAsync_Starred()
        {
            var httpClient = new HttpClient();

            // Constructing the query string with multiple parameters
            var response = await httpClient.GetFromJsonAsync<List<Todo>>($"https://localhost:7169/api/Task/filterisstareed");

            return response;
        }
        //delete///////////////////////////////////////////////////
        public async Task<int?> DeleteTodoAsync(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.DeleteAsync($"https://localhost:7169/api/Task/{id}");

                if (response.IsSuccessStatusCode){return id;}
                else{Console.WriteLine("Request failed with status code: " + response.StatusCode);
                    return null;}
            }
        }



        public async Task<Todo> UpdateTodoAsync(TodoItemViewModel todo)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PutAsJsonAsync($"https://localhost:7169/api/Task/{todo.Id}", todo);

                if (response.IsSuccessStatusCode)
                {
                    var updatedTodo = await response.Content.ReadFromJsonAsync<Todo>();
                    return updatedTodo;
                }
                else
                {
                    // اگر به روزرسانی ناموفق بود
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                    return null;
                }
            }
        }

        //creat/////////////////////////////////////////////////
      
           
               static int  creatid = 1;
        public async Task<Todo> CreateTaskAsync(int listid) {
            {
                var todo = new Todo { Name = $"New Task{creatid++}", Checked = false ,ListId=listid,Starred=false};

                var httpClient = new HttpClient();

                //response is HttpResponseMessage here
                var response = await httpClient.PostAsJsonAsync("https://localhost:7169/api/Task", todo);

                if (response.IsSuccessStatusCode)
                {
                    //convert http answer to Todo
                    var createdTodo = await response.Content.ReadFromJsonAsync<Todo>();
                    return createdTodo;
                }
                else
                {
                    MessageBox.Show("Request failed with status code: " + response.StatusCode);
                    return null;
                }

            } 
        }

        


    }




}



