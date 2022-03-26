using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MuzikKursuKayitSitesi
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblStudentsTableAdapter tblStudentsTableAdapter = new DataSet1TableAdapters.TblStudentsTableAdapter();
            tblStudentsTableAdapter.OgrenciEkle(TxtAd.Text, TxtSoyad.Text, TxtTelefonNo.Text, TxtMail.Text, DropDownList1.SelectedItem.ToString(), DropDownList2.SelectedValue.ToString());
        }
    }
}