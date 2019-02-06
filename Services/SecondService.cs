using System;

namespace ProCoding.Demos.ASPNetCore.DependencyInjection.Services
{
    public class SecondService : IService
    {
        private readonly IService _service;
        public SecondService(IService service)
        {
            _service = service;
        }

        public Guid GetGuid() => _service.GetGuid();
    }
}