using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.ViewModel;
using WpfApp1List.Model;
using WpfApp1Todo.Model;

namespace WpfApp1.Data
{
   
        public class TodoListDataProvider 
        {
        public  async Task<List<TodoList>> GetAllAsync()
        {

            var httpClient = new HttpClient();

            var response = await httpClient.GetFromJsonAsync<List<TodoList>>("http://localhost:3000/List");
            return response;
        }

        public async Task<TodoList> GetByIdListAsync(int id)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetFromJsonAsync<TodoList>($"http://localhost:3000/List/{id}");
            return response;
        }

        public async Task<int?> DeleteTodoAsync(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.DeleteAsync($"http://localhost:3000/List/{id}");

                if (response.IsSuccessStatusCode) { return id; }
                else
                {
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                    return null;
                }
            }
        }



        public async Task<TodoList> UpdateTodoAsync(TodoListItemViewModel todo)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PutAsJsonAsync($"http://localhost:3000/List/{todo.Id}", todo);

                if (response.IsSuccessStatusCode)
                {
                    // دریافت وظیفه به روزرسانی شده از سرور
                    var updatedTodo = await response.Content.ReadFromJsonAsync<TodoList>();
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


        public async Task<TodoList> CreateTaskAsync()
        {
            {
                var todo = new TodoList { Name = "New List"};

                var httpClient = new HttpClient();

                //response is HttpResponseMessage here
                var response = await httpClient.PostAsJsonAsync("http://localhost:3000/List", todo);

                if (response.IsSuccessStatusCode)
                {
                    //convert http answer to Todo
                    var createdTodo = await response.Content.ReadFromJsonAsync<TodoList>();
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
        
    

