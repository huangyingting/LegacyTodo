using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TodoWeb.ServiceReference;

namespace TodoWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TodoServiceClient client = new TodoServiceClient();
            GridView1.DataSource = client.GetTodoItems();
            GridView1.DataBind();
        }
    }
}