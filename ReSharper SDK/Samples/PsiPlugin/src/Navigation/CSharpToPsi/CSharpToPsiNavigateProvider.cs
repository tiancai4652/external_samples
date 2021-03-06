﻿using System.Collections.Generic;
using JetBrains.Application.DataContext;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Feature.Services.ContextNavigation;
using JetBrains.ReSharper.Feature.Services.Search;
using JetBrains.ReSharper.Features.Finding.ExecutionHosting;

namespace JetBrains.ReSharper.PsiPlugin.Navigation.CSharpToPsi
{
  [ContextNavigationProvider]
  public class CSharpToPsiNavigateProvider : PsiNavigateFromHereProvider<CSharpToPsiContextSearch, GotoPsiRuleDescriptor, CSharpToPsiSearchRequest>, INavigateFromHereProvider
  {
    public CSharpToPsiNavigateProvider(IFeaturePartsContainer manager) : base(manager)
    {
    }

    public IEnumerable<ContextNavigation> CreateWorkflow(IDataContext dataContext)
    {
      var execution = GetSearchesExecution(dataContext, DefaultNavigationExecutionHost.Instance);
      if (execution != null)
      {
        yield return new ContextNavigation(
          "Go to PSI rule",
          null,
          NavigationActionGroup.Blessed,
          execution);
      }
    }

    protected override GotoPsiRuleDescriptor CreateSearchDescriptor(CSharpToPsiSearchRequest searchRequest, ICollection<IOccurence> occurences)
    {
      return new GotoPsiRuleDescriptor(searchRequest, occurences);
    }
  }
}
