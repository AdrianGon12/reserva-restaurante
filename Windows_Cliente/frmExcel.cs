using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Para la creacion del nuevo archivo Excel
using OfficeOpenXml; // Para el manejo de las clases de EPPlus

namespace Windows_Cliente
{
    public partial class frmExcel : Form
    {
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();
        ProxyReserva.ServicioReservasClient srvReservas = new ProxyReserva.ServicioReservasClient();
        ProxyReserva.ReservaBE objReserva = new ProxyReserva.ReservaBE();

        public frmExcel()
        {
            InitializeComponent();
        }

        private void btnListadoReservas_Click(object sender, EventArgs e)
        {
            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Hoja1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //// storing header part in Excel  
            //for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("D:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            Int16 id = Convert.ToInt16(cboRestaurante.SelectedValue);

            // Ruta del archivo plantilla del reporte.
            String rutaarchivo = @"D:\MisExcel\ListadoReservas.xlsx";

            // Definimos la fila de inicio del reporte
            Int16 fila1 = 5;
            // Creamos una instancia de ExcelPackage en base al archivo plantilla...
            using (var pck = new ExcelPackage(new FileInfo(rutaarchivo)))
            {
                // Indicamos en que hoja de la plantilla se implementara el reporte
                ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];

                foreach (DataGridViewRow drReserva in dtgReservas.Rows)
                {
                    ws.Cells[fila1, 1].Value = drReserva.Cells[0].Value.ToString();
                    ws.Cells[fila1, 2].Value = drReserva.Cells[1].Value.ToString();
                    ws.Cells[fila1, 3].Value = drReserva.Cells[2].Value.ToString();
                    ws.Cells[fila1, 4].Value = drReserva.Cells[3].Value.ToString();
                    ws.Cells[fila1, 5].Value = drReserva.Cells[4].Value.ToString();
                    fila1 += 1;
                }

                //Modificamos el ancho de las columnas
                ws.Column(1).Width = 40;
                ws.Column(2).Width = 40;
                ws.Column(3).Width = 20;
                ws.Column(4).Width = 40;
                ws.Column(5).Width = 30;

                // Creamos el nombre asociado al usuario logueado....
                String filename = "ListadoReservas_" + id + ".xlsx";
                // Creamos el nuevo archivo...
                FileStream fs = new FileStream(@"D:\MisExcel\" + filename, FileMode.Create);
                pck.SaveAs(fs);

                // Destruimos las instancias....
                pck.Dispose();
                fs.Dispose();

                // Enviamos el mensaje al usuario de conformidad de creacion del archivo Excel....
                MessageBox.Show("El archivo :" + filename + " se ha generado con exito.", "Mensaje",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmExcel_Load(object sender, EventArgs e)
        {
            CargarRestaurante(1);
            dtgReservas.AutoGenerateColumns = false;
            dtgReservas.DataSource = srvReservas.GetAllReservasRestaurante(1);
        }

        private void CargarRestaurante(Int16 idResta)
        {
            cboRestaurante.DataSource = srvRestaurantes.GetAllRestaurantesActivo();
            cboRestaurante.ValueMember = "Id_Restaurante";
            cboRestaurante.DisplayMember = "Nom_Restaurante";
            cboRestaurante.SelectedValue = idResta;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int16 id = Convert.ToInt16(cboRestaurante.SelectedValue);
            dtgReservas.DataSource = srvReservas.GetAllReservasRestaurante(id);
        }
    }
}
