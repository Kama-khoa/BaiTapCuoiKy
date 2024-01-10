using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using OfficeOpenXml;
using DTO;
using OfficeOpenXml.Style;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.ApplicationServices;


namespace GUI
{
    public class ExportData
    {
        private static ExportData instance = new ExportData();
        public static ExportData Instance
        {
            get { return instance; }
        }
        public void ToExcel(DataGridView dataGridView1,string title)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            dialog.ShowDialog();
            filePath = dialog.FileName;
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Properties.Title = filePath;
                    p.Workbook.Worksheets.Add("sheet1");
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];
                    ws.Cells.Style.Font.Size = 12;
                    ws.Cells.Style.Font.Name = "Calibri";
                    List<string> arrColumnHeader = new List<string>();
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        arrColumnHeader.Add(dataGridView1.Columns[i].HeaderText);
                        
                    }
                    var countColHeader = arrColumnHeader.Count();
                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là title
                    ws.Cells[1, 1].Value = title;
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    int colIndex = 1;
                    int rowIndex = 3;
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];
                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;
                        //gán giá trị
                        cell.Value = item;
                        cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        colIndex++;
                    }
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            ws.Cells[i + 4, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value;
                            var cell = ws.Cells[i+4, j+1];
                           // ws.Cells[i + 4, j + 1].AutoFitColumns();
                            var border = cell.Style.Border;
                            border.Bottom.Style =
                                border.Top.Style =
                                border.Left.Style =
                                border.Right.Style = ExcelBorderStyle.Thin;
                            
                        } 
                    }
                    ws.Cells[1, 1, dataGridView1.RowCount + 5, 4].AutoFitColumns(15);
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                    excel.Quit();
                    MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
