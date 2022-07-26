using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Base_EventsPoster.Conn
{
    public static class Event_Pictures
    {

        public static void Picture_selection( ListView Events_List, PictureBox pictureBox_Event,bool n = true)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Graphics File|*.bmp; *.jpeg; *.png; *.gif";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (n) LoadPicture(ofd.FileName, Events_List, pictureBox_Event);
                else Update_Pictures_Event(ofd.FileName, Events_List, pictureBox_Event);
            }
        }

        private static void LoadPicture(string fileName, ListView Events_List, PictureBox pictureBox_Event)
        {
            if (Events_List.SelectedItems.Count > 0)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        byte[] bytes = CreateCopy(fileName);
                        db.stp_insert_Pictures_Event(eventID: Convert.ToInt32(Events_List.SelectedItems[0].Text), name_: fileName, picture: bytes);
                        db.SaveChanges();
                        MessageBox.Show($"Добавлена картинка к событию {Events_List.FocusedItem.SubItems[1].Text} !");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая картинка была добавлена ранее", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            else MessageBox.Show("Выберите событие");
            Image_output(pictureBox_Event, Convert.ToInt32(Events_List.SelectedItems[0].Text));

        }

        private static void Update_Pictures_Event(string fileName, ListView Events_List, PictureBox pictureBox_Event)
        {
            if (Events_List.SelectedItems.Count > 0)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        byte[] bytes = CreateCopy(fileName);
                        db.stp_Update_Pictures_Event(id: Convert.ToInt32(Events_List.SelectedItems[0].Text), eventID: Convert.ToInt32(Events_List.SelectedItems[0].Text), name_: fileName, picture: bytes);
                        db.SaveChanges();
                        MessageBox.Show($"Изменена картинка к событию {Events_List.FocusedItem.SubItems[1].Text} !");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Не удалось изменить картинку к событию {Events_List.FocusedItem.SubItems[1].Text} !");
                    }

                }

            }
            else MessageBox.Show("Выберите событие");
            Image_output( pictureBox_Event, Convert.ToInt32(Events_List.SelectedItems[0].Text));
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

        public static void Image_output(PictureBox pictureBox_Event, int event_id) // статик
        {
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    if (event_id > -1)
                    {
                        var result = db.Pictures_Event.Where(p => p.EventID == event_id);
                        if (result.Count() > 0)
                        {
                            MemoryStream ms = new MemoryStream(result.FirstOrDefault().Picture);
                            pictureBox_Event.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            if (pictureBox_Event.Image != null)
                            {
                                pictureBox_Event.Image.Dispose();
                                pictureBox_Event.Image = null;
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

        public static void Delete_Picture(PictureBox pictureBox_Event, ListView Events_List)
        {
            if (Events_List.SelectedItems.Count > 0)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        db.stp_Delete_Pictures_Event(id: Convert.ToInt32(Events_List.SelectedItems[0].Text));
                        MessageBox.Show($"Удалена картинка к событию {Events_List.FocusedItem.SubItems[1].Text} !");
                        db.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Выберите событие");
            Image_output(pictureBox_Event, Convert.ToInt32(Events_List.SelectedItems[0].Text));
        }


    }
}
