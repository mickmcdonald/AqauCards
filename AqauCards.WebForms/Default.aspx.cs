// Decompiled with JetBrains decompiler
// Type: AqauCards.WebForms.Default
// Assembly: AqauCards.WebForms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 44A7849A-707A-4156-8959-65A0B523B802
// Assembly location: C:\projects\AquaTotsSite\AquaTotsSite\bin\AqauCards.WebForms.dll

using AquaCards.Business;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace AqauCards.WebForms
{
  public class Default : Page
  {
    protected HtmlForm form1;

    protected void Page_Load(object sender, EventArgs e)
    {
      Helper.WriteLog(string.Format("*DEBUG-METRICS* [Page_Load()] - Default.aspx [{0}]", (object)this.Request.ServerVariables["REMOTE_ADDR"].ToString()));
      this.Response.Redirect("https://frontdeskhq.com/oauth/authorize?client_id=vjmRpgBRrpjeUbWSL1ZP11gDmy9ahHXquDe8xuV4&response_type=code&redirect_uri=https://aquacards.net/callback.aspx");
    }
  }
}
