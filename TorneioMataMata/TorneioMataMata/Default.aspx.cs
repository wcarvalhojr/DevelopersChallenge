using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TorneioMataMata
{
    public partial class _Default : Page
    {
        #region Properties
        #endregion

        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                ViewState["fases"] = 1;                
                createList();
            }
        }

        protected void btnAvancar_Click(object sender, EventArgs e)
        {
            ViewState["fases"] =  Convert.ToInt32(ViewState["fases"]) + 1;

            if (Convert.ToInt32(ViewState["fases"]) == 2)
            {                
                lblTitulo.Text = "QUARTAS DE FINAL - CONFRONTOS";
            }
            else if (Convert.ToInt32(ViewState["fases"]) == 3)
            {
                lblTitulo.Text = "SEMIFINAL - CONFRONTOS";

            }
            else if (Convert.ToInt32(ViewState["fases"]) == 4)
            {
                lblTitulo.Text = "FINAL - CONFRONTO";

            }

            lblMensagem.Text = "";
            int count = 0;

            List<Time> lstTime = new List<Time>();
            Time time = new Time();

            //I check the list to know the next clashes
            foreach (RepeaterItem item in rpt.Items)
            {
                RadioButton rbtA = (RadioButton)item.FindControl("rbtA");
                RadioButton rbtB = (RadioButton)item.FindControl("rbtB");

                Label lblTimeA = (Label)item.FindControl("lblTimeA");
                Label lblTimeB = (Label)item.FindControl("lblTimeB");

                count += 1;

                if (rbtA.Checked || rbtB.Checked)
                {
                    if (rbtA.Checked)
                    {
                        if (count == 1) // Get the first result of the confrontation
                        {
                            time.grupoA = lblTimeA.Text;
                        }
                        else if (count == 2) // Get the second result of the confrontation
                        {
                            time.grupoB = lblTimeA.Text;
                            count = 0;
                            lstTime.Add(time);
                            time = new Time();
                        }
                    }
                    else
                    {
                        if (count == 1) // Get the first result of the confrontation
                        {
                            time.grupoA = lblTimeB.Text;
                        }
                        else if (count == 2) // Get the second result of the confrontation
                        {
                            time.grupoB = lblTimeB.Text;
                            count = 0;
                            lstTime.Add(time);
                            time = new Time();
                        }
                    }
                }
                else
                {
                    lblMensagem.Text = "Simule todos os resultados";
                    lstTime = new List<Time>();
                    break;
                }
            }

            if (lstTime.Count > 0)
            {
                rpt.DataSource = lstTime;
                rpt.DataBind();
            }
        }
        #endregion

        #region Method
        private void createList()
        {
            lblTitulo.Text = "OITAVAS DE FINAL - CONFRONTOS";

            List<Time> lstTime = new List<Time>();

            Time time = new Time();

            time.grupoA = "Flamengo";
            time.checkA = false;
            time.grupoB = "Vasco";
            time.checkB = false;

            lstTime.Add(time);

            time = new Time();

            time.grupoA = "Botafogo";
            time.checkA = false;
            time.grupoB = "Fluminense";
            time.checkB = false;

            lstTime.Add(time);

            time = new Time();

            time.grupoA = "Cruzeiro";
            time.checkA = false;
            time.grupoB = "Grêmio";
            time.checkB = false;

            lstTime.Add(time);

            time = new Time();

            time.grupoA = "Bangu";
            time.checkA = false;
            time.grupoB = "Madureira";
            time.checkB = false;

            lstTime.Add(time);

            time = new Time();

            time.grupoA = "América";
            time.checkA = false;
            time.grupoB = "Volta Redonda";
            time.checkB = false;

            lstTime.Add(time);

            time = new Time();

            time.grupoA = "São Paulo";
            time.checkA = false;
            time.grupoB = "Palmeiras";
            time.checkB = false;

            lstTime.Add(time);

            time = new Time();

            time.grupoA = "Santos";
            time.checkA = false;
            time.grupoB = "Corinthians";
            time.checkB = false;

            lstTime.Add(time);

            time = new Time();

            time.grupoA = "Ponte Preta";
            time.checkA = false;
            time.grupoB = "Paulista";
            time.checkB = false;

            lstTime.Add(time);

            rpt.DataSource = lstTime;
            rpt.DataBind();
        }
        #endregion
    }
}