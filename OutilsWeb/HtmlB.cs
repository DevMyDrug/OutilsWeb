using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;

namespace OutilsWeb
{
    public class HtmlB
    {
        string id;
        string classe;
        string style;
        HtmlGenericControl balise;

        public void SId(string id)
        {
            balise.ID = id;
        }
        public void SClass(string classe)
        {
            balise.Attributes["class"] = classe;
        }
        public void SStyle(string style)
        {
            List<string> lStyle = style.Split(';').ToList();
            foreach(string st in lStyle)
            {
                string[] temp = st.Split(',');
                balise.Style.Add(temp[0], temp[1]);
            }
        }

        public HtmlB(string balise)
        {
            this.balise = new HtmlGenericControl(balise);
        }

        public void AddChilds(HtmlB child)
        {
            balise.Controls.Add(child.GetHtml());
        }

        public HtmlGenericControl GetHtml()
        {
            return balise;
        }

    }
}
