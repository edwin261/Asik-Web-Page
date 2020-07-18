using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AsikWeb.Models.Helpers;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.XlsIO;
using AsikWeb.Models.Entidades;
using System.Security.Claims;

namespace AsikWeb.Reportes
{
    public class ReporteCliente : Controller
    {
        #region modelo del mensaje que se enviara a los correos de los clientes
        public AsikWebHelpers PdfReportClient(Ord_Trabajo ord_Trabajo, Clientes clientes, Usuarios usuarios,
            Alcance alcance)
        {
            //Creacion parametros pdf
            PdfDocument document = new PdfDocument();
            document.PageSettings.Margins.All = 0;
            PdfPage page = document.Pages.Add();
            PdfGraphics g = page.Graphics;
            PdfBrush brush = new PdfSolidBrush(new PdfColor(0, 0, 0));
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12);

            //Escribir contenido del pdf
            g.DrawString("Barranquilla, " + DateTime.Now.ToShortDateString(), font, brush, new PointF(45, 60));
            g.DrawString("Asik-" + DateTime.Now.Year + "-" + ord_Trabajo.Ord_Codotc.ToString().PadLeft(8, '0'), font, brush, new PointF(413, 75));
            g.DrawString("Señores:", font, brush, new PointF(45, 105));
            g.DrawString(clientes.CliNombre, new PdfStandardFont(PdfFontFamily.TimesRoman, 12, PdfFontStyle.Bold), brush, new PointF(45, 119));
            g.DrawString("Referencia: Entrega del dictamen del proyecto " + ord_Trabajo.Ord_Nomproy, font, brush, new PointF(45, 135));
            g.DrawString("Cordial saludo,", font, brush, new PointF(45, 160));
            g.DrawString("Por medio del presente realizamos entrega del dictamen del proyecto " + ord_Trabajo.Ord_Nomproy + ", correspondiente al proceso de " + alcance.AlcNombre + ". Se anexa copia del original.", font, brush, new RectangleF(45, 205, 505, 35));
            g.DrawString("Dictamen 1 para el total de 1 Dictamen", font, brush, new RectangleF(72, 239, 490, 35));
            g.DrawString("Teniendo como objetivo la mejora continua de nuestros procesos, estamos muy interesados en conocer su opinión acerca de nuestros servicios, por lo que solicitamos su colaboración con el diligenciamiento de la encuesta de satisfacción que se envía adjunto a la presente.", font, brush, new RectangleF(45, 275, 505, 50));
            g.DrawString("Una vez se haya completado la encuesta, puede hacer la entrega de la misma en nuestras instalaciones ubicadas en la calle 77B# 57-103, Oficina 302 edificio Green Towers, o de forma digital a través del correo: calidad@asik.com.co Esperamos poder contar con su opinión ya que es muy importante para nosotros.", font, brush, new RectangleF(45, 325, 505, 50));
            g.DrawString("Atentamente,", font, brush, new PointF(45, 400));
            g.DrawString(usuarios.UsuNombre + " " + usuarios.UsuApelli, font, brush, new PointF(45, 495));
            g.DrawString("ASISTENTE ADMINISTRATIVA", font, brush, new PointF(45, 511));

            //Guardado del pdf dentro de la carpeta del proyecto
            document.DocumentInformation.Author = "Oursoft";
            document.DocumentInformation.Keywords = "PDF, Asik, Oursoft, AsikWeb";
            document.DocumentInformation.CreationDate = DateTime.Now;
            var filename = @"wwwroot\" + DateTime.Now.ToString("ddMMyyyy") + "_Prueba" + ".pdf";
            FileStream fileStream = new FileStream(filename, FileMode.CreateNew, FileAccess.ReadWrite);
            document.Save(fileStream);
            document.Close(true);
            document.Dispose();
            fileStream.Close();

            return new AsikWebHelpers { Status = true, Message = filename };
        }
        #endregion

