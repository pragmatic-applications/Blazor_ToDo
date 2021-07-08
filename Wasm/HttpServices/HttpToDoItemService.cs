using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Constants;

using Domain;

using Lib_BrowserPlatform;

using Lib_Core;

using Wasm;

namespace HttpServices
{
    public class HttpToDoItemService : EntityService<ToDoItem>
    {
        public HttpToDoItemService(HttpClient httpClient) : base(httpClient)
        {
            httpClient.BaseAddress = DeployedState.IsDeployed ? new Uri(ClientConstant.Url_Api_Base_Deployed) : new Uri(ClientConstant.Url_Api_Base);

            this.HttpClient = httpClient;
            this.Url = PageRoute.S_Api_ToDoItems_S;
            this.UrlApiUploader = HttpConstant.Url_S_Api_Upload;
        }

        public async Task<PagingResponse<ToDoItem>> GetEntitiesAsync(EntityParameter entityParameter) => await this.GetAsync(entityParameter: entityParameter);

        public async Task<List<ToDoItem>> GetEntitiesAsync() => await this.GetAsync();

        public async Task<ToDoItem> GetEntityByIdAsync(int id) => await this.GetAsync(id);

        public async Task AddEntityAsync(ToDoItem model) => await this.PostAsync(model);

        public async Task EditEntityAsync(int id, ToDoItem model) => await this.PutAsync(id, model);

        public async Task DeleteEntityAsync(int id) => await this.DeleteAsync(id);
    }
}
