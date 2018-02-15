using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Store;
namespace SMIS.Pages
{
    public partial class Country : System.Web.UI.Page
    {
        Store.BusinessLogic.Country oblCountry = null;
        Store.BusinessObject.CountryList objCountrylist = null;
        Store.BusinessObject.Country objCountry = null;
        Store.Common.MessageInfo objMessageInfo = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountry();
            }
        }
        void BindCountry()
        {
            oblCountry = new Store.BusinessLogic.Country();
            try
            {
                objCountrylist = oblCountry.GetAllCountryList(0, 0, "");
                if (objCountrylist != null)
                {
                    dgvCountry.DataSource = objCountrylist;
                    dgvCountry.DataBind();
                }
                else
                {
                    dgvCountry.DataSource = null;
                    dgvCountry.DataBind();
                }
            }
            catch (Exception ex)
            {
                Store.Common.Utility.ExceptionLog.Exceptionlogs(ex.Message, Store.Common.Utility.ExceptionLog.LineNumber(ex), typeof(Country).FullName, 1);
            }
            finally
            {
                oblCountry = null;
                objCountrylist = null;
            }
        }
        protected void dgvCountry_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (this.dgvCountry.Rows.Count > 0)
            {
                dgvCountry.UseAccessibleHeader = true;
                dgvCountry.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
        protected void imgbtn_Click(object sender, ImageClickEventArgs e)
        {
            //ImageButton btndetails = sender as ImageButton;
            //GridViewRow gvrow = (GridViewRow)btndetails.NamingContainer;
            //txtCountryId.Text = dgvCountry.DataKeys[gvrow.RowIndex].Value.ToString();
            //txtCountry.Text = gvrow.Cells[0].Text;
            //updateCountryBdInfo.Update();
            //this.ModalPopupExtender1.Show();
            //cmdMode = CommandMode.M;
        }
        protected void imgbtnfrDelete_Click(object sender, ImageClickEventArgs e)
        {
            //cmdMode = CommandMode.D;
            //objCountry = new Store.BusinessObject.Country();
            //oblCountry = new Store.BusinessLogic.Country();
            //objMessageInfo = new MessageInfo();
            //try
            //{
            //    ImageButton btndetails = sender as ImageButton;
            //    GridViewRow gvrow = (GridViewRow)btndetails.NamingContainer;
            //    objCountry.CountryID = Convert.ToInt32(dgvCountry.DataKeys[gvrow.RowIndex].Value.ToString());
            //    objCountry.CountryName = "";
            //    //objCountry.CreatedBy = Convert.ToInt32(Session["UserId"].ToString());
            //    objMessageInfo = oblCountry.ManageItemMaster(objCountry, cmdMode);
            //    BindCountry();
            //    updateCountryBdInfo.Update();
            //    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "alert", "alert('" + objMessageInfo.TranMessage + "')", true);
            //}
            //catch (Exception ex)
            //{
            //    Store.Common.Utility.ExceptionLog.Exceptionlogs(ex.Message, Store.Common.Utility.ExceptionLog.LineNumber(ex), typeof(Country).FullName, 1);
            //}
            //finally
            //{
            //    objCountry = null;
            //    oblCountry = null;
            //    objMessageInfo = null;
            //}
        }
    }
}