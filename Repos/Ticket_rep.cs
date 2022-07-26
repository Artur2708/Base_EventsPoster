using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_EventsPoster.Repos
{
    public class Ticket_rep : IRepositories<Clients_Event_>
    {

        public void Add(ListView event_)
        {
            Add_Ticket anceta_ = new Add_Ticket();
            if (anceta_.ShowDialog() == DialogResult.OK)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        string name = event_.FocusedItem.SubItems[1].Text;
                        db.stp_Insert_Ticket(event_id: anceta_.ticket_.Event_id, client_Id: anceta_.ticket_.Client_Id, price: anceta_.ticket_.Price, purchase_date: anceta_.ticket_.Purchase_date);
                        db.SaveChanges();
                        MessageBox.Show($"Билет добавлен на {name}!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        public void Add_client(ListView event_, int Event_Id, int Client_Id)
        {
            Add_Ticket anceta_ = new Add_Ticket(Event_Id, Client_Id);
            if (anceta_.ShowDialog() == DialogResult.OK)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        string name = event_.FocusedItem.SubItems[1].Text;
                        db.stp_Insert_Ticket(event_id: anceta_.ticket_.Event_id, client_Id: anceta_.ticket_.Client_Id, price: anceta_.ticket_.Price, purchase_date: anceta_.ticket_.Purchase_date);
                        db.SaveChanges();
                        MessageBox.Show($"Билет добавлен на {name}!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Билет уже куплен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                   
               
            }
        }

        public void Client(ListView list, int id)
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var clients_event = db.stp_Clients_Event_Search_Event_id(id).ToList();
                    foreach (var item in clients_event)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.Event_id.ToString(), item.Client_Id.ToString(), Math.Round((decimal)item.Price, 2).ToString(), item.Purchase_date.ToShortDateString() }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var clients_event = db.stp_info_Client_Event_().ToList();
                    foreach (var item in clients_event)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.Event_id.ToString(), item.Client_Id.ToString(), Math.Round((decimal)item.Price, 2).ToString(), item.Purchase_date.ToShortDateString() }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public void Event(ListView list,int id )
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var clients_event = db.stp_Clients_Event_Search_Client_Id(id).ToList();
                    foreach (var item in clients_event)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.Event_id.ToString(), item.Client_Id.ToString(), Math.Round((decimal)item.Price, 2).ToString(), item.Purchase_date.ToShortDateString() }));
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
                if (MessageBox.Show($"Вы хотите удалить билет с ID = {id} ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            db.stp_Delete_Ticket_Client_info(iD_Client: Convert.ToInt32(list.FocusedItem.SubItems[2].Text), iD_Event: Convert.ToInt32(list.FocusedItem.SubItems[1].Text));
                            db.SaveChanges();
                            MessageBox.Show($"Билет c ID = {id} удален", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Delete_Ticket_Client_info(int id_event, int id_client)
        {
            if (MessageBox.Show($"Вы хотите удалить билет ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        db.stp_Delete_Ticket_Client_info(iD_Client: id_client, iD_Event: id_event);
                        db.SaveChanges();
                        MessageBox.Show($"Билет на удален", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }

       
        public void GetById(int id, ListView list)
        {
            Clients_Event_ clients_event_ = null;
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var result = db.Clients_Event_.Where(c => c.Id == id);
                    if (result.Count() > 0)
                    {
                        clients_event_ = result.First();
                        list.Items.Add(new ListViewItem(new[] { clients_event_.Id.ToString(), clients_event_.Event_id.ToString(), clients_event_.Client_Id.ToString(), Math.Round((decimal)clients_event_.Price, 2).ToString(), clients_event_.Purchase_date.ToShortDateString() }));
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

        public void Update(ListView list, bool add = false, bool delete = false)
        {
            if (list.SelectedItems.Count > 0)
            {
                Clients_Event_ ticket = new Clients_Event_() { Id = Convert.ToInt32(list.SelectedItems[0].Text), Event_id = Convert.ToInt32(list.FocusedItem.SubItems[1].Text), Client_Id = Convert.ToInt32(list.FocusedItem.SubItems[2].Text), Price = Convert.ToDecimal(list.FocusedItem.SubItems[3].Text), Purchase_date = Convert.ToDateTime(list.FocusedItem.SubItems[4].Text) };
                Add_Ticket anceta_ = new Add_Ticket(ticket);
                if (anceta_.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            if (anceta_.ticket_.Id > 0)
                            {
                                db.stp_Update_Ticket(iD: anceta_.ticket_.Id,
                                    event_id: anceta_.ticket_.Event_id,
                                    client_Id: anceta_.ticket_.Client_Id,
                                    price: anceta_.ticket_.Price,
                                    purchase_date: anceta_.ticket_.Purchase_date);
                                db.SaveChanges();
                                MessageBox.Show($"Билет c ID = {anceta_.ticket_.Id} изменен", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new_list(list);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Билет c ID = {anceta_.ticket_.Id} не был изменен", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
        }

        public void OrderBy_List(ColumnClickEventArgs e, ListView list, bool n = true)
        {
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    List<Clients_Event_> result = null;
                    switch (e.Column)
                    {
                        case 0: { result = db.Clients_Event_.OrderBy(tic => tic.Id).ToList(); } break;
                        case 1: { result = db.Clients_Event_.OrderBy(tic => tic.Event_id).ToList(); } break;
                        case 2: { result = db.Clients_Event_.OrderBy(tic => tic.Client_Id).ToList(); } break;
                        case 3: { result = db.Clients_Event_.OrderBy(tic => tic.Price).ToList(); } break;
                        case 4: { result = db.Clients_Event_.OrderBy(tic => tic.Purchase_date).ToList(); } break;
                    }
                    if (result != null)
                    {
                        list.Items.Clear();
                        foreach (var item in result)
                        {
                            list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.Event_id.ToString(), item.Client_Id.ToString(), Math.Round((decimal)item.Price, 2).ToString(), item.Purchase_date.ToShortDateString() }));
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        public void Ticket_for_cat(ListView list, ListView tic)
        {
            if(list.SelectedItems.Count >0)
            {
                using (var db = new EventsPoster2Entities())
                {
                   var result =  db.stp_Ticket_for_cat(Convert.ToInt32(list.SelectedItems[0].Text)).ToList();
                    if(result.Count() >0)
                    {
                        tic.Items.Clear();
                        foreach (var item in result)
                        {
                            tic.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.Event_id.ToString(), item.Client_Id.ToString(), Math.Round((decimal)item.Price, 2).ToString(), item.Purchase_date.ToShortDateString() }));
                        }
                    }
                }
            }
        }
    }
}