        #region Excel de revisiones documentales no conformes
        public async Task<string> ExcelRevDoc(int CodUsu, List<Rev_Noaprov> rev_Noaprov, List<Ord_Trabajo> ord_Trabajo,
            List<Clientes> clientes, List<Alcance> alcance, List<Tip_alcance> tip_Alcance)
        {
            //Create an instance of ExcelEngine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                try
                {
                    IApplication application = excelEngine.Excel;

                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //Create a workbook
                    IWorkbook workbook = application.Workbooks.Create(1);
                    for (int i = 0; i < ord_Trabajo.Count(); i++)
                    {
                        //int revCount = 1;
                        if (i > 0)
                            workbook.Worksheets.Create();
                        IWorksheet worksheet = workbook.Worksheets[i];
                        worksheet.Name = ord_Trabajo[i].Ord_Codotc.ToString().PadLeft(8, '0') + "-" + ord_Trabajo[i].Ord_Nomproy;

                        //Adding a picture
                        //FileStream imageStream = new FileStream("Logo_Final_Asik.svg", FileMode.Open, FileAccess.Read);
                        //IPictureShape shape = worksheet.Pictures.AddPicture(1, 1, imageStream);

                        //Disable gridlines in the worksheet
                        worksheet.IsGridLinesVisible = false;

                        //Enter values to the cells from A3 to A5
                        worksheet.Range["A3"].Text = "Proyecto: " + ord_Trabajo[i].Ord_Nomproy;
                        worksheet.Range["A4"].Text = "Fecha de Inicio: " + ord_Trabajo[i].Ord_Feccre.ToShortDateString();
                        worksheet.Range["A5"].Text = "Fecha de Fin: " + ord_Trabajo[i].Ord_Fecfin.ToShortDateString();
                        worksheet.Range["A6"].Text = "Cliente: " + clientes.FirstOrDefault().CliNombre;
                        worksheet.Range["A7"].Text = "Alcance: " + alcance.Where(w => w.AlcCodigo == ord_Trabajo[i].Ord_Alccod).Select(s => s.AlcNombre).FirstOrDefault();
                        worksheet.Range["A8"].Text = "Tipo alcance: " + tip_Alcance.Where(w => w.Tip_alcodi == ord_Trabajo[i].Ord_Talcod).Select(s => s.Tip_alnomb).FirstOrDefault();

                        //Make the text bold
                        worksheet.Range["A3:A8"].CellStyle.Font.Bold = true;

                        //Merge cells
                        worksheet.Range["D1:R1"].Merge();

                        //Enter text to the cell D1 and apply formatting.
                        worksheet.Range["D1"].Text = "ORDEN DE TRABAJO: " + ord_Trabajo[i].Ord_Codotc.ToString().PadLeft(8, '0');
                        worksheet.Range["D1"].CellStyle.Font.Bold = true;
                        worksheet.Range["D1"].CellStyle.Font.RGBColor = Color.FromArgb(42, 118, 189);
                        worksheet.Range["D1"].CellStyle.Font.Size = 35;

                        //Apply alignment in the cell D1
                        worksheet.Range["D1"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                        worksheet.Range["D1"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignTop;

                        if (rev_Noaprov.Count() > 0)
                        {
                            int numberCell = 11;

                            foreach (var revisionNumber in rev_Noaprov.Where(w => w.Rev_CodOt == ord_Trabajo[i].Ord_Codotc).Select(s => s.Rev_Numrev).Distinct())
                            {
                                //Merge column A and B
                                worksheet.Range["A" + numberCell + ":J" + numberCell].Merge();
                                //Apply cell color
                                worksheet.Range["A" + numberCell + ":J" + numberCell].CellStyle.Color = Color.FromArgb(42, 118, 189);
                                worksheet.Range["A" + numberCell + ":J" + numberCell].CellStyle.Font.Color = ExcelKnownColors.White;
                                worksheet.Range["A" + numberCell].Text = "  Revision # " + revisionNumber;//revCount++
                                worksheet.Range["A" + numberCell + ":J" + numberCell].CellStyle.Font.Bold = true;

                                foreach (var DocRevision in rev_Noaprov.Where(w => w.Rev_CodOt == ord_Trabajo[i].Ord_Codotc && w.Rev_Numrev == revisionNumber))
                                {
                                    numberCell++;
                                    worksheet.Range["A" + numberCell + ":J" + numberCell].Merge();
                                    worksheet.Range["A" + numberCell].Text = DocRevision.Rev_DocCheck;
                                    worksheet.Range["A" + numberCell + ":J" + numberCell].CellStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                                    worksheet.Range["A" + numberCell + ":J" + numberCell].CellStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                                    worksheet.Range["A" + numberCell + ":J" + numberCell].CellStyle.Borders[ExcelBordersIndex.EdgeTop].Color = ExcelKnownColors.Grey_25_percent;
                                    worksheet.Range["A" + numberCell + ":J" + numberCell].CellStyle.Borders[ExcelBordersIndex.EdgeBottom].Color = ExcelKnownColors.Grey_25_percent;
                                }
                                numberCell += 3;
                            }
                            //Apply font setting for cells with product details

                            worksheet.Range["A3:J" + numberCell].CellStyle.Font.FontName = "Arial";
                            worksheet.Range["A3:J" + numberCell].CellStyle.Font.Size = 10;
                        }
                    }

                    var filename = @"wwwroot\Asik_Reporte_DocNoAprovado_" + CodUsu + ".xlsx";
                    string filenameToReturn = "/Asik_Reporte_DocNoAprovado_" + CodUsu + ".xlsx";
                    FileStream fileStream = new FileStream(filename, FileMode.Create);
                    workbook.SaveAs(fileStream);
                    await fileStream.DisposeAsync();
                    return filenameToReturn;
                }
                catch (Exception ex)
                {
                    return "Ha ocurrido un problema al generar el documento de excel.";
                }
            }
        }
        #endregion

        #region Excel de Tiempo x Tecnicas
        public async Task<string> ExcelTecTime(int CodUsu, List<Inspeccion> inspeccion, List<Ord_Trabajo> ord_Trabajo,
            List<Clientes> clientes, List<Alcance> alcance, List<Tip_alcance> tip_Alcance, List<Usuarios> usuarios)
        {
            //Create an instance of ExcelEngine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                try
                {
                    IApplication application = excelEngine.Excel;

                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //Create a workbook
                    IWorkbook workbook = application.Workbooks.Create(1);
                    IWorksheet worksheet = workbook.Worksheets[0];
                    worksheet.Range["A1"].Text = "Proyecto";
                    worksheet.Range["B1"].Text = "F. Inicial";
                    worksheet.Range["C1"].Text = "F. Final";
                    worksheet.Range["D1"].Text = "Cliente";
                    worksheet.Range["E1"].Text = "Alcance";
                    worksheet.Range["F1"].Text = "Tipo de Alcance";
                    worksheet.Range["G1"].Text = "Tecnico";
                    worksheet.Range["H1"].Text = "Inicio Inspeccion";
                    worksheet.Range["I1"].Text = "Fin Inspeccion";
                    worksheet.Range["J1"].Text = "Tiempo Total";
                    worksheet.Range["K1"].Text = "Estado";

                    worksheet.Range["A1"].ColumnWidth = 47;
                    worksheet.Range["B1"].ColumnWidth = 25;
                    worksheet.Range["C1"].ColumnWidth = 25;
                    worksheet.Range["D1"].ColumnWidth = 50;
                    worksheet.Range["E1"].ColumnWidth = 20;
                    worksheet.Range["F1"].ColumnWidth = 20;
                    worksheet.Range["G1"].ColumnWidth = 35;
                    worksheet.Range["H1"].ColumnWidth = 25;
                    worksheet.Range["I1"].ColumnWidth = 25;
                    worksheet.Range["J1"].ColumnWidth = 40;
                    worksheet.Range["K1"].ColumnWidth = 20;
                    //worksheet.IsGridLinesVisible = false;

                    for (int i = 0; i < ord_Trabajo.Count(); i++)
                    {
                        int cellpos = i + 2;
                        worksheet.Range["A" + cellpos].Text = ord_Trabajo[i].Ord_Nomproy;
                        worksheet.Range["B" + cellpos].Text = ord_Trabajo[i].Ord_Feccre.ToShortDateString();
                        worksheet.Range["C" + cellpos].Text = ord_Trabajo[i].Ord_Fecfin.ToShortDateString();
                        worksheet.Range["D" + cellpos].Text = clientes.Where(w => w.CliIdenti == ord_Trabajo[i].Ord_Codcli).Select(s => s.CliNombre).FirstOrDefault();
                        worksheet.Range["E" + cellpos].Text = alcance.Where(w => w.AlcCodigo == ord_Trabajo[i].Ord_Alccod).Select(s => s.AlcNombre).FirstOrDefault();
                        worksheet.Range["F" + cellpos].Text = tip_Alcance.Where(w => w.Tip_alcodi == ord_Trabajo[i].Ord_Talcod).Select(s => s.Tip_alnomb).FirstOrDefault();

                        foreach (var itemInspeccion in inspeccion.Where(w => w.Insp_Codot == ord_Trabajo[i].Ord_Codotc))
                        {
                            worksheet.Range["G" + cellpos].Text = usuarios.Where(w => w.UsuIdenti == itemInspeccion.Insp_Codtec).Select(s => s.UsuNombre).FirstOrDefault();
                            worksheet.Range["H" + cellpos].Text = Convert.ToString(itemInspeccion.Insp_Inici);
                            worksheet.Range["I" + cellpos].Text = Convert.ToString(itemInspeccion.Insp_Fin);
                            worksheet.Range["j" + cellpos].Text = itemInspeccion.Insp_Ttotal;
                            if ((itemInspeccion.Insp_Con_Cam || itemInspeccion.Insp_Final) && !itemInspeccion.Insp_Dic_Dictec)
                            {
                                worksheet.Range["K" + cellpos].Text = "Conforme en Campo";
                            }
                            else if (itemInspeccion.Insp_Dic_Dictec)
                            {
                                worksheet.Range["K" + cellpos].Text = "Inspeccion Aprovada";
                            }
                            else
                            {
                                worksheet.Range["K" + cellpos].Text = "En Proceso";
                            }
                        }
                    }

                    worksheet.Range["A1:K1"].CellStyle.Color = Color.FromArgb(42, 118, 189);
                    worksheet.Range["A1:K1"].CellStyle.Font.Color = ExcelKnownColors.White;

                    var filename = @"wwwroot\Asik_Reporte_HoraTec_" + CodUsu + ".xlsx";
                    string filenameToReturn = "/Asik_Reporte_HoraTec_" + CodUsu + ".xlsx";
                    FileStream fileStream = new FileStream(filename, FileMode.Create);
                    workbook.SaveAs(fileStream);
                    await fileStream.DisposeAsync();
                    return filenameToReturn;
                }
                catch (Exception ex)
                {
                    return "Ha ocurrido un problema al generar el documento de excel.";
                }
            }
        }
        #endregion
    }
}