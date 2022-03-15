using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Triathlete.Models;
using System.IO; //memory stream pour picturebox

namespace Triathlete
{
    public partial class Triathlete : Form
    {
        public Triathlete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    pictureBox1.Image = new Bitmap(open.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Format de fichier inconnu", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
        }

        private void Triathlete_Load(object sender, EventArgs e)
        {
            bdpmassol6Context cnx = new bdpmassol6Context();

            var items1 = cnx.Clubs.OrderBy(cl => cl.ClubNom).ToList();
            items1.Insert(0, new Club() { ClubId = 0, ClubNom = "- Choisir un club -" });
            comboClub.DataSource = items1;
            comboClub.DisplayMember = "ClubNom";
            comboClub.ValueMember = "ClubId";
            comboClub.SelectedIndex = 0;

            var items2 = cnx.Categories.OrderBy(ca => ca.CatLibelle).ToList();
            items2.Insert(0, new Categorie() { CatId = 0, CatLibelle = "- Choisir une catégorie -" });
            comboCateg.DataSource = items2;
            comboCateg.DisplayMember = "CatLibelle";
            comboCateg.ValueMember = "CatId";
            comboCateg.SelectedIndex = 0;

            var items3 = cnx.Licences
                .Select(l => new { LicId = l.LicId, NomPrenom = string.Format("{0} {1}", l.LicNom, l.LicPrenom)})       
                .ToList();

            items3.Insert(0, new { LicId = 0, NomPrenom = "- Choisir un licencié -" });
            comboBox1.DataSource = items3;
            comboBox1.DisplayMember = "NomPrenom";
            comboBox1.ValueMember = "LicId";
            comboBox1.SelectedIndex = 0;
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Le formulaire contient des erreurs", "Erreur de Validation!");
                return;
            }

            bdpmassol6Context cnx = new bdpmassol6Context();
            dynamic lic;

            if (comboClub.SelectedIndex != 0)
            {
                //licencié en club
                lic = new LicenceClub();
                lic.ClubIdAdherer = (int)comboClub.SelectedValue;
                if (checkBoxEntraine.Checked) lic.ClubIdEntrainer = lic.ClubIdAdherer;
                //todo : lic.LicDatePremiereLice
            }
            else
            {
                //licencié pas en club
                lic = new Licence();
            }

            lic.LicNom = txtNom.Text;
            lic.LicPrenom = txtPren.Text;
            lic.LicEmail = txtMail.Text;
            lic.LicRue = txtAdresse.Text;
            if (radioButtF.Checked) lic.LicSexe = "F";
            if (radioButtM.Checked) lic.LicSexe = "H";
            lic.LicDateNaissance = dateTimePicker1.Value;
            lic.CatId = (int)comboCateg.SelectedValue;

            ImageConverter converter = new ImageConverter();
            byte[] arr = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
            if (arr.Length > 0)
                lic.LicPhoto = arr;

            if (lic is Licence)
            {
                cnx.Licences.Add(lic);
            }
            else
            {
                cnx.LicenceClubs.Add(lic);
            }
            cnx.SaveChanges();
        }

        private void comboCateg_Validating(object sender, CancelEventArgs e)
        {
            if (comboCateg.SelectedIndex < 1)
            {
                e.Cancel = true;
                comboCateg.Focus();
                errorProvider1.SetError(comboCateg, "Catégorie obligatoire !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboCateg, "");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                bdpmassol6Context cnx = new bdpmassol6Context();

                Licence monLicencie =cnx.Licences.Find(comboBox1.SelectedValue);
                txtLic.Text = monLicencie.LicId.ToString();
                txtNom.Text = monLicencie.LicNom;
                txtPren.Text = monLicencie.LicPrenom;
                txtMail.Text = monLicencie.LicEmail;
                txtAdresse.Text = monLicencie.LicRue;
                comboCateg.SelectedValue = monLicencie.CatId;

                if (monLicencie.LicSexe == "H") radioButtM.Checked = true;
                if (monLicencie.LicSexe == "F") radioButtF.Checked = true;
                dateTimePicker1.Value = (System.DateTime)monLicencie.LicDateNaissance;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                
                MemoryStream ms = new MemoryStream(monLicencie.LicPhoto);
                pictureBox1.Image = Image.FromStream(ms);

                //verification si licencie en club
                var licclub = cnx.LicenceClubs.Find(monLicencie.LicId);
                if (licclub is not null)
                {
                    comboClub.SelectedValue = licclub.ClubIdAdherer;
                    dtPremLic.Value = (System.DateTime)licclub.LicDatePremiereLice;
                    if (licclub.ClubIdEntrainer is not null) checkBoxEntraine.Checked = true;
                }
                else
                {
                    comboClub.SelectedValue = 0;
                    dtPremLic.ResetText();
                    checkBoxEntraine.Checked = false;
                }
            }
        }

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            if (txtNom.Text == "")
            {
                e.Cancel = true;
                txtNom.Focus();
                errorProvider1.SetError(txtNom, "Nom obligatoire !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNom, "");
            }
        }
    }
}
