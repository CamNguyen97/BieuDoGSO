using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SoSanhGia.Core;
using DevExpress.XtraCharts;

namespace SoSanhGia.UC
{
	public partial class XuatKhau : DevExpress.XtraEditors.XtraUserControl
	{
		private static OpenFileDialog openFileDialog1;
		private static excels excel;
		private string selectedFileName;
		public XuatKhau()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void chartControl1_Click(object sender, EventArgs e)
		{

		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			getForm();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			chartControl1.Series["Luong"].Points.Clear();
			chartControl1.Series["TriGia"].Points.Clear();
			using (frmWait frm = new frmWait(draw))
			{
				frm.StartPosition = FormStartPosition.CenterScreen;
				frm.ShowDialog();
			}
		}

		public void getForm()
		{
			openFileDialog1 = new OpenFileDialog();
			openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 0;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				selectedFileName = openFileDialog1.FileName;
				using (frmWait frm = new frmWait(readExcel))
				{
					frm.StartPosition = FormStartPosition.CenterScreen;
					frm.ShowDialog();
				}
			}
		}
		public void readExcel()
		{
			Dictionary<string, string> arrCombo = new Dictionary<string, string>();
			excel = new excels(selectedFileName, 1);
			Console.Write("value: " + excel.ReadCell(0, 12));

			for (int i = 11; i < 65; i++)
			{
				if (excel.ReadCell(i, 0) != null && excel.ReadCell(i, 0) != "")
				{
					arrCombo.Add((i).ToString(), excel.ReadCell(i, 0));
				}
			}
			comboBox1.DataSource = new BindingSource(arrCombo, null);
			comboBox1.DisplayMember = "value";
			comboBox1.ValueMember = "key";

			foreach (KeyValuePair<string, string> author in arrCombo)
			{
				Console.WriteLine("Value: {0}", author.Value);
			}
		}

		private void draw()
		{
			string value = comboBox1.SelectedValue.ToString();
			int row;
			Boolean checkrow = int.TryParse(value, out row);
			Console.Write(row);

			int indexLuong = 0;
			for (int i = 2; i < 25; i += 2)
			{
				if (excel.ReadCell(row, i) != null && excel.ReadCell(row, i) != "")
				{
					indexLuong++;
					this.chartControl1.Series["Luong"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Tháng " + indexLuong.ToString(), excel.ReadCell(row, i)));
					Console.WriteLine("value:{0}", excel.ReadCell(row, i));
				}
			}

			int indexTriGia = 0;
			for (int i = 3; i < 25; i += 2)
			{
				if (excel.ReadCell(row, i) != null && excel.ReadCell(row, i) != "")
				{
					Console.WriteLine("value:{0}", excel.ReadCell(row, i));
					indexTriGia++;
					this.chartControl1.Series["TriGia"].Points.Add(new SeriesPoint("Tháng " + indexTriGia.ToString(), excel.ReadCell(row, i)));

				}
			}

		}
	}
}
