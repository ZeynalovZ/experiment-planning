using System;

namespace Lab6
{
    class ClientFactory : IFactory<Client>
    {

        public ClientFactory()
        {
        }

        public Client Create()
        {
            return new Client(null);
        }
    }
}
