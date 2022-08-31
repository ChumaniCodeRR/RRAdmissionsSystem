using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admissions.UtilityScreens
{
    public partial class DegreeAdditionalInfo : Form
    {
        bool ask_law, ask_mus, ask_art, ask_bis, law, mus, art, bis;

        public DegreeAdditionalInfo()
        {
            InitializeComponent();
        }

        public DegreeAdditionalInfo(bool ask_law, bool ask_mus, bool ask_art, bool ask_bis, bool law, bool mus, bool art, bool bis)
            : this()
        {
            this.ask_law = ask_law;
            this.ask_mus = ask_mus;
            this.ask_art = ask_art;
            this.ask_bis = ask_bis;

            this.law = law;
            this.mus = mus;
            this.art = art;
            this.bis = bis;
        }

        private void DegreeAdditionalInfo_Load(object sender, EventArgs e)
        {
            ckLwaStream.Enabled = ask_law;
            ckMusicProof.Enabled = ask_mus;
            ckFineArt.Enabled = ask_art;
            ckBComIS.Enabled = ask_bis;

            if (ask_law) ckLwaStream.Checked = law;
            if (ask_mus) ckMusicProof.Checked = mus;
            if (ask_art) ckFineArt.Checked = art;
            if (ask_bis) ckBComIS.Checked = bis;
        }

        #region Properties

        bool isLaw;

        public bool IsLaw
        {
            get { return isLaw; }
            set { isLaw = value; }
        }

        bool isMus;

        public bool IsMus
        {
            get { return isMus; }
            set { isMus = value; }
        }

        bool isArt;

        public bool IsArt
        {
            get { return isArt; }
            set { isArt = value; }
        }

        bool isBIS;

        public bool IsBIS
        {
            get { return isBIS; }
            set { isBIS = value; }
        }

        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            isLaw = ckLwaStream.Checked;
            isMus = ckMusicProof.Checked;
            isArt = ckFineArt.Checked;
            isBIS = ckBComIS.Checked;
        }
    }
}
