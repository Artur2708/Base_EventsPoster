using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_EventsPoster.Repos
{
    public class Arhiv_rep : IRepositories<Archive>
    {
        public void Add(ListView list)
        {
            Anceta_Event anceta_Event = new Anceta_Event(1);
            if (anceta_Event.ShowDialog() == DialogResult.OK)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        db.stp_insert_Archive(name_Event: anceta_Event.event_.Name_Event,
                       event_Category_Id: anceta_Event.event_.Event_Category_Id,
                       date_Start: anceta_Event.event_.Date_Start,
                       date_Finish: anceta_Event.event_.Date_Finish,
                       сity: anceta_Event.event_.Сity,
                       place: anceta_Event.event_.Place,
                       time_: anceta_Event.event_.Time_,
                       event_description: anceta_Event.event_.Event_description,
                       age_limitation: anceta_Event.event_.Age_limitation,
                       maximum_count_tickets: anceta_Event.event_.Maximum_count_tickets,
                       purchased_count_tickets: anceta_Event.event_.Purchased_count_tickets);
                        db.SaveChanges();
                        MessageBox.Show($"Событие добавлено !", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_list(list);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Такое событие уже было добавлено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var events = db.stp_info_Archive().ToList();
                    foreach (var item in events)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                    item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString()}));
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
                if (MessageBox.Show($"Вы хотите удалить событие с ID = {id} ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            db.stp_Del_Archive(iD: id);
                            db.SaveChanges();
                            MessageBox.Show($"Событие c ID = {id} удалено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Archive ar = null;
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var result = db.Archive.Where(e => e.Id == id);
                    if (result.Count() > 0)
                    {
                        ar = result.First();
                        list.Items.Add(new ListViewItem(new[] {  ar.Id.ToString(),ar.Name_Event.ToString(), ar.Event_Category_Id.ToString(),ar.Date_Start.ToShortDateString(),ar.Date_Finish.ToShortDateString(),ar.Сity,ar.Place,Convert.ToDateTime( ar.Time_.ToString()).ToShortTimeString(),
                        ar.Event_description.ToString(),  ar.Age_limitation.ToString(),ar.Maximum_count_tickets.ToString(), ar.Purchased_count_tickets.ToString()}));
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
                Event_ entity = new Event_() { Id = Convert.ToInt32(list.SelectedItems[0].Text), Name_Event = list.FocusedItem.SubItems[1].Text, Event_Category_Id = Convert.ToInt32(list.FocusedItem.SubItems[2].Text), Date_Start = Convert.ToDateTime(list.FocusedItem.SubItems[3].Text), Date_Finish = Convert.ToDateTime(list.FocusedItem.SubItems[4].Text), Сity = list.FocusedItem.SubItems[5].Text, Place = list.FocusedItem.SubItems[6].Text, Time_ = TimeSpan.Parse(list.FocusedItem.SubItems[7].Text), Event_description = list.FocusedItem.SubItems[8].Text, Age_limitation = Convert.ToInt32(list.FocusedItem.SubItems[9].Text), Maximum_count_tickets = Convert.ToInt32(list.FocusedItem.SubItems[10].Text), Purchased_count_tickets = Convert.ToInt32(list.FocusedItem.SubItems[11].Text)};
                Anceta_Event anceta_Event = new Anceta_Event(entity,1);
                if (anceta_Event.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            if (anceta_Event.event_.Id > 0)
                            {
                                db.stp_Update_Archive(iD: anceta_Event.event_.Id,
                                name_Event: anceta_Event.event_.Name_Event,
                                event_Category_Id: anceta_Event.event_.Event_Category_Id,
                                date_Start: anceta_Event.event_.Date_Start,
                                date_Finish: anceta_Event.event_.Date_Finish,
                                сity: anceta_Event.event_.Сity,
                                place: anceta_Event.event_.Place,
                                time_: anceta_Event.event_.Time_,
                                event_description: anceta_Event.event_.Event_description,
                                age_limitation: anceta_Event.event_.Age_limitation,
                                maximum_count_tickets: anceta_Event.event_.Maximum_count_tickets,
                                purchased_count_tickets: anceta_Event.event_.Purchased_count_tickets);
                                db.SaveChanges();
                                MessageBox.Show($"Событие c ID = {anceta_Event.event_.Id} изменено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new_list(list);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Событие c ID = {anceta_Event.event_.Id} не было изменено", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }

            }
        }

        public void Update_Event(ListView list)
        {
            if (list.SelectedItems.Count > 0)
            {
                Event_ entity = new Event_() { Id = Convert.ToInt32(list.SelectedItems[0].Text), Name_Event = list.FocusedItem.SubItems[1].Text, Event_Category_Id = Convert.ToInt32(list.FocusedItem.SubItems[2].Text), Date_Start = Convert.ToDateTime(list.FocusedItem.SubItems[3].Text), Date_Finish = Convert.ToDateTime(list.FocusedItem.SubItems[4].Text), Сity = list.FocusedItem.SubItems[5].Text, Place = list.FocusedItem.SubItems[6].Text, Time_ = TimeSpan.Parse(list.FocusedItem.SubItems[7].Text), Event_description = list.FocusedItem.SubItems[8].Text, Age_limitation = Convert.ToInt32(list.FocusedItem.SubItems[9].Text), Maximum_count_tickets = Convert.ToInt32(list.FocusedItem.SubItems[10].Text), Purchased_count_tickets = Convert.ToInt32(list.FocusedItem.SubItems[11].Text) };
                Anceta_Event anceta_Event = new Anceta_Event(entity);
                if (anceta_Event.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            if (anceta_Event.event_.Id > 0)
                            {
                                db.stp_Insert_Event(name_Event: anceta_Event.event_.Name_Event,
                                event_Category_Id: anceta_Event.event_.Event_Category_Id,
                                date_Start: anceta_Event.event_.Date_Start,
                                date_Finish: anceta_Event.event_.Date_Finish,
                                сity: anceta_Event.event_.Сity,
                                place: anceta_Event.event_.Place,
                                time_: anceta_Event.event_.Time_,
                                event_description: anceta_Event.event_.Event_description,
                                age_limitation: anceta_Event.event_.Age_limitation,
                                maximum_count_tickets: anceta_Event.event_.Maximum_count_tickets,
                                purchased_count_tickets: anceta_Event.event_.Purchased_count_tickets,
                                price_id: anceta_Event.event_.Price_id);
                                db.SaveChanges();
                                MessageBox.Show($"Событиe = {anceta_Event.event_.Id} вернулось в активные события", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new_list(list);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Событиe = {anceta_Event.event_.Id} не удалось вернулось в активные события", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    List<Archive> result = null;
                    switch (e.Column)
                    {
                        case 0: { result = db.Archive.OrderBy(event_ => event_.Id).ToList(); } break;
                        case 1: { result = db.Archive.OrderBy(event_ => event_.Name_Event).ToList(); } break;
                        case 2: { result = db.Archive.OrderBy(event_ => event_.Event_Category_Id).ToList(); } break;
                        case 3: { result = db.Archive.OrderBy(event_ => event_.Date_Start).ToList(); } break;
                        case 5: { result = db.Archive.OrderBy(event_ => event_.Сity).ToList(); } break;
                        case 9: { result = db.Archive.OrderBy(event_ => event_.Age_limitation).ToList(); } break;
                        case 10: { result = db.Archive.OrderBy(event_ => event_.Maximum_count_tickets).ToList(); } break;
                        case 11: { result = db.Archive.OrderBy(event_ => event_.Purchased_count_tickets).ToList(); } break;
                    }
                    if (result != null)
                    {
                        list.Items.Clear();
                        foreach (var item in result)
                        {
                            list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString()}));
                        }

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
