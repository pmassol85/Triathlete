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

namespace Triathlete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bdpmassol6Context cnx = new bdpmassol6Context();

            LicenceClub triath = new LicenceClub();
            //triath.LicNom = "noueav";
            //triath.LicPrenom = "ath";
            //triath.CatId = 1;
            //triath.ClubIdAdherer = 1;
            //triath.LicDatePremiereLice = new DateTime(2021, 02, 28);

            //cnx.LicenceClubs.Add(triath);
            //cnx.SaveChanges();

            triath = cnx.LicenceClubs.Find(5);
        }

    }
}
