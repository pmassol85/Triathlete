using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triathlete.Models;

namespace Triathlete
{
    public partial class ControlesDopage : Form
    {
        public ControlesDopage()
        {
            InitializeComponent();
        }

        private void ControlesDopage_Load(object sender, EventArgs e)
        {
            bdpmassol6Context cnx = new bdpmassol6Context();

            var items1 = cnx.Triathlons.OrderBy(t => t.TriNom).ToList();
            items1.Insert(0, new Triathlon() { TriId = 0, TriNom = "- Choisir un triathlon -" });
            cbTriathlon.DataSource = items1;
            cbTriathlon.DisplayMember = "TriNom";
            cbTriathlon.ValueMember = "TriId";
            cbTriathlon.SelectedIndex = 0;

            cbInscrip.Enabled = false;

            //contenu de la datagrid
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.Width = 200;
            dgvCmb.HeaderText = "Produit dopant";
            dgvCmb.DataSource = cnx.ProduitDopants.OrderBy(p=> p.DopLibelle).ToList();
            dgvCmb.DisplayMember = "DopLibelle";
            dgvCmb.ValueMember = "DopId";
            dataGridView1.Columns.Add(dgvCmb);

            DataGridViewTextBoxColumn dgtext = new DataGridViewTextBoxColumn();
            dgtext.HeaderText = "Valeur constatée";
            dgtext.Width = 150;
            dataGridView1.Columns.Add(dgtext);

            dataGridView1.Enabled = false;
        }

        private void cbTriathlon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTriathlon.SelectedIndex != 0)
            {
                bdpmassol6Context cnx = new bdpmassol6Context();

                //lister les licences via inscription
                int idTriath = (int)cbTriathlon.SelectedValue;
                var items = cnx.Inscriptions.Where(i => i.TriId == idTriath)
                    .Join(cnx.Licences,
                    ins => ins.LicId,
                    lic => lic.LicId,
                    (ins, lic) => new { InscDossard = ins.InscDossard, LicFull = lic.FullName })
                    .ToList() //car fullname non mappe en BD
                    .OrderBy(l => l.LicFull)
                    .ToList();

                items.Insert(0, new { InscDossard = 0, LicFull = "- Choisir un licencié -" });
                cbInscrip.DataSource = items;
                cbInscrip.DisplayMember = "LicFull";
                cbInscrip.ValueMember = "InscDossard";
                cbInscrip.SelectedIndex = 0;
                cbInscrip.Enabled = true;
                dataGridView1.Enabled = true;
            }
        }

        private void bValidate_Click(object sender, EventArgs e)
        {
            bdpmassol6Context cnx = new bdpmassol6Context();

            int iddop;
            decimal valeur_constatee;
            int compteur = 0;

            //on vérifie si un triathlon et un licencié sont sélectionnés
            if((int)cbTriathlon.SelectedValue == 0 || (int)cbInscrip.SelectedValue== 0)
            {
                MessageBox.Show("Données incomplètes","Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //on vérifie si une valeur constatée a été saisie
                if (row.Cells[0].Value is not null && row.Cells[1].Value is not null)
                {
                    iddop = (int)row.Cells[0].Value;
                    valeur_constatee = decimal.Parse(row.Cells[1].Value.ToString(), CultureInfo.InvariantCulture);
                    cnx.Controlers.Add(new Controler
                    {
                        DopId = iddop,
                        ControleRésultat = valeur_constatee,
                        TriId = (int)cbTriathlon.SelectedValue,
                        InscDossard = (int)cbInscrip.SelectedValue
                    });
                    compteur++;
                }
            }
            if(compteur>0)
                cnx.SaveChanges();
            else
                MessageBox.Show("Données incomplètes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
