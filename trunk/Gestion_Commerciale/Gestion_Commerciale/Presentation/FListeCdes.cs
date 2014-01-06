using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Gestion_Commerciale.Presentation
{
    public partial class FListeCdes : Form
    {
        public FListeCdes()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            
            lvcdes.Items.Clear();
            lvcdes.View = View.Details;
            lvcdes.Columns.Add("Numéro", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Numéro Vendeur", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Numéro Client", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Date Commande", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Facture", 100, HorizontalAlignment.Left);
        }
    }
}
