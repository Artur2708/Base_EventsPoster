using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_EventsPoster.Repos
{
    public class Event_rep : IRepositories<Event_>
    {
        public void Add(ListView list)
        {
            Anceta_Event anceta_Event = new Anceta_Event();
            if (anceta_Event.ShowDialog() == DialogResult.OK)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
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
                            db.stp_Delete_Event_(iD: id);
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
            Event_ ev = null;
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var result = db.Event_.Where(e => e.Id == id);
                    if (result.Count() > 0)
                    {
                        ev = result.FirstOrDefault();
                        list.Items.Add(new ListViewItem(new[] {  ev.Id.ToString(),ev.Name_Event.ToString(), ev.Event_Category_Id.ToString(),ev.Date_Start.ToShortDateString(),ev.Date_Finish.ToShortDateString(),ev.Сity,ev.Place,Convert.ToDateTime( ev.Time_.ToString()).ToShortTimeString(),
                    ev.Event_description.ToString(),  ev.Age_limitation.ToString(),ev.Maximum_count_tickets.ToString(), ev.Purchased_count_tickets.ToString(), ev.Price_id.ToString()}));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public Event_ Id(int id)
        {
            Event_ ev = null;
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var result = db.Event_.Where(e => e.Id == id);
                    if (result.Count() > 0) ev = result.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return ev;


            }
        }

        public void Update( ListView list, bool add = false, bool delete = false)
        {
            if (list.SelectedItems.Count > 0)
            {
                Event_ entity = new Event_() { Id = Convert.ToInt32(list.SelectedItems[0].Text), Name_Event = list.FocusedItem.SubItems[1].Text, Event_Category_Id = Convert.ToInt32(list.FocusedItem.SubItems[2].Text), Date_Start = Convert.ToDateTime(list.FocusedItem.SubItems[3].Text), Date_Finish = Convert.ToDateTime(list.FocusedItem.SubItems[4].Text), Сity = list.FocusedItem.SubItems[5].Text, Place = list.FocusedItem.SubItems[6].Text, Time_ = TimeSpan.Parse(list.FocusedItem.SubItems[7].Text), Event_description = list.FocusedItem.SubItems[8].Text, Age_limitation = Convert.ToInt32(list.FocusedItem.SubItems[9].Text), Maximum_count_tickets = Convert.ToInt32(list.FocusedItem.SubItems[10].Text), Purchased_count_tickets = Convert.ToInt32(list.FocusedItem.SubItems[11].Text), Price_id = Convert.ToInt32(list.FocusedItem.SubItems[12].Text) };
                Anceta_Event anceta_Event = new Anceta_Event(entity);
                if (anceta_Event.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            if (add) anceta_Event.event_.Purchased_count_tickets += 1;
                            if (delete) anceta_Event.event_.Purchased_count_tickets -= 1;
                            if (anceta_Event.event_.Id > 0)
                            {
                                db.stp_Update_Event(iD: anceta_Event.event_.Id,
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
                                purchased_count_tickets: anceta_Event.event_.Purchased_count_tickets,
                                price_id: anceta_Event.event_.Price_id);
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

        public void Name_Event(string symbol, ListView list )
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var events = db.stp_Name_Event(symbol).ToList();
                    foreach (var item in events)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                    item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(),item.Price_id.ToString()}));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public void Event_Category_(int cat_id, int client_id, ListView list)
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                { 
                    var events = db.stp_Event_Category_Id(cat_id, client_id).ToList();
                    foreach (var item in events)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                    item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
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
                    var events = db.stp_info_Event().ToList();
                    foreach (var item in events)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                    item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }

        public void All_for_ticket(ListView list)
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var events = db.stp_info_Event().ToList();
                    foreach (var item in events)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Date_Start.ToShortDateString(),item.Сity.ToString()}));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }


        public void Event_Client(ListView list, int id_client)
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var events = db.stp_Event_Client(id_client).ToList();
                    if(events.Count>0)
                    {
                        foreach (var item in events)
                        {
                            list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }

        public void Actual_Event_for_Client( int client_id, ListView list)
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var events = db.stp_Actual_Event_for_Client(client_id).ToList();
                    if (events.Count > 0)
                    {
                        foreach (var item in events)
                        {
                            list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               

            }
        }

        public void Actual_events(ListView list)
        {
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var events = db.Actual_events_sp().ToList();
                    if (events.Count > 0)
                    {
                        foreach (var item in events)
                        {
                            list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }

        public void Del_date()
        {
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    db.stp_Delete_Date(DateTime.Now);
                    db.SaveChanges();
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
                    List<Event_> result = null;
                    switch (e.Column)
                    {
                        case 0: { result = db.Event_.OrderBy(event_ => event_.Id).ToList(); } break;
                        case 1: { result = db.Event_.OrderBy(event_ => event_.Name_Event).ToList(); } break;
                        case 2: { result = db.Event_.OrderBy(event_ => event_.Event_Category_Id).ToList(); } break;
                        case 3: { result = db.Event_.OrderBy(event_ => event_.Date_Start).ToList(); } break;
                        case 5: { result = db.Event_.OrderBy(event_ => event_.Сity).ToList(); } break;
                        case 9: { result = db.Event_.OrderBy(event_ => event_.Age_limitation).ToList(); } break;
                        case 10: { result = db.Event_.OrderBy(event_ => event_.Maximum_count_tickets).ToList(); } break;
                        case 11: { result = db.Event_.OrderBy(event_ => event_.Purchased_count_tickets).ToList(); } break;
                    }
                    if ( result!= null)
                    {
                        list.Items.Clear();
                        if (n)
                        {
                            foreach (var item in result)
                            {
                                list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                            }
                        }
                        else
                        {
                            foreach (var item in result)
                            {
                                list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.Name_Event.ToString(), item.Date_Start.ToShortDateString(), item.Сity.ToString() }));
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


        public void Price_Event_Search(ListView list, int id,decimal num)
        {
            using (var db = new EventsPoster2Entities())
            {
               var result =  db.stp_Price_Event_Search(id: id, price: num).ToList();
                if(result.Count>0)
                {
                    list.Items.Clear();
                    foreach (var item in result)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                    }
                }
                
            }
        }

        public void Event_dateNow(ListView list, DateTime date, int id)
        {
            using (var db = new EventsPoster2Entities())
            {
                var result = db.stp_Event_dateNow(id: id, date: date).ToList();
                if (result.Count > 0)
                {
                    list.Items.Clear();
                    foreach (var item in result)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                    }
                }
                else MessageBox.Show($"Событий на эту дату нет", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Event_City(ListView list, string city, int id)
        {
            using (var db = new EventsPoster2Entities())
            {
                var result = db.stp_Event_City(id: id, city: city).ToList();
                if (result.Count > 0)
                {
                    list.Items.Clear();
                    foreach (var item in result)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                    }
                }
                else MessageBox.Show($"Событий в этом городе нет", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void OrderBy_5_DESC(ListView list)
        {
            using (var db = new EventsPoster2Entities())
            {
                var result = db.Event_.OrderByDescending(ev => ev.Id).ToList();
                if (result.Count > 0)
                {
                    list.Items.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        list.Items.Add(new ListViewItem(new[] {  result[i].Id.ToString(),result[i].Name_Event.ToString(), result[i].Event_Category_Id.ToString(),result[i].Date_Start.ToShortDateString(),result[i].Date_Finish.ToShortDateString(),result[i].Сity,result[i].Place,Convert.ToDateTime( result[i].Time_.ToString()).ToShortTimeString(),
                            result[i].Event_description.ToString(),  result[i].Age_limitation.ToString(),result[i].Maximum_count_tickets.ToString(), result[i].Purchased_count_tickets.ToString(), result[i].Price_id.ToString()}));
                    }
                }

            }
        }

        public int Event_Count(int id_client)
        {
            using (var db = new EventsPoster2Entities())
            {
                ObjectParameter parameter = new ObjectParameter("Count_", 0);
                 db.stp_Event_Count(id_client, parameter);
                return (int)parameter.Value;
            }
        }

        public void Cat(int id_cat, ListView list)
        {
            using (var db = new EventsPoster2Entities())
            {
                var result = db.Event_.Where(e => e.Сategories.Id == id_cat).ToList();
                if(result.Count>0)
                {
                    list.Items.Clear();
                    foreach (var item in result)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                    }
                }
            }
        }

        public void Event_for_today(ListView list)
        {
            using (var db = new EventsPoster2Entities())
            {
                var result = db.Event_for_today_sp().ToList();
                if (result.Count > 0)
                {
                    list.Items.Clear();
                    foreach (var item in result)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                    }
                }
                else MessageBox.Show($"Событий на сегодня нет", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Event_100(ListView list)
        {
            using (var db = new EventsPoster2Entities())
            {
                var result = db.Sold_out_all_tickets_sp().ToList();
                if (result.Count > 0)
                {
                    list.Items.Clear();
                    foreach (var item in result)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                    }
                }
                else MessageBox.Show($"Событий со 100% продажей нет", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Top_3_event(ListView list)
        {
            using (var db = new EventsPoster2Entities())
            {
                var result = db.Sold_in_3_days_sp().ToList();
                if (result.Count > 0)
                {
                    list.Items.Clear();
                    foreach (var item in result)
                    {
                        list.Items.Add(new ListViewItem(new[] {  item.Id.ToString(),item.Name_Event.ToString(), item.Event_Category_Id.ToString(),item.Date_Start.ToShortDateString(),item.Date_Finish.ToShortDateString(),item.Сity,item.Place,Convert.ToDateTime( item.Time_.ToString()).ToShortTimeString(),
                            item.Event_description.ToString(),  item.Age_limitation.ToString(),item.Maximum_count_tickets.ToString(), item.Purchased_count_tickets.ToString(), item.Price_id.ToString()}));
                    }
                }
                else MessageBox.Show($"За последние 5 дней продаж нет", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }



}
