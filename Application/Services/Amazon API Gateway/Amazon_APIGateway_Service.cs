using Domain.Entities;
using Infrastructure.Amazon_API_Gateway;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Amazon_API_Gateway
{
    public class Amazon_APIGateway_Service
    {
        private Amazon_APIGateway amazon_APIGateway =  new Amazon_APIGateway();

        public async Task RegisterAParent(Person person) {
            using (var client = new HttpClient())
            {
                await client.PostAsJsonAsync("https://g78z22rva3.execute-api.us-east-1.amazonaws.com/Dev/person", person);
            }
            
        }







    }
; }
