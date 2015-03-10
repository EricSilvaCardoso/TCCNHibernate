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
    public partial class CadCliente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadClienteEntity_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 6997; i++)
                {
                    tabCliente OBJcliente = new tabCliente();
                    OBJcliente.nome = "Usuario";
                    OBJcliente.cpf = "111.111.111-11";
                    OBJcliente.dt_cadastro = Convert.ToDateTime(DateTime.Now);
                    OBJcliente.dt_nascimento = Convert.ToDateTime("20/12/2012");
                    OBJcliente.email = "usuario@usuario.com.br";
                    OBJcliente.escolaridade = "Superior Completo";
                    OBJcliente.obs = "dados para teste";
                    OBJcliente.sexo = "M";
                    OBJcliente.sitOcupacional = "Estudante";
                    OBJcliente.user_cadastro = "";

                    tabClienteBO objBO = new tabClienteBO();
                    objBO.Add(OBJcliente);
                    objBO.SaveChanges();
                }


                //tabCliente OBJcliente = new tabCliente();
                //OBJcliente.nome = txtNome.Text;
                //OBJcliente.cpf = txtCPF.Text;
                //OBJcliente.dt_cadastro = Convert.ToDateTime(DateTime.Now);
                //OBJcliente.dt_nascimento = Convert.ToDateTime(txtDtNasc.Text);
                //OBJcliente.email = txtEmail.Text;
                //OBJcliente.escolaridade = ddlEscolaridade.Text;
                //OBJcliente.obs = txtObservação.Text;
                //OBJcliente.sexo = ddlSexo.SelectedValue.ToString();
                //OBJcliente.sitOcupacional = txtSitOcup.Text;
                //OBJcliente.user_cadastro = "";

                //tabClienteBO objBO = new tabClienteBO();
                //objBO.Add(OBJcliente);
                //objBO.SaveChanges();

                //int id = OBJcliente.id;
                //hdIdEF.Value = id.ToString();

                //if (id > 0)
                //{
                //    string Message = "Cliente Cadastrado com Sucesso!! ";
                //    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                //                                        string.Format("alert('{0}');", Message), true);
                //    pnTelefones.Visible = true;

                //    btnAdicionarTelEntity.Visible = true;
                //    pnCAD.Visible = false;
                //}
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnCadClienteNHibernate_Click(object sender, EventArgs e)
        {
            try
            {
                    tabClienteNH model = new tabClienteNH();
                    model.nome = txtNome.Text;
                    model.cpf = txtCPF.Text;
                    model.dt_nascimento = Convert.ToDateTime(txtDtNasc.Text);
                    model.dt_cadastro = Convert.ToDateTime(DateTime.Now);
                    model.email = txtEmail.Text;
                    model.escolaridade = ddlEscolaridade.SelectedValue.ToString();
                    model.obs = txtObservação.Text;
                    model.sexo = ddlSexo.Text;
                    model.sitOcupacional = txtSitOcup.Text;
                    model.user_cadastro = "";

                    tabClienteNHBO dao = new tabClienteNHBO();
                    dao.Inserir(model);

                    int id = model.id;
                    hdIdNH.Value = id.ToString();
 
                    if (id > 0)
                    {
                        string Message = "Cliente Cadastrado com Sucesso!! ";
                        ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                            string.Format("alert('{0}');", Message), true);
                        pnTelefones.Visible = true;
                        btnAdicionarTelNHibernate.Visible = true;
                        pnCAD.Visible = false;
                    }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnAdicionarTelEntity_Click(object sender, EventArgs e)
        {
            try
            {
                tabTelefone obtTEL = new tabTelefone();
                obtTEL.id_cliente = int.Parse(hdIdEF.Value);
                obtTEL.telefone = txtTel.Text;

                tabTelefoneBO objBO = new tabTelefoneBO();
                objBO.Add(obtTEL);
                objBO.SaveChanges();

                GridView1.DataBind();
                txtTel.Text = "";
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnAdicionarTelNHibernate_Click(object sender, EventArgs e)
        {
            try
            {
                tabTelefoneNH model = new tabTelefoneNH();
                model.id_cliente = int.Parse(hdIdNH.Value);
                model.telefone = txtTel.Text;

                tabTelefoneNHBO dao = new tabTelefoneNHBO();
                dao.Inserir(model);

                GridView2.DataBind();
                txtTel.Text = "";
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            string Message = "Cadastro de Cliente Finalizado!! ";
            ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert",
                                                string.Format("alert('{0}');", Message), true);
            string redirectURL = "../../Default.aspx";

            string script = "window.location = '" + redirectURL + "';";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "RedirectTo", script, true);
        }


    }
}