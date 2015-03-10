using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaCondominioBO;
using SistemaCondominioDAO;
using SistemaCondominioNHBO;
using SistemaCondominioNHENT;
using sysCondominio;

namespace sysCondominio.views.Consulta
{
    public partial class comparacao : System.Web.UI.Page
    {
        static List<tabCliente> ListaDadosEntity = new List<tabCliente>();
        static List<tabClienteNH> ListaDadosNHibernate = new List<tabClienteNH>();
        private Time T = new Time();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    ListaDadosNHibernate.Clear();
                    ListaDadosEntity.Clear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void gdvNHibernate_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvNHibernate.PageIndex = e.NewPageIndex;
            gdvNHibernate.DataSource = ListaDadosNHibernate;
            gdvNHibernate.DataBind();
        }

        protected void gridEntity_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridEntity.PageIndex = e.NewPageIndex;
            gridEntity.DataSource = ListaDadosEntity;
            gridEntity.DataBind();
        }

        protected void ibtnEntityFramework_Click(object sender, ImageClickEventArgs e)
        {
            #region Consulta Entity Framework

            T.Iniciar();
            tabClienteBO objBO = new tabClienteBO();
            var consulta = objBO.GetAll().AsEnumerable();
            T.Parar();

            int qtdEntity = 0;
            if (consulta.Count() > 0)
            {
                foreach (var ass in consulta)
                {
                    qtdEntity++;
                    tabCliente objDADOS = new tabCliente();
                    objDADOS.id = ass.id;
                    objDADOS.nome = ass.nome;
                    objDADOS.dt_nascimento = ass.dt_nascimento;
                    ListaDadosEntity.Add(objDADOS);
                }

                gridEntity.DataSource = ListaDadosEntity;
                gridEntity.DataBind();

                lblEntity.Text = "Foram consultados : " + qtdEntity.ToString() + " registros com o tempo De Execução : " + T.Min()
                + " Minutos " + T.Segundos() + " Segundos  " + T.Mili() + " Milisegundos. ";
            }
            #endregion
        }

        protected void ibtnNHibernate_Click(object sender, ImageClickEventArgs e)
        {
            #region Consulta NHibernate

            T.Iniciar();
            tabClienteNHBO objNH = new tabClienteNHBO();
            var consulta = objNH.GetAll().AsEnumerable();
            T.Parar();

            int qtdNHibernate = 0;
            if (consulta.Count() > 0)
            {
                foreach (var ass in consulta)
                {
                    qtdNHibernate++;
                    tabClienteNH objDADOS = new tabClienteNH();
                    objDADOS.id = ass.id;
                    objDADOS.nome = ass.nome;
                    objDADOS.dt_nascimento = ass.dt_nascimento;
                    ListaDadosNHibernate.Add(objDADOS);
                }
                gdvNHibernate.DataSource = ListaDadosNHibernate;
                gdvNHibernate.DataBind();

                lblNHibernate.Text = "Foram consultados : " + qtdNHibernate.ToString() + " registros com o tempo De Execução : " + T.Min()
                + " Minutos " + T.Segundos() + " Segundos  " + T.Mili() + " Milisegundos. ";
            }
            #endregion
        }
    }
}