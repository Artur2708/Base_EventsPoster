using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_EventsPoster.Repos
{
    public class Price_rep : IRepositories<Price>
    {
        public void Add(ListView list)
        {
            Price_Event pe = new Price_Event();
            if(pe.ShowDialog() == DialogResult.OK)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        db.stp_insert_Price(min_: pe.price.Min_, ave: pe.price.Ave, max_: pe.price.Max_);
                        db.SaveChanges();
                        MessageBox.Show($"Цены были добавлены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_list(list);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Цены не были добавлены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            } 
        }

        public void All(ListView list)
        {
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var result = db.Price.ToList();
                    list.Items.Clear();
                    if (result.Count > 0)
                    {
                        foreach (var item in result)
                        {
                        list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), Math.Round((decimal)item.Min_,2).ToString(), Math.Round((decimal)item.Ave, 2).ToString(), Math.Round((decimal)item.Max_, 2).ToString()}));
                        }
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
                if (MessageBox.Show($"Вы хотите удалить цену с ID = {id} ? Так же будут удалены все события с этой ценновой политикой!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            db.stp_Delete_Price(id);
                            db.SaveChanges();
                            MessageBox.Show($"Цена c ID = {id} удалена. Так же удалены все события с этой ценновой политикой!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Price ar = null;
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var result = db.Price.Where(e => e.Id == id);
                    if (result.Count() > 0)
                    {
                        ar = result.First();
                        list.Items.Add(new ListViewItem(new[] {  ar.Id.ToString(), Math.Round((decimal)ar.Min_, 2).ToString(), Math.Round((decimal)ar.Ave, 2).ToString(), Math.Round((decimal)ar.Max_, 2).ToString()}));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public stp_Price_Event__Result id(int id)
        {
            using (var db = new EventsPoster2Entities())
            {
                var result = db.stp_Price_Event_(id).First();
                return result;

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
                    List<Price> result = null;
                    switch (e.Column)
                    {
                        case 0: { result = db.Price.OrderBy(p => p.Id).ToList(); } break;
                        case 1: { result = db.Price.OrderBy(p => p.Min_).ToList(); } break;
                        case 2: { result = db.Price.OrderBy(p => p.Ave).ToList(); } break;
                        case 3: { result = db.Price.OrderBy(p => p.Max_).ToList(); } break;
                    }
                    if (result != null)
                    {
                        list.Items.Clear();
                        foreach (var item in result)
                        {
                            list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), Math.Round((decimal)item.Min_, 2).ToString(), Math.Round((decimal)item.Ave, 2).ToString(), Math.Round((decimal)item.Max_, 2).ToString() }));
                        }

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
                Price price = new Price() { Id = Convert.ToInt32(list.SelectedItems[0].Text), Min_ = Convert.ToDecimal(list.FocusedItem.SubItems[1].Text), Ave = Convert.ToDecimal(list.FocusedItem.SubItems[2].Text), Max_ = Convert.ToDecimal(list.FocusedItem.SubItems[3].Text) };
                Price_Event anceta_ = new Price_Event(price);
                if (anceta_.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            if (anceta_.price.Id > 0)
                            {
                                db.stp_Update_Price(id: anceta_.price.Id, min_: anceta_.price.Min_, ave: anceta_.price.Ave, max_: anceta_.price.Max_);
                                db.SaveChanges();
                                MessageBox.Show($"Цена c ID = {anceta_.price.Id} изменена", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new_list(list);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Цена c ID = {anceta_.price.Id} не была изменена", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
        }
    }

}
