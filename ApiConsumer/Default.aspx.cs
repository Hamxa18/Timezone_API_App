using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using System.Net;
using Newtonsoft.Json;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetApiData_Click(object sender, EventArgs e)
    {
        using (var client = new WebClient()) //WebClient  
        {

            // if textbox id is null then it will consume first url if not it will consume second url

            string uri = txtId.Text.Trim() == "" ? "http://localhost:59761/api/Weather" : ("http://localhost:59761/api/Weather/" + txtId.Text.Trim());
             
            client.Headers.Add("Content-Type:application/json"); //Content-Type  
            client.Headers.Add("Accept:application/json");
            var result = client.DownloadString(uri);//URI  
            var data = JsonConvert.DeserializeObject<List<Weather>>(result); // Deserialize json Object

            grid.DataSource = data;
            grid.DataBind();
        }
        
    }
}