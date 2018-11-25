using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SoSanhGia.Core;

namespace SoSanhGia
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void timerSystemTime_Tick(object sender, EventArgs e)
        {
            lblSystemTime.Caption = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
        }

        private void nhapKhau1_Load(object sender, EventArgs e)
        {
            
        }
    }
}