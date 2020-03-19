﻿using System;
using Csla;

namespace KPSL.Collacteral.Shared
{
  [Serializable]
  public class CustomIdentity : Csla.Security.CslaIdentityBase<CustomIdentity>
  {
    [Fetch]
    private void Fetch(UserCredentials credentials)
    {
      // validate credentials here
      if (!string.IsNullOrWhiteSpace(credentials.Username))
      {
        Name = credentials.Username;
        IsAuthenticated = true;
        AuthenticationType = "Custom";
        Roles = new Csla.Core.MobileList<string>
        {
          "admin",
          "user"
        };
      }
      else
      {
        Name = string.Empty;
        IsAuthenticated = false;
        AuthenticationType = string.Empty;
        Roles = new Csla.Core.MobileList<string>();
      }
    }
  }
}
