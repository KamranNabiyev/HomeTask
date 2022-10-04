using ItBrains.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ItBrains.Extentions
{
    public static class Helper
    {
        public static async Task SendMessageWithFile(string messageSubject, string messageBody, string mailTo, IFormFile file)
        {

            SmtpClient client = new SmtpClient("smtp.yandex.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("developer@itbrains.az", "msxcqnohwsmtekyb");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage("developer@itbrains.az", mailTo);
            message.Subject = messageSubject;
            message.Body = messageBody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            if (file.Length > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                message.Attachments.Add(new Attachment(file.OpenReadStream(), fileName));
            }

            await client.SendMailAsync(message);


        }
        public static async Task SendMessage(string messageSubject, string messageBody, string mailTo)
        {
           
                SmtpClient client = new SmtpClient("smtp.yandex.com", 587);
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("developer@itbrains.az", "msxcqnohwsmtekyb");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage message = new MailMessage("developer@itbrains.az", mailTo);
                message.Subject = messageSubject;
                message.Body = messageBody;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.IsBodyHtml = true;
            

                await client.SendMailAsync(message);

            
        }
        public static string UploadImage(string imgCropped, string root, string folder)
        {
            string filename = GetUniqueFileName($"ItBrains-{DateTime.Now.ToString("ffffff")}.jpeg");
            string filewithFolder = Path.Combine(folder, filename);
            string fullPath = Path.Combine(root, filewithFolder);
            string base64 = imgCropped.Substring(imgCropped.IndexOf(',') + 1);
            SaveByteArrayAsImage(fullPath, base64);
            return filename;
        }

        public static void SaveByteArrayAsImage(string fullOutputPath, string base64String)
        {
            byte[] bytes = Convert.FromBase64String(base64String);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
                var i2 = new Bitmap(image);
                image.Save(fullOutputPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        public static void DeleteImage(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);

            }
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        public static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        public static string GetRandomString()
        {

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[6];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            //    string smsMessage = "http://www.poctgoyercini.com/api_http/sendsms.asp?user=7gul_servis&password=7gul852&gsm=" + registerVm.Phone + "&text=" + message;

            //    using (var httpClient = new HttpClient())
            //    {
            //        using (var response = await httpClient.GetAsync(smsMessage))
            //        {
            //            string apiResponse = await response.Content.ReadAsStringAsync();
            //        }
            //    }
            return finalString;
        }
        public static async Task SendSmsAsync(string phone, string message)
        {
            string smsMessage = "http://www.poctgoyercini.com/api_http/sendsms.asp?user=7gul_servis&password=7gul_2017&gsm=" + phone + "&text=" + message;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(smsMessage))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

        }
        public static string GetFileForName(string fullPath, string fileName)
        {
            string path = Path.Combine(fullPath, fileName);
            byte[] b = System.IO.File.ReadAllBytes(path);
            return "data:image/png;base64," + Convert.ToBase64String(b);
        }
        public enum Roles
        {
            Admin,
            ConManager,
            JrC,
            Teacher
        }
        
       

    }
}
