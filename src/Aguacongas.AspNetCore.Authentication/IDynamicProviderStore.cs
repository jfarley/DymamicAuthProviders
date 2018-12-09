﻿// Project: DymamicAuthProviders
// Copyright (c) 2018 @Olivier Lefebvre
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Aguacongas.AspNetCore.Authentication
{
    public interface IDynamicProviderStore<TDefinition> 
        where TDefinition: SchemeDefinitionBase, new()
    {
        IQueryable<TDefinition> ProviderDefinitions { get; }

        Task AddAsync(TDefinition definition, CancellationToken cancellationToken = default(CancellationToken));
        Task<TDefinition> FindBySchemeAsync(string scheme, CancellationToken cancellationToken = default(CancellationToken));
        Task RemoveAsync(TDefinition definition, CancellationToken cancellationToken = default(CancellationToken));
        Task UpdateAsync(TDefinition definition, CancellationToken cancellationToken = default(CancellationToken));
    }
}