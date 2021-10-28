using System;
using System.Collections.Generic;
using Appmilla.Yapily.Refit.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace YapilyDemo.UX
{
    public class AccountViewModel : ReactiveObject
    {
        [Reactive]
        public Guid CacheKey { get; set; }

        [Reactive]
        public string Id { get; set; }

        [Reactive]
        public string Type { get; set; }

        [Reactive]
        public string Description { get; set; }

        [Reactive]
        public double? Balance { get; set; }

        [Reactive]
        public string Currency { get; set; }

        [Reactive]
        public AccountUsageType? UsageType { get; set; }

        [Reactive]
        public AccountType? AccountType { get; set; }

        [Reactive]
        public string Nickname { get; set; }

        [Reactive]
        public string Details { get; set; }
       
        [Reactive]
        public List<AccountName> AccountNames { get; set; }

        [Reactive]
        public List<AccountIdentification> AccountIdentifications { get; set; }

        [Reactive]
        public List<AccountBalance> AccountBalances { get; set; }
    }
}
