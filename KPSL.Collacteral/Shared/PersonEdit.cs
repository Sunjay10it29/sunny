﻿using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Rules;

namespace KPSL.Collacteral.Shared
{
  [Serializable]
  public class PersonEdit : BusinessBase<PersonEdit>
  {
    public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(nameof(Name));
    public string Name
    {
      get => GetProperty(NameProperty);
      set => SetProperty(NameProperty, value);
    }

    [ObjectAuthorizationRules]
    private static void PerTypeRules()
    {
      Csla.Rules.BusinessRules.AddRule(
        typeof(PersonEdit),
        new Csla.Rules.CommonRules.IsInRole(
          Csla.Rules.AuthorizationActions.CreateObject,
          "admin"));
    }

    protected override void AddBusinessRules()
    {
      base.AddBusinessRules();
      BusinessRules.AddRule(
        new Csla.Rules.CommonRules.IsInRole(
          Csla.Rules.AuthorizationActions.ReadProperty, 
          NameProperty, 
          "supervisor")
          );

          BusinessRules.AddRule(
        new Csla.Rules.CommonRules.IsInRole(
          Csla.Rules.AuthorizationActions.ReadProperty, 
          NameProperty, 
          "manager")
          );
    }
  }
}
