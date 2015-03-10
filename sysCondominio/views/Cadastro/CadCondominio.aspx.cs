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
    public partial class CadCondominio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlAlasEntity.DataBind();
                ddlQuartosEntity.DataBind();
                ddlAlasNHibernate.DataBind();
                ddlQuartosNHibernate.DataBind();
            }
        }

        protected void btnConsultarEntity_Click(object sender, EventArgs e)
        {
            try
            {
                tabClienteBO objBO = new tabClienteBO();
                string nome = txtNomeConsulta.Text;
                var consulta = objBO.Find(c => c.nome.Contains(nome)).ToList();

                if (consulta.Count > 0)
                {
                    List<tabCliente> ListaCliente = new List<tabCliente>();
                    foreach (var aw in consulta)
                    {
                        tabCliente objCli = new tabCliente();
                        objCli.nome = aw.nome;
                        objCli.id = aw.id;
                        ListaCliente.Add(objCli);
                    }

                    btnConsultarEntity.Visible = false;
                    btnConsultaNHibernate.Visible = false;
                    txtNomeConsulta.Visible = false;
                    lblnome.Visible = false;

                    lblSelect.Visible = true;
                    ddlNomes.Visible = true;
                    btnSelecionarEntity.Visible = true;

                    ddlNomes.DataSource = ListaCliente;
                    ddlNomes.DataTextField = "nome";
                    ddlNomes.DataValueField = "id";
                    ddlNomes.DataBind();
                }
                else
                {
                    string Message = "Cliente não Encontrado!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnSelecionarEntity_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = int.Parse(ddlNomes.SelectedValue);
                tabClienteBO objBO = new tabClienteBO();
                var consulta = objBO.Find(c => c.id == ids).ToList();
                if (consulta.Count > 0)
                {
                    foreach (var aw in consulta)
                    {
                        txtNome.Text = aw.nome;
                        mtxtDtNasc.Text = aw.dt_nascimento.ToString();
                        txtCPF.Text = aw.cpf;
                    }

                    pnConsCliente.Visible = false;
                    pnCondominio.Visible = true;

                    ddlAlasEntity.Visible = true;
                    ddlQuartosEntity.Visible = true;
                    btnCadCondEntity.Visible = true;

                    ddlAlasEntity.DataBind();
                    ddlQuartosEntity.DataBind();

                    ddlAlasEntity_SelectedIndexChanged(null, null);
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnConsultaNHibernate_Click(object sender, EventArgs e)
        {
            try
            {
                tabClienteNHBO objNH = new tabClienteNHBO();
                string nome = txtNomeConsulta.Text;
                var Consulta = objNH.Find(c => c.nome.Contains(nome)).ToList();

                if (Consulta.Count() > 0)
                {
                    List<tabClienteNH> ListaClientesNHibernate = new List<tabClienteNH>();
                    foreach (var CNH in Consulta)
                    {
                        tabClienteNH objClienteNHibernate = new tabClienteNH();
                        objClienteNHibernate.id = CNH.id;
                        objClienteNHibernate.nome = CNH.nome;
                        ListaClientesNHibernate.Add(objClienteNHibernate);
                    }

                    btnConsultarEntity.Visible = false;
                    btnConsultaNHibernate.Visible = false;
                    txtNomeConsulta.Visible = false;
                    lblnome.Visible = false;


                    lblSelect.Visible = true;
                    ddlNomes.Visible = true;
                    btnSelecionarNHibernate.Visible = true;

                    ddlNomes.DataSource = ListaClientesNHibernate;
                    ddlNomes.DataTextField = "nome";
                    ddlNomes.DataValueField = "id";
                    ddlNomes.DataBind();

                }
                else
                {
                    string Message = "Cliente não Encontrado!! ";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                        string.Format("alert('{0}');", Message), true);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnSelecionarNHibernate_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = int.Parse(ddlNomes.SelectedValue);
                tabClienteNHBO objNH = new tabClienteNHBO();
                var consulta = objNH.Find(c => c.id == ids).ToList();
                if (consulta.Count > 0)
                {
                    foreach (var aw in consulta)
                    {
                        txtNome.Text = aw.nome;
                        mtxtDtNasc.Text = aw.dt_nascimento.ToString();
                        txtCPF.Text = aw.cpf;
                    }
                    pnConsCliente.Visible = false;
                    pnCondominio.Visible = true;

                    ddlAlasNHibernate.Visible = true;
                    ddlQuartosNHibernate.Visible = true;
                    btnCadCondNHibernate.Visible = true;

                    ddlAlasNHibernate.DataBind();
                    ddlQuartosNHibernate.DataBind();

                    ddlAlasNHibernate_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlAlasEntity_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int idALA = int.Parse(ddlAlasEntity.SelectedValue);
                tabAlaQuartoBO objBO = new tabAlaQuartoBO();
                var consulta = objBO.Find(c => c.id_ala == idALA).ToList();
                if (consulta.Count > 0)
                {
                    List<tabAlaQuarto> listaAlaQ = new List<tabAlaQuarto>();
                    foreach (var to in consulta)
                    {
                        tabAlaQuarto objala = new tabAlaQuarto();
                        objala.id = to.id;
                        objala.Nquarto = to.Nquarto;
                        listaAlaQ.Add(objala);
                    }
                    ddlQuartosEntity.DataSource = listaAlaQ;
                    ddlQuartosEntity.DataValueField = "id";
                    ddlQuartosEntity.DataTextField = "Nquarto";
                    ddlQuartosEntity.DataBind();
                }
                else
                {
                    ddlQuartosEntity.ClearSelection();
                }
            }
            catch (Exception)
            {
                throw;
            }
            ddlQuartosEntity.ClearSelection();
        }

        protected void ddlAlasNHibernate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idALA = int.Parse(ddlAlasNHibernate.SelectedValue);
                TabAlaQuartoNHBO objNH = new TabAlaQuartoNHBO();
                var consulta = objNH.Find(c => c.id_ala == idALA).ToList();
                if (consulta.Count > 0)
                {
                    List<tabAlaQuartoNH> listaAlaQ = new List<tabAlaQuartoNH>();
                    foreach (var to in consulta)
                    {
                        tabAlaQuartoNH objAlaNHibernate = new tabAlaQuartoNH();
                        objAlaNHibernate.id = to.id;
                        objAlaNHibernate.Nquarto = to.Nquarto;
                        listaAlaQ.Add(objAlaNHibernate);
                    }
                    ddlQuartosNHibernate.DataSource = listaAlaQ;
                    ddlQuartosNHibernate.DataValueField = "id";
                    ddlQuartosNHibernate.DataTextField = "Nquarto";
                    ddlQuartosNHibernate.DataBind();
                }
                else
                {
                    ddlQuartosNHibernate.ClearSelection();
                }

            }
            catch (Exception)
            {
                throw;
            }
            ddlQuartosNHibernate.ClearSelection();
        }

        protected void btnCadCondEntity_Click1(object sender, EventArgs e)
        {
            try
            {
                tabCondominio objCondominio = new tabCondominio();
                objCondominio.id_AlaQ = int.Parse(ddlQuartosEntity.SelectedValue);
                objCondominio.id_cliente = int.Parse(ddlNomes.SelectedValue);
                objCondominio.dataEntrada = Convert.ToDateTime(txtDataEntrada.Text);
                objCondominio.tempo = txtTempo.Text;
                objCondominio.user_cadastro = "";
                objCondominio.dt_cadastro = DateTime.Now;
                
                tabCondominioBO objbo = new tabCondominioBO();
                objbo.Add(objCondominio);
                objbo.SaveChanges();

                string Message = "Cliente cadastrado ao Condominio com Sucesso!! ";
                ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                    string.Format("alert('{0}');", Message), true);

                string redirectURL = "../../Default.aspx";

                string script = "window.location = '" + redirectURL + "';";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "RedirectTo", script, true);


            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btnCadCondNHibernate_Click(object sender, EventArgs e)
        {
            try
            {
                tabCondominioNH model = new tabCondominioNH();
                model.id_AlaQ = int.Parse(ddlQuartosNHibernate.SelectedValue);
                model.id_Cliente = int.Parse(ddlNomes.SelectedValue);
                model.dataEntrada = Convert.ToDateTime(txtDataEntrada.Text);
                model.tempo = txtTempo.Text;
                model.user_cadastro = "";
                model.dt_Cadastro = DateTime.Now;

                tabCondominioNHBO dao = new tabCondominioNHBO();
                dao.Inserir(model);

                string Message = "Cliente cadastrado ao Condominio com Sucesso!! ";
                ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                string.Format("alert('{0}');", Message), true);

                string redirectURL = "../../Default.aspx";

                string script = "window.location = '" + redirectURL + "';";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "RedirectTo", script, true);
             }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}