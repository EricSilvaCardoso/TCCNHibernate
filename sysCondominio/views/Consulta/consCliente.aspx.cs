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

namespace sysCondominio.views.Consulta
{
    public partial class consCliente : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

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
                    List<tabCliente> ListaClienteEntity = new List<tabCliente>();
                    foreach (var CE in consulta)
                    {
                        tabCliente objClienteEntity = new tabCliente();
                        objClienteEntity.nome = CE.nome;
                        objClienteEntity.id = CE.id;
                        ListaClienteEntity.Add(objClienteEntity);
                    }

                    btnConsultarEntity.Visible = false;
                    btnConsultarNHibernate.Visible = false;
                    txtNomeConsulta.Visible = false;
                    lblnome.Visible = false;


                    lblSelec.Visible = true;
                    ddlNomes.Visible = true;
                    btnSelecionarEntity.Visible = true;

                    ddlNomes.DataSource = ListaClienteEntity;
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
                        txtDtNasc.Text = aw.dt_nascimento.ToString();
                        txtCPF.Text = aw.cpf;
                        txtEmail.Text = aw.email;
                        txtEscolaridade.Text = aw.escolaridade;
                        txtObservação.Text = aw.obs;
                        txtSexo.Text = aw.sexo;
                        txtSitOcup.Text = aw.sitOcupacional;
                        hdID.Value = aw.id.ToString();

                    }

                    pnConsCliente.Visible = false;
                    pnCAD.Visible = true;


                }

                tabCondominioBO objBOCon = new tabCondominioBO();
                int idsS = int.Parse(hdID.Value);
                var consultaCond = objBOCon.Find(c => c.id_cliente == idsS).ToList();
                if (consultaCond.Count > 0)
                {
                    pnaNao.Visible = false;
                    pnSim.Visible = true;
                    int idala = 0;

                    foreach (var isa in consultaCond)
                    {
                        idala = int.Parse(isa.id_AlaQ.ToString());

                    }

                    tabAlaQuartoBO objAlqBO = new tabAlaQuartoBO();
                    var consultaQ = objAlqBO.Find(c => c.id_ala == idala).ToList();
                    foreach (var alasQ in consultaQ)
                    {
                        lblQuartoConsultado.Text = alasQ.Nquarto;
                        lblAlaConsultado.Text = alasQ.tabAla.numeroAla.ToString();
                    }


                }
                else
                {
                    pnaNao.Visible = true;
                    pnSim.Visible = false;
                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btnConsultarNHibernate_Click(object sender, EventArgs e)
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
                    btnConsultarNHibernate.Visible = false;
                    txtNomeConsulta.Visible = false;
                    lblnome.Visible = false;


                    lblSelec.Visible = true;
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
                        txtDtNasc.Text = aw.dt_nascimento.ToString();
                        txtCPF.Text = aw.cpf;
                        txtEmail.Text = aw.email;
                        txtEscolaridade.Text = aw.escolaridade;
                        txtObservação.Text = aw.obs;
                        txtSexo.Text = aw.sexo;
                        txtSitOcup.Text = aw.sitOcupacional;
                        hdID.Value = aw.id.ToString();

                        pnConsCliente.Visible = false;
                        pnCAD.Visible = true;
                    }
                }
            }       
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnAlterarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                tabCliente OBJcliente = new tabCliente();
               
                OBJcliente.id = int.Parse(hdID.Value);
                OBJcliente.nome = txtNome.Text;
                OBJcliente.cpf = txtCPF.Text;
                OBJcliente.dt_cadastro = Convert.ToDateTime(DateTime.Now);
                OBJcliente.dt_nascimento = Convert.ToDateTime(txtDtNasc.Text);
                OBJcliente.email = txtEmail.Text;
                OBJcliente.escolaridade = txtEscolaridade.Text;
                OBJcliente.obs = txtObservação.Text;
                OBJcliente.sexo = txtSexo.Text;
                OBJcliente.sitOcupacional = txtSitOcup.Text;
                OBJcliente.user_cadastro = "";

                tabClienteBO objBO = new tabClienteBO();
                objBO.AlteraDados(OBJcliente);
                objBO.SaveChanges();

                string Message = "Cliente Alterado com Sucesso!! ";
                ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                    string.Format("alert('{0}');", Message), true);
                int id = OBJcliente.id;
                hdID.Value = id.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnAdicionarTEL_Click(object sender, EventArgs e)
        {
            try
            {
                tabTelefone obtTEL = new tabTelefone();
                obtTEL.id_cliente = int.Parse(hdID.Value);
                obtTEL.telefone = txtTelEntity.Text;

                tabTelefoneBO objBO = new tabTelefoneBO();
                objBO.Add(obtTEL);
                objBO.SaveChanges();

                GridView1.DataBind();
                txtTelEntity.Text = "";
                pnADDtelEntity.Visible = false;

            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnAlteraTelefones_Click(object sender, EventArgs e)
        {
            pnADDtelEntity.Visible = true;
        }

        protected void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                tabCliente OBJcliente = new tabCliente();
                OBJcliente.id = int.Parse(hdID.Value);
                OBJcliente.nome = txtNome.Text;
                OBJcliente.cpf = txtCPF.Text;
                OBJcliente.dt_cadastro = Convert.ToDateTime(DateTime.Now);
                OBJcliente.dt_nascimento = Convert.ToDateTime(txtDtNasc.Text);
                OBJcliente.email = txtEmail.Text;
                OBJcliente.escolaridade = txtEscolaridade.Text;
                OBJcliente.obs = txtObservação.Text;
                OBJcliente.sexo = txtSexo.Text;
                OBJcliente.sitOcupacional = txtSitOcup.Text;
                OBJcliente.user_cadastro = "";

                tabClienteBO objBO = new tabClienteBO();
                objBO.Delete(OBJcliente);
                objBO.SaveChanges();

                string Message = "Cliente Deletado com Sucesso!! ";
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