using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _12.cviceni
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			ServiceReference1.Service1Client sluzba = new ServiceReference1.Service1Client();

			if (Operand2.Text == "0" && Operace.SelectedValue == "/")
			{
				Vysledek.Text = "Nelze delit nulou!";
				Response.Redirect("https://i.imgflip.com/2oixw7.jpg");

			}
			if (Operand1.Text != "" && Operand2.Text != "")
			{
				Vysledek.Text = Convert.ToString(sluzba.Spocti(Convert.ToDecimal(Operand1.Text), Convert.ToDecimal(Operand2.Text), Operace.SelectedValue));
			}

			else
			{
				Vysledek.Text = "Chyba na straně programátora :] ";
			}



		}
	}
}