using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using System.Threading.Tasks;

namespace SoSanhGia
{
    public partial class frmWait : WaitForm
    {
        public Action Worker { get; set; }
        public frmWait(Action worker)
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
            if(worker == null)
              throw new ArgumentException();
            Worker = worker;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public enum WaitFormCommand
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}