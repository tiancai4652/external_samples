﻿using System.ComponentModel.Composition;
using AgentMulder.ReSharper.Domain.Patterns;
using JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch;
using JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders;
using JetBrains.ReSharper.Psi.Services.StructuralSearch;

namespace AgentMulder.Containers.SimpleInjector.Patterns
{
    [Export("ComponentRegistration", typeof(IRegistrationPattern))]
    public class RegisterSingleOpenGeneric : RegisterWithService
    {
        private static readonly IStructuralSearchPattern pattern =
            new CSharpStructuralSearchPattern("$container$.RegisterSingleOpenGeneric($arguments$)",
                new ExpressionPlaceholder("container", "global::SimpleInjector.Container", true),
                new ArgumentPlaceholder("arguments", -1, -1));

        public RegisterSingleOpenGeneric()
            : base(pattern)
        {
        }
    }
}