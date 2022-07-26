using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_EventsPoster.Repos
{
    public class Client_rep : IRepositories<Clients>
    {
        public void Add(ListView list)
        {
            Anceta_Client anceta_ = new Anceta_Client();
            if (anceta_.ShowDialog() == DialogResult.OK)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        db.stp_Insert_Client(firstName: anceta_.clients.FirstName, lastName: anceta_.clients.LastName, bD: anceta_.clients.BD, email: anceta_.clients.Email);
                        db.SaveChanges();
                        MessageBox.Show($"Клиент добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_list(list);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Такой клиент уже был добавлен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }
        

        public void All(ListView list)
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var clients = db.stp_Info_client().ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.FirstName, item.LastName, item.BD.ToShortDateString(), item.Email }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }


        public void Delete(ListView list)
        {
            if (list.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(list.SelectedItems[0].Text);
                if (MessageBox.Show($"Вы хотите удалить клиента с ID = {id} ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            db.stp_Delete_Client(iD: id);
                            db.SaveChanges();
                            MessageBox.Show($"Клиент c ID = {id} удален", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new_list(list);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                    }
                }
            }
        }

        public void GetById(int id, ListView list)
        {
            Clients clients = null;
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var result = db.Clients.Where(c => c.Id == id);
                    if (result.Count() > 0)
                    {
                        clients = result.First();
                        list.Items.Add(new ListViewItem(new[] { clients.Id.ToString(), clients.FirstName, clients.LastName, clients.BD.ToShortDateString(), clients.Email }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public void GetByEmail(string email, ListView list)
        {
            Clients clients = null;
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var result = db.Clients.Where(c => c.Email == email);
                    if (result.Count() > 0)
                    {
                        clients = result.First();
                        list.Items.Add(new ListViewItem(new[] { clients.Id.ToString(), clients.FirstName, clients.LastName, clients.BD.ToShortDateString(), clients.Email }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        public void Update(ListView list, bool add = false, bool delete = false)
        {
            if (list.SelectedItems.Count > 0)
            {
                Clients clients = new Clients() { Id = Convert.ToInt32(list.SelectedItems[0].Text), FirstName = list.FocusedItem.SubItems[1].Text, LastName = list.FocusedItem.SubItems[2].Text, BD = Convert.ToDateTime(list.FocusedItem.SubItems[3].Text), Email = list.FocusedItem.SubItems[4].Text };
                Anceta_Client anceta_ = new Anceta_Client(clients);
                if (anceta_.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            if (anceta_.clients.Id > 0)
                            {
                                db.stp_Update_Client(iD: anceta_.clients.Id, firstName: anceta_.clients.FirstName, lastName: anceta_.clients.LastName, bD: anceta_.clients.BD, email: anceta_.clients.Email);
                                db.SaveChanges();
                                MessageBox.Show($"Клиент c ID = {clients.Id} изменен", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new_list(list);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Клиент c ID = {clients.Id} не был изменен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
        }

 
        public void Client_Event(int event_id, ListView list)
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var clients = db.stp_Client_Event(event_id).ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.FirstName, item.LastName, item.BD.ToShortDateString(), item.Email }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               

            }
        }

        public void new_list(ListView list)
        {
            list.Items.Clear();
            All(list);
        }

        public void OrderBy_List(ColumnClickEventArgs e, ListView list, bool n = true)
        {
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    List<Clients> result = null;
                    switch (e.Column)
                    {
                        case 0: { result = db.Clients.OrderBy(client => client.Id).ToList(); } break;
                        case 1: { result = db.Clients.OrderBy(client => client.FirstName).ToList(); } break;
                        case 2: { result = db.Clients.OrderBy(client => client.LastName).ToList(); } break;
                        case 3: { result = db.Clients.OrderBy(client => client.BD).ToList(); } break;
                    }
                    if (result != null)
                    {
                        list.Items.Clear();
                        foreach (var item in result)
                        {
                            list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.FirstName, item.LastName, item.BD.ToShortDateString(), item.Email }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        public void Activ_Client(ListView list)
        {
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var clients = db.Active_client_sp().FirstOrDefault();
                    if(clients != null)
                    {
                        list.Items.Clear();
                        list.Items.Add(new ListViewItem(new[] {clients.Id.ToString(), clients.FirstName, clients.LastName, clients.BD.ToShortDateString(), clients.Email }));
                        MessageBox.Show($"Клиент подписан на {clients.Count_Events.ToString()}", "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }
    }
}
