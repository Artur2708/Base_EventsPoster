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
    
    public partial class stp_info_Archive_Result
    {
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
    }
}
