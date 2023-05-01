﻿namespace CerbiSharp.Infrastructure.BaseInfrastructure.Net
{
    public interface IClientApiIntraction
    {
        string ClientId { get; set; }
        Guid DeviceId { get; set; }
        string DomainUrl { get; set; }
        string JwtToken { get; set; }

        public HttpClient CreateHttpClient();
    }
}