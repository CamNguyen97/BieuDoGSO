using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace SoSanhGia.Core
{
    class excels
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public excels(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
            {
                var value = ws.Cells[i, j].Value2;
                double price;
                bool isDouble = double.TryParse(value.ToString(), out price);
                if (isDouble)
                {
                    return price.ToString();
                }
                else
                    return ws.Cells[i, j].Value2;
            }
            else
                return "";
        }
    }
}
