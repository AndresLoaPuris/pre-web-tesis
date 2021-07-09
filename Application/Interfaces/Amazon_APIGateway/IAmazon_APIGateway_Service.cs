using Application.Services.Amazon_API_Gateway;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Amazon_APIGateway
{
    public class IAmazon_APIGateway_Service
    {

        private Amazon_APIGateway_Service amazon_APIGateway_Service = new Amazon_APIGateway_Service();

        public async Task RegisterAParent(Person person) {
            await amazon_APIGateway_Service.RegisterAParent(person);
        }

    }
}
