using System;

namespace ProCoding.Demos.ASPNetCore.DependencyInjection.Services
{
    public class ServiceImplementation : IService
    {
        private readonly Guid _guid = Guid.NewGuid();
        public Guid GetGuid() => _guid;
    }
}