using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaCondominioBO;
using SistemaCondominioDAO;
using SistemaCondominioNHBO;
using SistemaCondominioNHENT;


namespace sysCondominio.views.Cadastro
{
    public partial class CadAla_Quartos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }  

        protected void btnCadAlaNHibernate_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria objeto NHENT da ALA
                tabAlaNH model = new tabAlaNH();
                model.numeroAla = int.Parse(txtALA.Text);

                //Cria objeto de negocios da ALA
                tabAlaNHBO dao = new tabAlaNHBO();
                dao.Inserir(model);

                int id = 0;
                id = model.id;

                if (id != 0)
                {
                    string Message = "Ala Cadastrada com Sucesso!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                    string redirectURL = "../../Default.aspx";

                    string script = "window.location = '" + redirectURL + "';";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "RedirectTo", script, true);
                }
                else
                {
                    string Message = "Erro ao Cadastrar!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnCadAlaEntity_Click(object sender, EventArgs e)
        {
            try
            {
                //cria objeto da tabela
                tabAla objALA = new tabAla();
                objALA.numeroAla = int.Parse(txtALA.Text);

                //cria objeto de negocios da ALA
                tabAlaBO objBO = new tabAlaBO();
                objBO.Add(objALA);
                objBO.SaveChanges();

                int id = 0;
                id = objALA.id;


                if (id != 0)
                {
                    string Message = "Ala Cadastrada com Sucesso!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                    string redirectURL = "../../Default.aspx";

                    string script = "window.location = '" + redirectURL + "';";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "RedirectTo", script, true);
                }
                else
                {
                    string Message = "Erro ao Cadastrar Ala!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnCadQuartoNHibernate_Click(object sender, EventArgs e)
        {
            try
            {
                tabAlaQuartoNH model = new tabAlaQuartoNH();
                model.id_ala = int.Parse(DropDownList1.SelectedValue);
                model.Nquarto = txtNumeroQuarto.Text;
                TabAlaQuartoNHBO dao = new TabAlaQuartoNHBO();
                dao.Inserir(model);

                int id = 0;
                id = model.id;

                if (id != 0)
                {
                    string Message = "Quarto Cadastrado com Sucesso!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                    string redirectURL = "../../Default.aspx";

                    string script = "window.location = '" + redirectURL + "';";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "RedirectTo", script, true);
                }
                else
                {
                    string Message = "Erro ao Cadastrar!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnCadQuarto_Entity_Click(object sender, EventArgs e)
        {
            try
            {
                //cria objeto da tabela
                tabAlaQuarto objALAQ = new tabAlaQuarto();
                objALAQ.id_ala = int.Parse(DropDownList1.SelectedValue);
                objALAQ.Nquarto = txtNumeroQuarto.Text;

                //cria objeto de negocios da ALA
                tabAlaQuartoBO objBO = new tabAlaQuartoBO();
                objBO.Add(objALAQ);
                objBO.SaveChanges();

                int id = 0;
                id = objALAQ.id;


                if (id != 0)
                {
                    string Message = "Quarto Cadastrado com Sucesso!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                    string redirectURL = "../../Default.aspx";

                    string script = "window.location = '" + redirectURL + "';";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "RedirectTo", script, true);
                }
                else
                {
                    string Message = "Erro ao Cadastrar!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void rblTipoCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rblTipoCad.SelectedValue == "1")
                {
                    pnQuartos.Visible = false;
                    pnAlas.Visible = true;
                }
                else
                {
                    pnQuartos.Visible = true;
                    pnAlas.Visible = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }   
    }
}