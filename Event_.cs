//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Base_EventsPoster
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event_()
        {
            this.Clients_Event_ = new HashSet<Clients_Event_>();
            this.Pictures_Event = new HashSet<Pictures_Event>();
        }
    
        public int Id { get; set; }
        public string Name_Event { get; set; }
        public int Event_Category_Id { get; set; }
        public System.DateTime Date_Start { get; set; }
        public System.DateTime Date_Finish { get; set; }
        public string Сity { get; set; }
        public string Place { get; set; }
        public System.TimeSpan Time_ { get; set; }
        public string Event_description { get; set; }
        public int Age_limitation { get; set; }
        public int Maximum_count_tickets { get; set; }
        public int Purchased_count_tickets { get; set; }
        public int Price_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clients_Event_> Clients_Event_ { get; set; }
        public virtual Сategories Сategories { get; set; }
        public virtual Price Price { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pictures_Event> Pictures_Event { get; set; }
    }
}