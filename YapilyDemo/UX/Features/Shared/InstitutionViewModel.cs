using System;
using System.Collections.Generic;
using Appmilla.Yapily.Refit.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace YapilyDemo.UX.Features.Shared
{
    public class InstitutionViewModel : ReactiveObject
    {
        [Reactive]
        public Guid CacheKey { get; set; }
        
        [Reactive]
        public List<Country> Countries { get; set; }
        
        [Reactive]
        public InstitutionCredentialsType? CredentialsType { get; set; }
        
        [Reactive]
        public InstitutionEnvironmentType? EnvironmentType { get; set; }
        
        [Reactive]
        public List<Appmilla.Yapily.Refit.Models.Features> Features { get; set; }
        
        [Reactive]
        public string FullName { get; set; }
        
        [Reactive]
        public string Id { get; set; }
        
        [Reactive]
        public List<Media> Media { get; set; }
        
        [Reactive]
        public string ImageUrl { get; set; }
        
        [Reactive]
        public System.Collections.Generic.IDictionary<string, MonitoringFeatureStatus> Monitoring { get; set; }
        
        [Reactive]
        public string Name { get; set; }
    }
}