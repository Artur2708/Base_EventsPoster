using System;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Base_EventsPoster.Conn
{
    public static class Client_Pictures
    {

        public static void Picture_selection(ListView Client_List, PictureBox pictureBox_client, bool n = true)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Graphics File|*.bmp; *.jpeg; *.png; *.gif";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (n) LoadPicture_(ofd.FileName, Client_List, pictureBox_client);
                else Update_Pictures_Client_( ofd.FileName, Client_List, pictureBox_client);
            }
        }

        private static void LoadPicture_(string fileName, ListView Client_List, PictureBox pictureBox_client)
        {
            if (Client_List.SelectedItems.Count > 0 && pictureBox_client.Image == null)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        byte[] bytes = CreateCopy(fileName);
                        db.stp_insert_Pictures_Client(clientID: Convert.ToInt32(Client_List.SelectedItems[0].Text), name_: fileName, picture: bytes);
                        db.SaveChanges();
                        MessageBox.Show($"Добавлена картинка к клиенту {Client_List.FocusedItem.SubItems[1].Text} !");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая картинка была добавлена ранее", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
               
            }
            else MessageBox.Show("Ошибка");
            Image_output_(pictureBox_client, Convert.ToInt32(Client_List.SelectedItems[0].Text));

        }

        private static void Update_Pictures_Client_(string fileName, ListView Client_List, PictureBox pictureBox_client)
        {
            if (Client_List.SelectedItems.Count > 0 && pictureBox_client.Image != null)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        byte[] bytes = CreateCopy(fileName);
                        db.stp_Update_Pictures_Client(clientID: Convert.ToInt32(Client_List.SelectedItems[0].Text), name_: fileName, picture: bytes, id: Convert.ToInt32(Client_List.SelectedItems[0].Text));
                        db.SaveChanges();
                        MessageBox.Show($"Изменена картинка к клиенту {Client_List.FocusedItem.SubItems[1].Text} !");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Не удалось изменить картинку к клиенту {Client_List.FocusedItem.SubItems[1].Text} !");
                    }
                    
                }
            }
            else MessageBox.Show("Выберите клиента");
            Image_output_(pictureBox_client, Convert.ToInt32(Client_List.SelectedItems[0].Text));
        }

        private static byte[] CreateCopy(string fileName)
        {
            Image img = Image.FromFile(fileName);
            int maxWidth = 300, maxHeight = 300;

            double ratioX = (double)maxWidth / img.Width;
            double ratioY = (double)maxHeight / img.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);
            Image mi = new Bitmap(newWidth, newHeight);

            Graphics g = Graphics.FromImage(mi);
            g.DrawImage(img, 0, 0, newWidth, newHeight);
            MemoryStream ms = new MemoryStream();

            //поток для ввода|вывода байт из памяти
            mi.Save(ms, ImageFormat.Jpeg);
            ms.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(ms);
            byte[] buf = br.ReadBytes((int)ms.Length);
            return buf;
        }

        public static void Image_output_(PictureBox pictureBox_client, int client_id) 
        {
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    if (client_id > -1)
                    {
                        var result = db.Pictures_Client.Where(p => p.ClientID == client_id);
                        if (result.Count() > 0)
                        {
                            MemoryStream ms = new MemoryStream(result.FirstOrDefault().Picture);
                            pictureBox_client.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            if (pictureBox_client.Image != null)
                            {
                                pictureBox_client.Image.Dispose();
                                pictureBox_client.Image = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }


        public static void Delete_Picture(PictureBox pictureBox_client, ListView Client_List)
        {
            if (Client_List.SelectedItems.Count > 0 && pictureBox_client.Image != null)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        db.stp_Delete_Pictures_Client(id: Convert.ToInt32(Client_List.SelectedItems[0].Text));
                        MessageBox.Show($"Удалена картинка к клиенту {Client_List.FocusedItem.SubItems[1].Text} !");
                        db.SaveChanges();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Выберите клиента");
            Image_output_(pictureBox_client, Convert.ToInt32(Client_List.SelectedItems[0].Text));
        }
    }
}
