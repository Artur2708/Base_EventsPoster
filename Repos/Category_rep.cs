using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_EventsPoster.Repos
{
    public class Category_rep : IRepositories<Сategories>
    {

        public void Add(ListView list)
        {
            Cat cat = new Cat();
            if (cat.ShowDialog() == DialogResult.OK)
            {
                using (var db = new EventsPoster2Entities())
                {
                    try
                    {
                        db.stp_Insert_Cat(category: cat.cat.Category);
                        db.SaveChanges();
                        MessageBox.Show($"Категория добавлена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_list(list);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Такая категория уже есть!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    var cat = db.stp_info_Сategories().ToList();
                    foreach (var item in cat)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.Category }));
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
                if (MessageBox.Show($"Вы хотите удалить категорию с ID = {id} ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            db.stp_Del_Cat(iD: id);
                            db.SaveChanges();
                            MessageBox.Show($"Категория c ID = {id} удален", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Сategories cat = null;
            list.Items.Clear();
            using (var db = new EventsPoster2Entities())
            {
                try
                {
                    var result = db.Сategories.Where(c => c.Id == id);
                    if (result.Count() > 0)
                    {
                        cat = result.First();
                        list.Items.Add(new ListViewItem(new[] { cat.Id.ToString(), cat.Category }));
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
                Сategories сategories = new Сategories() { Id = Convert.ToInt32(list.SelectedItems[0].Text), Category = list.FocusedItem.SubItems[1].Text };
                Cat anceta_ = new Cat(сategories);
                if (anceta_.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EventsPoster2Entities())
                    {
                        try
                        {
                            db.stp_Update_Cat(iD: anceta_.cat.Id, category: anceta_.cat.Category);
                            db.SaveChanges();
                            MessageBox.Show($"Категория c ID = {anceta_.cat.Id} изменена", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new_list(list);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Категория c ID = {anceta_.cat.Id} не изменена", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    List<Сategories> result = null;
                    switch (e.Column)
                    {
                        case 0: { result = db.Сategories.OrderBy(cat => cat.Id).ToList(); } break;
                        case 1: { result = db.Сategories.OrderBy(cat => cat.Category).ToList(); } break;
                    }
                    if (result != null)
                    {
                        list.Items.Clear();
                        foreach (var item in result)
                        {
                            list.Items.Add(new ListViewItem(new[] { item.Id.ToString(), item.Category }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        public void Cat_Event(int id_event, ListView list)
        {
            using (var db = new EventsPoster2Entities())
            {
              var result =  db.stp_Cat_Event(id_event).FirstOrDefault();
                if(result != null)
                {
                    list.Items.Clear();
                    list.Items.Add(new ListViewItem(new[] { result.Id.ToString(), result.Category }));
                }
                
            }
        }
    }
}
