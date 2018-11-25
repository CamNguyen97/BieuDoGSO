namespace SoSanhGia.UC
{
	partial class XuatKhau
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(101, 32);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(533, 21);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// chartControl1
			// 
			this.chartControl1.DataBindings = null;
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
			this.chartControl1.Diagram = xyDiagram2;
			this.chartControl1.Legend.Name = "Lượng";
			this.chartControl1.Location = new System.Drawing.Point(20, 77);
			this.chartControl1.Name = "chartControl1";
			series3.Name = "Luong";
			series4.Name = "TriGia";
			series4.View = lineSeriesView2;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
			this.chartControl1.Size = new System.Drawing.Size(614, 420);
			this.chartControl1.TabIndex = 7;
			this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(20, 30);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(75, 23);
			this.simpleButton1.TabIndex = 6;
			this.simpleButton1.Text = "Thêm file";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(265, 520);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "Biểu đồ xuất khẩu";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// XuatKhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.chartControl1);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.label1);
			this.Name = "XuatKhau";
			this.Size = new System.Drawing.Size(665, 567);
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private DevExpress.XtraCharts.ChartControl chartControl1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private System.Windows.Forms.Label label1;
	}
}
