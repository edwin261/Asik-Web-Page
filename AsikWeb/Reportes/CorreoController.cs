using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using AsikWeb.Models.Entidades;
using AsikWeb.Base;
using System.Text;

namespace AsikWeb.Reportes
{
    public class CorreoController : BaseController
    {
        public CorreoController(IServiceProvider serviceProvider)
            : base(serviceProvider) { }

        #region correos cliente
        public async Task<bool> Send_Email(string Proyect_name, int estado, string Guia_number, string email)
        {
            try
            {
                using (var service = GetService<ASIK_PGWEB_Service>())
                {
                    string Estado = await service.GetEstado(estado);

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                    message.To.Add(new MailboxAddress("", email));
                    message.Subject = "Orden de trabajo: " + Proyect_name;

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Estimado cliente,

Nos permitimos informarle que su proyecto " + Proyect_name + @" se encuentra " +
    Estado + @". Recuerde que puede consultar el estado de su proceso de
certificación con su código asignado " + Guia_number.PadLeft(8, '0') + @" en nuestra página http://portalasik.com/ConsultarOT/Index .


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> Send_Email_ProgOT(Ord_Trabajo OT, Calendario cal, Usuarios usuarios)
        {
            try
            {
                using (var service = GetService<ASIK_PGWEB_Service>())
                {
                    string Estado = await service.GetEstado(OT.Ord_Estado);

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                    message.To.Add(new MailboxAddress("", OT.Ord_Emacad));
                    message.Subject = "Orden de trabajo: " + OT.Ord_Nomproy;

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Estimado cliente,

Nos permitimos informarle que su proyecto " + OT.Ord_Nomproy + @" se encuentra en estado " + Estado + @", para la fecha: " + cal.Inicio.Day + @" de " + Meses(cal.Inicio.Month) + @" del " + cal.Inicio.Year + @" hasta el "
+ cal.Fin.Day + @" de " + Meses(cal.Fin.Month) + @" del " + cal.Fin.Year + @", con el ingeniero " + usuarios.UsuNombre + @" " + usuarios.UsuApelli + @". 
Recuerde que puede consultar el estado de su proceso de certificación con su código asignado " + Convert.ToString(OT.Ord_Codotc).PadLeft(8, '0') + @" en nuestra página http://portalasik.com/ConsultarOT/Index .


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string Meses(int cod_mes)
        {
            switch (cod_mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
            }
            return null;
        }
        public bool Send_Email_Rev_Documental(List<Rev_DocItem> rev_DocItem, Ord_Trabajo ord_Trabajo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Estimado cliente,<br/>" +
                    "Nos permitimos informarle que despues de realizar la revision documental al proyecto " + ord_Trabajo.Ord_Nomproy + @", con codigo " + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0') + @"
se encuentraron inconformodidades o falta de los siguientes documentos:<br/>");
                foreach (var DocItem in rev_DocItem)
                {
                    sb.AppendFormat("<br/>{0}", DocItem.Rev_DocCheck + ": " + DocItem.Rev_Descrip);
                }
                sb.Append("<br/>" + "Recuerde que puede consultar el estado de su proceso de certificación con su código asignado " + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0') + @" en nuestra página http://portalasik.com/ConsultarOT/Index .<br/>" +
"Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.<br/><br/><br/>" + "Cordialmente,<br/><br/><br/>" + "ASIK SAS<br/> " + "CERTIFICAMOS SU TRANQUILIDAD");

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                message.To.Add(new MailboxAddress("", ord_Trabajo.Ord_Emacad));
                message.Subject = "Orden de trabajo: " + ord_Trabajo.Ord_Nomproy;

                if (rev_DocItem.Count == 0)
                {
                    message.Body = new TextPart("plain")
                    {
                        Text = @"Estimado cliente,

Nos permitimos informarle que despues de realizar la revision documental de los documentos proporcionados para el proyecto " + ord_Trabajo.Ord_Nomproy + @", con codigo " + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0') + @", 
estos fueron revisados y aprovados por nuestro departamento de revision documental, el nuevo estado de la orden de trabajo ahora es: Aprovada la revision documental.

Recuerde que puede consultar el estado de su proceso de
certificación con su código asignado " + ord_Trabajo.Ord_Codotc.ToString().PadLeft(8, '0') + @" en nuestra página http://portalasik.com/ConsultarOT/Index .


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };
                }
                else
                {
                    var builder = new BodyBuilder();
                    builder.HtmlBody = string.Format(sb.ToString());

                    message.Body = builder.ToMessageBody();
                }

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Send_Rev_DocumentalToCli(List<Rev_DocItem> rev_DocItem, Ord_Trabajo ord_Trabajo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Estimado cliente,<br/>" +
                    "Nos permitimos informarle que se necesita propocionar la siguiente documentacion para la orden de trabajo " + ord_Trabajo.Ord_Nomproy + @", con codigo " + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0'));
                foreach (var DocItem in rev_DocItem)
                {
                    sb.AppendFormat("<br/>{0}", DocItem.Rev_DocCheck);
                }
                sb.Append("<br/>" + "Recuerde que puede consultar el estado de su proceso de certificación con su código asignado " + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0') + @" en nuestra página http://portalasik.com/ConsultarOT/Index .<br/>" +
"Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.<br/><br/><br/>" + "Cordialmente,<br/><br/><br/>" + "ASIK SAS<br/> " + "CERTIFICAMOS SU TRANQUILIDAD");

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                message.To.Add(new MailboxAddress("", ord_Trabajo.Ord_Emacad));
                message.Subject = "Orden de trabajo: " + ord_Trabajo.Ord_Nomproy;
                {
                    var builder = new BodyBuilder();
                    builder.HtmlBody = String.Format(sb.ToString());

                    message.Body = builder.ToMessageBody();
                }

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Send_EmailDictamen(Ord_Trabajo ord_Trabajo, Env_Dictamen env_Dictamen, string path)
        {
            try
            {
                using (var service = GetService<ASIK_PGWEB_Service>())
                {
                    string messageDictamen = "";
                    messageDictamen = env_Dictamen.Env_NGuia != null ? env_Dictamen.Env_Nombre + ", con codigo de guia numero: " + env_Dictamen.Env_NGuia :
                        env_Dictamen.Env_Nombre;

                    var builder = new BodyBuilder();

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                    message.To.Add(new MailboxAddress("", ord_Trabajo.Ord_Emacad));
                    message.Subject = "Orden de trabajo: " + ord_Trabajo.Ord_Nomproy;

                    builder.TextBody = @"Estimado cliente,

Nos permitimos informarle que para su proyecto " + ord_Trabajo.Ord_Nomproy + @", le fue emitido un dictamen, el cual fue envio a usted por
medio de un " + messageDictamen + @".


Recuerde que puede consultar el estado de su proceso de certificación con su código asignado " + ord_Trabajo.Ord_Codotc.ToString().PadLeft(8, '0') + @",
en nuestra página http://portalasik.com/ConsultarOT/Index .


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD";

                    builder.Attachments.Add(path);

                    message.Body = message.Body = builder.ToMessageBody();

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region correos administrativos
        public async Task<bool> Send_Email_Facturacion(string Proyect_name, Clientes clientes, int estado, string Guia_number, List<Usuarios> lstUsu)
        {
            try
            {
                using (var service = GetService<ASIK_PGWEB_Service>())
                {
                    string Estado = await service.GetEstado(estado);

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                    foreach (var mail in lstUsu)
                    {
                        message.To.Add(new MailboxAddress("", mail.UsuEmail));
                    }
                    message.Subject = "Orden de trabajo: " + Proyect_name;

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Nos permitimos informarle que el proyecto: 
Nombre " + Proyect_name + @", 
Código: OT-" + Guia_number.PadLeft(8, '0') + @",
Cliente: " + clientes.CliNombre + @".

Se encuentra listo para ser facturado.


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> Send_Email_ProgTec(Ord_Trabajo OT, List<Usuarios> LstUSu, Clientes clientes,
            Deparcol deparcol, Munidep munidep)
        {
            try
            {
                foreach (var UsuProg in LstUSu)
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                    message.To.Add(new MailboxAddress("", UsuProg.UsuEmail));
                    message.Subject = "Orden de trabajo: " + OT.Ord_Nomproy;

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Nos permitimos informarle que el proyecto: 
Nombre: " + OT.Ord_Nomproy + @", 
Código: OT-" + Convert.ToString(OT.Ord_Codotc).PadLeft(8, '0') + @",
Cliente: " + clientes.CliNombre + @",
Direccion: " + clientes.CliDirecc + @",
Departamento: " + deparcol.Dep_Nombre + @",
Ciudad: " + munidep.Ciu_Nombre + @",
Telefono Cliente: " + clientes.CliTelefo + @",
Nombre de contacto: " + clientes.CliDirecc + @",
Telefono fijo: " + OT.Ord_Telcad + @",
Telefono movil: " + OT.Ord_Celcad + @",

Fue creado y se encuentra pendiente por asignar una programacion tecnica.



Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }
                }

                await Send_Email(OT.Ord_Nomproy, OT.Ord_Estado, Convert.ToString(OT.Ord_Codotc), OT.Ord_Emacad);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Send_Email_Documental(Ord_Trabajo OT, List<Usuarios> LstUSu, Clientes clientes,
            Deparcol deparcol, Munidep munidep, List<Alcance> alcance, List<Tip_alcance> tip_Alcance)
        {
            try
            {
                foreach (var UsuProg in LstUSu)
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                    message.To.Add(new MailboxAddress("", UsuProg.UsuEmail));
                    message.Subject = "Orden de trabajo: " + OT.Ord_Nomproy;

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Nos permitimos informarle que el proyecto:
Código: OT-" + Convert.ToString(OT.Ord_Codotc).PadLeft(8, '0') + @",
Nombre: " + OT.Ord_Nomproy + @", 
Cliente: " + clientes.CliNombre + @",
Direccion: " + clientes.CliDirecc + @",
Departamento: " + deparcol.Dep_Nombre + @",
Ciudad: " + munidep.Ciu_Nombre + @",
Alcance: " + alcance.Where(w => w.AlcCodigo == OT.Ord_Alccod).Select(s => s.AlcNombre).FirstOrDefault() + @",
Tipo de alcance: " + tip_Alcance.Where(w => w.Tip_alcodi == OT.Ord_Talcod).Select(s => s.Tip_alnomb).FirstOrDefault() + @",

Fue creado y se encuentra pendiente por realizar la revision documental.



Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Send_Email_Contabilidad(string Proyect_name, Clientes clientes, string Guia_number, List<Usuarios> lstUsu)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                foreach (var mail in lstUsu)
                {
                    message.To.Add(new MailboxAddress("", mail.UsuEmail));
                }
                message.Subject = "Orden de trabajo: " + Proyect_name;

                message.Body = new TextPart("plain")
                {
                    Text = @"Nos permitimos informarle que el proyecto: 
Nombre " + Proyect_name + @", 
Código: OT-" + Guia_number.PadLeft(8, '0') + @",
Cliente: " + clientes.CliNombre + @".

Se encuentra facturado y listo para ser contabilizado.


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> Send_Email_Tecnico(Ord_Trabajo ord_Trabajo, Calendario calendario, Usuarios usuarios, Clientes clientes, Deparcol deparcol, Munidep munidep)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                message.To.Add(new MailboxAddress("", usuarios.UsuEmail));
                message.Subject = "Orden de trabajo: " + ord_Trabajo.Ord_Nomproy;

                message.Body = new TextPart("plain")
                {
                    Text = @"Nos permitimos informarle que el proyecto: 
Nombre " + ord_Trabajo.Ord_Nomproy + @", 
Código: OT-" + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0') + @",
Cliente: " + clientes.CliNombre + @",
Direccion: " + clientes.CliDirecc + @",
Departamento: " + deparcol.Dep_Nombre + @",
Ciudad: " + munidep.Ciu_Nombre + @",
Telefono Cliente: " + clientes.CliTelefo + @",
Nombre de contacto: " + clientes.CliDirecc + @",
Telefono fijo: " + ord_Trabajo.Ord_Telcad + @",
Telefono movil: " + ord_Trabajo.Ord_Celcad + @",

Se le asigno para realizar la inspeccion en la fecha: 
Inicio: " + calendario.Inicio.Day + @" de " + Meses(calendario.Inicio.Month) + @" del " + calendario.Inicio.Year + @".
Fin: " + calendario.Fin.Day + @" de " + Meses(calendario.Fin.Month) + @" del " + calendario.Fin.Year + @".


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                    client.Send(message);
                    client.Disconnect(true);
                }

                await Send_Email_ProgOT(ord_Trabajo, calendario, usuarios);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Send_Email_DirTecnico(Ord_Trabajo ord_Trabajo, Calendario calendario, Usuarios usuarios, List<Usuarios> LstUSu, Clientes clientes, Deparcol deparcol, Munidep munidep)
        {
            try
            {
                foreach (var DirTecnico in LstUSu)
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                    message.To.Add(new MailboxAddress("", DirTecnico.UsuEmail));
                    message.Subject = "Orden de trabajo: " + ord_Trabajo.Ord_Nomproy;

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Nos permitimos informarle que el proyecto: 
Nombre: " + ord_Trabajo.Ord_Nomproy + @", 
Código: OT-" + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0') + @",
Cliente: " + clientes.CliNombre + @",
Direccion: " + clientes.CliDirecc + @",
Departamento: " + deparcol.Dep_Nombre + @",
Ciudad: " + munidep.Ciu_Nombre + @",
Telefono Cliente: " + clientes.CliTelefo + @",
Nombre de contacto: " + clientes.CliDirecc + @",
Telefono fijo: " + ord_Trabajo.Ord_Telcad + @",
Telefono movil: " + ord_Trabajo.Ord_Celcad + @",

El cual se le asigno al tecnico " + usuarios.UsuNombre + @" " + usuarios.UsuApelli + @" para realizar la inspeccion en la fecha: 
Inicio: " + calendario.Inicio.Day + @" de " + Meses(calendario.Inicio.Month) + @" del " + calendario.Inicio.Year + @".
Fin: " + calendario.Fin.Day + @" de " + Meses(calendario.Fin.Month) + @" del " + calendario.Fin.Year + @".

Ya se encuentra lista para ser verificado y aprobado.



Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Send_Email_Cant_VisitRev(Ord_Trabajo ord_Trabajo, string message_content, List<Usuarios> usuarios)
        {
            try
            {
                foreach (var item in usuarios)
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));

                    message.To.Add(new MailboxAddress("", item.UsuEmail));

                    message.Subject = "Orden de trabajo: " + ord_Trabajo.Ord_Nomproy;

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Nos permitimos informarle que el proyecto " + ord_Trabajo.Ord_Nomproy + @", con codigo " + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0')
    + @", actualmente le resta una(1) " + message_content + @".


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> ninetyDaysMail()
        {
            try
            {
                using (var service = GetService<ASIK_PGWEB_Service>())
                {
                    List<Ord_Trabajo> ord_TrabajosninetyDays = await service.ninetyDays();
                    if (ord_TrabajosninetyDays.Count() > 0)
                    {
                        foreach (var Ot in ord_TrabajosninetyDays.Where(w => w.Ord_Emacad != null))
                        {
                            Clientes clientes = await service.GetCliente(Ot.Ord_Codcli);

                            var message = new MimeMessage();
                            message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                            message.To.Add(new MailboxAddress("", Ot.Ord_Emacad));
                            message.Subject = "Orden de trabajo: " + Ot.Ord_Nomproy;

                            message.Body = new TextPart("plain")
                            {
                                Text = @"Buenos dias,

Nos permitimos informarle que el proyecto: 
Nombre " + Ot.Ord_Nomproy + @", 
Código: " + Ot.Ord_Codotc.ToString().PadLeft(8, '0') + @",
Cliente: " + clientes.CliNombre + @"
Fecha de Creacion: " + Ot.Ord_Feccre.ToShortDateString() + @",
Fecha de Vencimiento: " + Ot.Ord_Fecfin.ToShortDateString() + @".

Desde su fecha de creacion han pasado 90 dias y esta proximo a vencerse.


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                            };

                            using (var client = new SmtpClient())
                            {
                                client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                                client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                                client.Send(message);
                                client.Disconnect(true);
                            }
                        }
                    }

                    List<Ord_Trabajo> ord_TrabajoshundredtwentyDays = await service.hundredtwentyDays();
                    if (ord_TrabajoshundredtwentyDays.Count() > 0)
                    {
                        foreach (var Ot in ord_TrabajoshundredtwentyDays.Where(w => w.Ord_Emacad != null))
                        {
                            bool updateEstado = await service.Est_NoAprobado(Ot.Ord_Codotc);

                            if (updateEstado)
                            {
                                Clientes clientes = await service.GetCliente(Ot.Ord_Codcli);

                                var message = new MimeMessage();
                                message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));
                                message.To.Add(new MailboxAddress("", Ot.Ord_Emacad));
                                message.Subject = "Orden de trabajo: " + Ot.Ord_Nomproy;

                                message.Body = new TextPart("plain")
                                {
                                    Text = @"Buenos dias,

Nos permitimos informarle que el proyecto: 
Nombre " + Ot.Ord_Nomproy + @", 
Código: " + Ot.Ord_Codotc.ToString().PadLeft(8, '0') + @",
Cliente: " + clientes.CliNombre + @"
Fecha de Creacion: " + Ot.Ord_Feccre.ToShortDateString() + @",
Fecha de Vencimiento: " + Ot.Ord_Fecfin.ToShortDateString() + @".

Desde su fecha de creacion han pasado 120 dias y el proyecto a pasado a estado de NO APROBADO.


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                                };

                                using (var client = new SmtpClient())
                                {
                                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                                    client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                                    client.Send(message);
                                    client.Disconnect(true);
                                }
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Conf_CampoDoc(List<Usuarios> LstUsuarios, Usuarios usuarios, Ord_Trabajo ord_Trabajo)
        {
            int count = 0;
            try
            {
                foreach (var lstusu in LstUsuarios)
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));

                    message.To.Add(new MailboxAddress("", lstusu.UsuEmail));

                    if (count == 0)
                        message.To.Add(new MailboxAddress("", usuarios.UsuEmail));

                    message.Subject = "Orden de trabajo: " + ord_Trabajo.Ord_Nomproy;

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Nos permitimos informarle que el proyecto " + ord_Trabajo.Ord_Nomproy + @", con codigo " + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0')
    + @", se encuentra conforme en campo y se necesita la elaboracion de los siguientes documentos:

- Elaboracion del dictamen.
- Elaboracion de carpeta de inspeccion.
- Escaneo de documentos físicos entregados por el cliente.


Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }
                    count++;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool mailLoadDictamen(List<Usuarios> LstUsuarios, Ord_Trabajo ord_Trabajo)
        {
            int count = 0;
            try
            {
                foreach (var lstusu in LstUsuarios)
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));

                    message.To.Add(new MailboxAddress("", lstusu.UsuEmail));

                    message.Subject = "Orden de trabajo: " + ord_Trabajo.Ord_Nomproy;

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Nos permitimos informarle que el proyecto " + ord_Trabajo.Ord_Nomproy + @", con codigo " + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0')
    + @", se encuentra facturado y contabilizado, se necesita subir el dictamen a las páginas web de ASIk Y DIIE según aplique.

Una vez subido el dictamen a la pagina web se debe actualizar el estado de la orden de trabajo por medio de la pagina web administrativa de asik.



Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                        client.Send(message);
                        client.Disconnect(true);
                    }
                    count++;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SenMailNoConforme(Usuarios LstUsuarios, Ord_Trabajo ord_Trabajo, Calendario calendario)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Asik S.A.S", "soporteiinspector@gmail.com"));

                message.To.Add(new MailboxAddress("", LstUsuarios.UsuEmail));

                message.Subject = "Orden de trabajo: " + ord_Trabajo.Ord_Nomproy;

                message.Body = new TextPart("plain")
                {
                    Text = @"Nos permitimos informarle que el proyecto " + ord_Trabajo.Ord_Nomproy + @", con codigo " + Convert.ToString(ord_Trabajo.Ord_Codotc).PadLeft(8, '0')
+ @", al cual le fue realizado la visita tecnica el dia " + calendario.Inicio.ToShortDateString() + @" fue declarado como No Conforme por el director tecnico.



Esta dirección de e-mail es utilizada solamente para envíos automáticos, por favor no responder este correo.
Cordialmente,



ASIK SAS
CERTIFICAMOS SU TRANQUILIDAD"
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate("soporteiinspector@gmail.com", "Soporteaplicaciones");
                    client.Send(message);
                    client.Disconnect(true);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}