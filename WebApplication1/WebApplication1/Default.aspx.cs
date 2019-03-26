using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Btn1.Text = "Proszę kliknij mnie";
            }
            else
            {
                Btn1.Text = TbName.Text;
                }
            
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            Btn1.Text = TbName.Text;
        }
    }
}